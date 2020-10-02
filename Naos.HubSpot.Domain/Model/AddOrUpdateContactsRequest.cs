// <copyright file="AddOrUpdateContactsRequest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the body of an add or update contacts request.
    /// </summary>
    public partial class AddOrUpdateContactsRequest : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateContactsRequest"/> class.
        /// </summary>
        /// <param name="vid">The Vid of the contact, if known.</param>
        /// <param name="email">The email of the contact.</param>
        /// <param name="properties">The properties of the HubSpot contact.</param>
        public AddOrUpdateContactsRequest(int? vid, string email, IReadOnlyCollection<PropertyModel> properties)
        {
            properties.MustForArg(nameof(properties)).ContainElement(HubSpotContactPropertyNames.EmailAddress, "A HubSpot contact must have an email address.");
            (!vid.HasValue && !string.IsNullOrEmpty(email)).MustForArg("BothCannotBeNull").NotBeTrue();
            this.Vid = vid;
            this.Email = email;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the HubSpot ID of the contact.
        /// </summary>
        public int? Vid { get; private set; }

        /// <summary>
        /// Gets the email of the HubSpot contact.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        ///  Gets the properties of the HubSpot contact.
        /// </summary>
        public IReadOnlyCollection<PropertyModel> Properties { get; private set; }
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
            var properties = contact.Properties.Select(_ => new PropertyModel(_.Key, _.Value)).ToList();
            properties.MustForArg(nameof(properties)).ContainElement("email");
            if (properties.Any(_ => _.Name == "vid"))
            {
                var vid = Convert.ToInt32(properties.Single(_ => _.Name == "vid").Value, CultureInfo.InvariantCulture);
                var filteredProperties = properties.Where(_ => _.Name != "vid").ToList();
                var contactProperties = filteredProperties;
                return new AddOrUpdateContactsRequest(vid, null, contactProperties);
            }
            else
            {
                var email = properties.Single(_ => _.Name == "email").Value;
                var filteredProperties = properties.Where(_ => _.Name != "email").ToList();
                var contactProperties = filteredProperties;
                return new AddOrUpdateContactsRequest(null, email, contactProperties);
            }
        }
    }
}
