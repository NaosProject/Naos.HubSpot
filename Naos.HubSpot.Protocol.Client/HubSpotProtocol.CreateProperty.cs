// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.CreateProperty.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<CreatePropertyV3Op, PropModel>
    {
        /// <inheritdoc />
        public PropModel Execute(CreatePropertyV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<PropModel> ExecuteAsync(CreatePropertyV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/properties");
            uri = uri.AppendPathSegment(operation.ObjectType.ToString().ToLower());
            var result = uri.WithBody(operation.ObjectType == HubSpotPropertyObjectType.Company ? operation.PropModelToAdd.ToCompanyPropertyModel() : operation.PropModelToAdd.ToContactPropertyModel()).Post<PropertyModel>();
            var propertyToReturn = result.ToProperty();
            return await Task.FromResult(propertyToReturn);
        }
    }
}
