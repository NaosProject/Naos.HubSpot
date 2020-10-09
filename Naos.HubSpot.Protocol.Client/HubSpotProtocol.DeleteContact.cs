// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.DeleteContact.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.HubSpot.Domain.Model;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<DeleteContactOp, DeleteContactResponse>
    {
        /// <inheritdoc/>
        public DeleteContactResponse Execute(DeleteContactOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc/>
        public Task<DeleteContactResponse> ExecuteAsync(DeleteContactOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("contacts/v1/contact/vid");
            uri = uri.AppendPathSegment(operation.Vid.ToString(CultureInfo.InvariantCulture));
            var response = uri.Delete<DeleteContactResponse>();
            return Task.FromResult(response);
        }
    }
}