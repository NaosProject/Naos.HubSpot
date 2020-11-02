// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.RemoveContactV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<RemoveContactByHubSpotIdV3Op, ContactV3>
    {
        /// <inheritdoc />
        public ContactV3 Execute(RemoveContactByHubSpotIdV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<ContactV3> ExecuteAsync(RemoveContactByHubSpotIdV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/contacts");
            uri = uri.AppendPathSegment(operation.HubSpotId);
            var result = uri.Delete<ContactModelV3>();
            var contactToReturn = result.ToContactV3();
            return await Task.FromResult(contactToReturn);
        }
    }
}
