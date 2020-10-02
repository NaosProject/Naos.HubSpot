// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.UpdateCompany.cs" company="Naos Project">
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
    using Naos.HubSpot.Domain.Model;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncVoidProtocol<UpdateCompanyOp>
    {
        /// <inheritdoc />
        public void Execute(UpdateCompanyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            Run.TaskUntilCompletion(task);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(UpdateCompanyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("/companies/v1/batch-async/update");
            var reqBody = new List<UpdateCompanyModel>();
            foreach (var company in operation.CompaniesToUpdate)
            {
                string rawObjectId = company.Properties.Single(_ => _.Key == HubSpotCompanyPropertyNames.ObjectId).Value;
                if (string.IsNullOrWhiteSpace(rawObjectId) || !int.TryParse(rawObjectId, out var objectId))
                {
                    throw new InvalidOperationException("The company's object ID cannot be null and has to be convertible into an integer.  Current: " + rawObjectId);
                }

                var props = company.Properties
                    .Where(_ => _.Key.ToLower() != HubSpotCompanyPropertyNames.CustomId)
                    .Select(x => new PropertyModel(x.Key, x.Value))
                    .ToList();
                reqBody.Add(new UpdateCompanyModel(objectId, props));
            }

            uri.WithBody(reqBody).Post<dynamic>();
            await Task.Factory.StartNew(() => true);
        }
    }
}
