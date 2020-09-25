// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.SyncContactsWithHubSpot.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<SyncContactsWithHubSpotOp, SyncContactsWithHubSpotResult>
    {
        /// <inheritdoc />
        public SyncContactsWithHubSpotResult Execute(SyncContactsWithHubSpotOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public Task<SyncContactsWithHubSpotResult> ExecuteAsync(SyncContactsWithHubSpotOp operation)
        {
            throw new System.NotImplementedException();
        }
    }
}
