// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.AssociateContactWithCompany.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncVoidProtocol<AssociateContactWithCompanyOp>
    {
        /// <inheritdoc />
        public void Execute(AssociateContactWithCompanyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            Run.TaskUntilCompletion(task);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(AssociateContactWithCompanyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm-associations/v1/associations");
            uri.WithBody(CreateRequest(operation)).Put();
            await Task.Run(() => true);
        }

        /// <summary>
        /// Creates the payload of a HubSpot request representing the request to associate the client
        /// in this object to the company in this object.
        /// </summary>
        /// <returns cref="CreateAssociationRequest">The payload for a association API request.</returns>
        private static  CreateAssociationRequest CreateRequest(AssociateContactWithCompanyOp op)
        {
            return new CreateAssociationRequest(op.ContactHubSpotId, op.CompanyHubSpotId, "HUBSPOT_DEFINED", 1);
        }
    }
}
