// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.RemoveCompanyByHubSpotId.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncVoidProtocol<RemoveCompanyByHubSpotIdOp>
    {
        /// <inheritdoc />
        public void Execute(RemoveCompanyByHubSpotIdOp operation)
        {
            var task = this.ExecuteAsync(operation);
            Run.TaskUntilCompletion(task);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(RemoveCompanyByHubSpotIdOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/contacts");
            uri = uri.AppendPathSegment(operation.HubSpotId);
            uri.Delete<CompanyModel>();
            await Task.Factory.StartNew(() => true);
        }
    }
}