// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.RemoveProperty.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.HubSpot.Domain.Model;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncVoidProtocol<RemovePropertyOp>
    {
        /// <inheritdoc />
        public void Execute(RemovePropertyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            Run.TaskUntilCompletion(task);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(RemovePropertyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/properties");
            uri = uri.AppendPathSegment(operation.PropertyType.ToString().ToLower());
            uri = uri.AppendPathSegment(operation.PropertyName);
            uri.Delete();
            await Task.Factory.StartNew(() => true);
        }
    }
}
