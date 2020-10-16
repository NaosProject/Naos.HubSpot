// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.CreateContactProperty.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<CreateContactPropertyOp, ContactPropertyModel>
    {
        /// <inheritdoc />
        public ContactPropertyModel Execute(CreateContactPropertyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<ContactPropertyModel> ExecuteAsync(CreateContactPropertyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("properties/v1/contacts/properties");
            var properties = uri.WithBody(operation.Request)
                .Post<ContactPropertyModel>();
            return await Task.FromResult(properties);
        }
    }
}
