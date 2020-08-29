// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Feature.ApiCommunicator
{
    using System.Threading.Tasks;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubspotProtocol : ISyncAndAsyncReturningProtocol<SyncContactsWithHubspotOp, SyncContactsWithHubspotResult>
    {
        public SyncContactsWithHubspotResult Execute(SyncContactsWithHubspotOp operation)
        {
            throw new System.NotImplementedException();
        }

        public Task<SyncContactsWithHubspotResult> ExecuteAsync(SyncContactsWithHubspotOp operation)
        {
            throw new System.NotImplementedException();
        }
    }
}
