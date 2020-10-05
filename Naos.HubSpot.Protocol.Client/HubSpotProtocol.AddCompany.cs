// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.AddCompany.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<AddCompanyOp, Company>
    {
        /// <inheritdoc />
        public Company Execute(AddCompanyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<Company> ExecuteAsync(AddCompanyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("companies/v2/companies");
            var request = operation.CompanyToAdd.Properties.Select(_ => new
            {
                name= _.Key,
                value= _.Value,
            });
            dynamic addedCompany = await Task.FromResult(uri.WithBody(request).Post<dynamic>());
            var propertiesDict = new Dictionary<string, string>();
            dynamic dynCompanyProperties = addedCompany["properties"];
            foreach (var prop in dynCompanyProperties)
            {
                string rawName = prop.Name?.ToString();
                var name = HubSpotCompanyPropertyNames.AllNames.Contains(rawName)
                    ? rawName.FromCompanyPropertyName().ToString()
                    : rawName;

                var val = prop.Value["value"].Value;
                propertiesDict.Add(name, val);
            }

            return new Company(propertiesDict);
        }
    }
}
