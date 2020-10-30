// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.CreatePropertyV3.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<CreatePropertyV3Op, PropertyModelV3>
    {
        /// <inheritdoc />
        public PropertyModelV3 Execute(CreatePropertyV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<PropertyModelV3> ExecuteAsync(CreatePropertyV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/properties");
            uri = uri.AppendPathSegment(operation.ObjectType);
            var result = uri.WithBody(operation.PropertyToAdd).Post<PropertyModelV3>();
            return await Task.FromResult(result);
        }
    }
}
