// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.AddOrUpdateContacts.cs" company="Naos Project">
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
                var chunk = contactChunk.Select(_ => _.BuildAddOrUpdateContactsRequest());
                uri.WithBody(chunk).Post();
            }

            await Task.Factory.StartNew(() => true);
        }
    }

    /// <summary>
    /// Extension methods to create AddOrUpdateContactsRequests.
    /// </summary>
    public static class AddOrUpdateContactsRequestBuilder
    {
        /// <summary>
        /// Converts a contact into a AddOrUpdateContactRequest.
        /// </summary>
        /// <param name="contact">The HubSpot contact to update.</param>
        /// <returns>Returns an AddOrUpdateContactsRequest.</returns>
        public static AddOrUpdateContactsRequest BuildAddOrUpdateContactsRequest(this Contact contact)
        {
            if (contact.Properties.ContainsKey(StandardContactPropertyName.HubSpotId.ToString()))
            {
                var stringId = contact.Properties[StandardContactPropertyName.HubSpotId.ToString()];
                var vid = int.Parse(stringId, CultureInfo.InvariantCulture);
                var properties = contact
                    .Properties
                    .Where(_ => _.Key != StandardContactPropertyName.HubSpotId.ToString())
                    .Select(_ => new PropertyModel(_.Key.ConvertFromStandardNameToHubSpotNameIfNecessary(), _.Value))
                    .ToList();

                return new AddOrUpdateContactsRequest(vid, null, properties);
            }
            else if (contact.Properties.ContainsKey(StandardContactPropertyName.EmailAddress.ToString()))
            {
                var email = contact.Properties[StandardContactPropertyName.EmailAddress.ToString()];
                var properties = contact
                    .Properties
                    .Where(_ => _.Key != StandardContactPropertyName.EmailAddress.ToString())
                    .Select(_ => new PropertyModel(_.Key.ConvertFromStandardNameToHubSpotNameIfNecessary(), _.Value))
                    .ToList();

                return new AddOrUpdateContactsRequest(null, email, properties);
            }
            else
            {
                throw new ArgumentException(FormattableString.Invariant(
                    $"HubSpot contact properties must contain either an entry for '{StandardContactPropertyName.HubSpotId}' or '{StandardContactPropertyName.EmailAddress}'."));
            }
        }
    }
}