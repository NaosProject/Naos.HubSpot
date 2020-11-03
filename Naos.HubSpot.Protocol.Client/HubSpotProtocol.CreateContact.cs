// <copyright file="HubSpotProtocol.CreateContact.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<CreateContactOp, Contact>
    {
        /// <inheritdoc />
        public Contact Execute(CreateContactOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<Contact> ExecuteAsync(CreateContactOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/contacts");
            var result = uri.WithSerializer(this.bodySerializer).WithBody(operation.ContactToCreate.ToContactRequestModel()).Post<ContactModel>();
            var contactToReturn = result.ToContactV3();
            return await Task.FromResult(contactToReturn);
        }
    }
}
