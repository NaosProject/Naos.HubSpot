// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.UpdateCompanies.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncVoidProtocol<UpdateCompaniesOp>
    {
        /// <inheritdoc />
        public void Execute(UpdateCompaniesOp operation)
        {
            var task = this.ExecuteAsync(operation);
            Run.TaskUntilCompletion(task);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(UpdateCompaniesOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("companies/v1/batch-async/update");
            var reqBody = new List<object>();
            foreach (var company in operation.CompaniesToUpdate)
            {
                string rawObjectId = company.Properties.Single(_ => _.Key == StandardCompanyPropertyName.ObjectId.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary()).Value;
                if (string.IsNullOrWhiteSpace(rawObjectId) || !long.TryParse(rawObjectId, out var objectId))
                {
                    throw new InvalidOperationException("The company's object ID cannot be null and has to be convertible into an integer.  Current: " + rawObjectId);
                }

                var props = company.Properties
                    .Where(_ => _.Key.ToLower() != StandardCompanyPropertyName.ObjectId.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary() || _.Key != "objectId")
                    .Select(x => new { name=x.Key, value=x.Value })
                    .ToList();
                reqBody.Add(new { objectId, properties=props });
            }

            uri.WithBody(reqBody).Post();
            await Task.Factory.StartNew(() => true);
        }
    }
}
