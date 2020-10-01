// <copyright file="AddOrUpdateContactsRequest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents the body of an add or update contacts request.
    /// </summary>
    public class AddOrUpdateContactsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateContactsRequest"/> class.
        /// </summary>
        /// <param name="properties">The properties of the HubSpot contact.</param>
        public AddOrUpdateContactsRequest(IReadOnlyCollection<PropertyModel> properties)
        {
            properties.MustForArg(nameof(properties)).ContainElement("email");
            if (properties.Any(_ => _.Property == "vid"))
            {
                this.Vid = Convert.ToInt32(properties.Single(_ => _.Property == "vid").Value, CultureInfo.InvariantCulture);
                var filteredProperties = properties.Where(_ => _.Property != "vid").ToList();
                this.Properties = filteredProperties;
            }
            else
            {
                this.Email = properties.Single(_ => _.Property == "email").Value;
                var filteredProperties = properties.Where(_ => _.Property != "email").ToList();
                this.Properties = filteredProperties;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateContactsRequest"/> class.
        /// </summary>
        /// <param name="contact">The HubSpot contact to update.</param>
        public AddOrUpdateContactsRequest(Contact contact)
        {
            var properties = contact.Properties.Select(_ => new PropertyModel(_.Key, _.Value)).ToList();
            properties.MustForArg(nameof(properties)).ContainElement("email");
            if (properties.Any(_ => _.Property == "vid"))
            {
                this.Vid = Convert.ToInt32(properties.Single(_ => _.Property == "vid").Value, CultureInfo.InvariantCulture);
                var filteredProperties = properties.Where(_ => _.Property != "vid").ToList();
                this.Properties = filteredProperties;
            }
            else
            {
                this.Email = properties.Single(_ => _.Property == "email").Value;
                var filteredProperties = properties.Where(_ => _.Property != "email").ToList();
                this.Properties = filteredProperties;
            }
        }

        /// <summary>
        /// Gets or sets the HubSpot ID of the contact.
        /// </summary>
        public int? Vid { get; set; }

        /// <summary>
        /// Gets or sets the email of the HubSpot contact.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///  Gets or sets the properties of the HubSpot contact.
        /// </summary>
        public IReadOnlyCollection<PropertyModel> Properties { get; set; }
    }
}
