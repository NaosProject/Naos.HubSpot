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
    public partial class HubspotProtocol : ISyncAndAsyncReturningProtocol<SyncWithHubspotOp, SyncWithHubspotResult>
    {
        SyncWithHubspotResult IReturningProtocol<SyncWithHubspotOp, SyncWithHubspotResult>.Execute(SyncWithHubspotOp operation)
        {
            throw new System.NotImplementedException();
        }

        Task<SyncWithHubspotResult> IAsyncReturningProtocol<SyncWithHubspotOp, SyncWithHubspotResult>.ExecuteAsync(SyncWithHubspotOp operation)
        {
            throw new System.NotImplementedException();
        }
    }
}
