// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.AddCompany.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Collections.Generic;
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
            var request = operation.CompanyToAdd.ToAddCompanyRequest();
            dynamic addedCompany = await Task.FromResult(uri.WithBody(request).Post<dynamic>());
            dynamic dynCompanyProps = addedCompany["properties"];
            var companyPropertiesDictionary = new Dictionary<string, string>();
            foreach (var property in dynCompanyProps)
            {
                dynamic dynProp = (dynamic)property;
                string rawName = dynProp.Name?.ToString();
                if (rawName == null)
                {
                    throw new InvalidOperationException("A null property name was retrieved from HubSpot.");
                }

                var val = dynProp["value"].Value;
                companyPropertiesDictionary.Add(rawName, val);
            }

            return new Company(companyPropertiesDictionary);
        }
    }
}
