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
    using Naos.HubSpot.Domain.Model;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<CreatePropertyV3Op, PropertyV3>
    {
        /// <inheritdoc />
        public PropertyV3 Execute(CreatePropertyV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<PropertyV3> ExecuteAsync(CreatePropertyV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/properties");
            uri = uri.AppendPathSegment(operation.ObjectType.ToString().ToLower());
            var result = uri.WithBody(operation.ObjectType == HubSpotPropertyObjectType.Company ? operation.PropertyToAdd.ToCompanyPropertyModelV3() : operation.PropertyToAdd.ToContactPropertyModelV3()).Post<PropertyModelV3>();
            var propertyToReturn = result.ToPropertyV3();
            return await Task.FromResult(propertyToReturn);
        }
    }
}
