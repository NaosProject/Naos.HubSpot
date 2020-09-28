// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.SyncCompaniesWithHubSpot.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Threading.Tasks;
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
        /// Link to API: https://legacydocs.hubspot.com/docs/methods/crm-associations/associate-objects
        public Task ExecuteAsync(AssociateContactWithCompanyOp operation)
        {
            throw new System.NotImplementedException();
        }
    }
}
