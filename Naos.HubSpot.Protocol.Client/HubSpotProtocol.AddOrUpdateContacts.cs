// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.AddOrUpdateContacts.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Linq;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncVoidProtocol<AddOrUpdateContactsOp>
    {
        /// <inheritdoc />
        public void Execute(AddOrUpdateContactsOp operation)
        {
            var task = this.ExecuteAsync(operation);
            Run.TaskUntilCompletion(task);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(AddOrUpdateContactsOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("contacts/v1/contact/batch");
            var contactChunks = operation.ContactsToAddOrUpdate.Chunk(1000).Select(_ => _.ToList()).ToList();
            foreach (var contactChunk in contactChunks)
            {
                uri.WithBody(contactChunk.Select(_ => _.BuildAddOrUpdateContactsRequest())).Put();
            }

            await Task.Factory.StartNew(() => true);
        }
    }
}
