// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.DeleteContactProperty.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncVoidProtocol<DeleteContactPropertyOp>
    {
        /// <inheritdoc />
        public void Execute(DeleteContactPropertyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            Run.TaskUntilCompletion(task);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(DeleteContactPropertyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("properties/v1/contacts/properties/named");
            uri = uri.AppendPathSegment(operation.PropertyName);
            uri.Delete();
            await Task.Factory.StartNew(() => true);
        }
    }
}
