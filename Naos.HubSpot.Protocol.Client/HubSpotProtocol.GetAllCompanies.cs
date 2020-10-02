// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllCompanies.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetAllCompaniesOp, IReadOnlyCollection<Company>>
    {
        /// <inheritdoc />
        public IReadOnlyCollection<Company> Execute(GetAllCompaniesOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyCollection<Company>> ExecuteAsync(GetAllCompaniesOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("companies/v2/companies/paged")
                .AppendQueryStringParam("limit", "250");
            var companies = new List<Company>();
            string offset = string.Empty;
            var hasMore = true;
            foreach (var propName in operation.PropertyNamesToInclude)
            {
                uri = uri.AppendQueryStringParam("Property", propName);
            }

            while (hasMore)
            {
                var batchUri = uri;
                if (!string.IsNullOrEmpty(offset))
                {
                    batchUri = batchUri.AppendQueryStringParam("offset", offset);
                }

                dynamic result = batchUri.Get<dynamic>();
                dynamic dynHasMore = result["has-more"];
                hasMore = (bool)dynHasMore;
                offset = (string)result["offset"];
                dynamic dynCompanies = result["companies"];
                foreach (var dynCompany in dynCompanies)
                {
                    try
                    {
                        var vid = dynCompany["vid"];
                        var propertiesDict = new Dictionary<string, string>();
                        dynamic dyncompanyProperties = dynCompany["properties"];
                        if (dyncompanyProperties.Count == 0)
                        {
                            continue;
                        }

                        foreach (var dynProp in dyncompanyProperties)
                        {
                            string rawName = dynProp.Name?.ToString();
                            var name = HubSpotCompanyPropertyNames.AllNames.Contains(rawName)
                                ? rawName.FromCompanyPropertyName().ToString()
                                : rawName;
                            if (name == null)
                            {
                                throw new InvalidOperationException("The property name cannot be null for contact vid: " + vid);
                            }

                            if (operation.PropertyNamesToInclude.Contains(name))
                            {
                                var val = dynProp.Value["value"].Value;
                                propertiesDict.Add(name, val);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }

            return await Task.FromResult(companies);
        }
    }
}
