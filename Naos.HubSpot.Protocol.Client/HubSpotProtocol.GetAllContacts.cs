// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllContacts.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;
    using OBeautifulCode.Enum.Recipes;
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
            foreach (var propName in operation.PropertyNamesToInclude)
            {
                var isStandardPropertyName = typeof(StandardContactPropertyName).GetDefinedEnumValues()
                    .Select(_ => _.ToString())
                    .Contains(propName);
                var adjustedName = propName;
                if (isStandardPropertyName)
                {
                    var enumName = (StandardContactPropertyName)Enum.Parse(typeof(StandardContactPropertyName), propName);
                    adjustedName = enumName.ToContactPropertyName();
                }

                uri = uri.AppendQueryStringParam("Property", adjustedName);
            }

            var contacts = new List<Contact>();
            var hasMore = true;
            var vidOffset = 0;
            while (hasMore)
            {
                var batchUri = uri.AppendQueryStringParam("after", vidOffset.ToString());
                var serializer = new ObcJsonSerializer();
                var contactBatch = batchUri.WithSerializer(serializer).Get<dynamic>();
                dynamic dynHasMore = contactBatch["has-more"];
                hasMore = (bool)dynHasMore;
                vidOffset = (int)contactBatch["vid-offset"];
                dynamic dynContacts = contactBatch["contacts"];
                foreach (var dynContact in dynContacts)
                {
                    var contactProperties = new Dictionary<string, string>();
                    var properties = ((dynamic)dynContact).properties;
                    var vid = dynContact["vid"];
                    contactProperties.Add(StandardContactPropertyName.HubSpotId.ToString(), vid);
                    foreach (var prop in properties)
                    {
                        dynamic dynProp = (dynamic)prop;
                        string rawName = dynProp.Name?.ToString();
                        var name = HubSpotContactPropertyNames.AllNames.Contains(rawName)
                            ? rawName.FromContactPropertyName().ToString()
                            : rawName;
                        if (name == null)
                        {
                            throw new InvalidOperationException("The property name cannot be null for contact vid: " + vid);
                        }

                        if (operation.PropertyNamesToInclude.Contains(name))
                        {
                            var val = dynProp.Value["value"].Value;
                            contactProperties.Add(name, val);
                        }
                    }

                    string email = null;
                    dynamic identitiesProfiles = (dynamic)dynContact["identity-profiles"];
                    if (identitiesProfiles.Count != 1)
                    {
                        throw new InvalidOperationException(
                            "Received more than one identity profile for contact vid: " + vid);
                    }

                    dynamic identitiesProfile = (dynamic)identitiesProfiles[0];
                    var identities = identitiesProfile["identities"];
                    foreach (var identity in identities)
                    {
                        dynamic dynIdent = (dynamic)identity;
                        if (dynIdent.type == "EMAIL")
                        {
                            if (email != null)
                            {
                                throw new InvalidOperationException("Found more than one email for contact vid: " +
                                                                    vid);
                            }

                            email = dynIdent.value.Value;
                            contactProperties.Add(StandardContactPropertyName.EmailAddress.ToString(), email);
                        }
                    }

                    var contact = new Contact(
                        contactProperties);
                    contacts.Add(contact);
                }
            }

            return await Task.FromResult(contacts);
        }
    }
}
