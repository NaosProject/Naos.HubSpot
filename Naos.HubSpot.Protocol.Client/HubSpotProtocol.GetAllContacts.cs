// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllContacts.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;
    using OBeautifulCode.Serialization.Json;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetAllContactsOp, IReadOnlyCollection<Contact>>
    {
        /// <inheritdoc />
        public IReadOnlyCollection<Contact> Execute(GetAllContactsOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyCollection<Contact>> ExecuteAsync(GetAllContactsOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("contacts/v1/lists/all/contacts/all")
                .AppendQueryStringParam("count", "100");
            var contacts = new List<Contact>();
            var hasMore = true;
            var vidOffset = 0;
            while (hasMore)
            {
                var batchUri = uri.AppendQueryStringParam("after", vidOffset.ToString());
                var serializer = new ObcJsonSerializer();
                var contactBatch = batchUri.WithSerializer(serializer).Get<dynamic>();
                // after = dynamic.paging.after the skip value for the next transaction
                contacts.AddRange(new List<Contact>()); // cast dynamic.results to list of Contact
            }

            return await Task.FromResult(contacts);
        }
    }
}
