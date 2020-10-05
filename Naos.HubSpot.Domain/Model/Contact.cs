// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// Object to describe a contact in HubSpot.
    /// </summary>
    public partial class Contact : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="properties">The properties.</param>
        public Contact(
            IReadOnlyDictionary<string, string> properties)
        {
            var notNullProps = properties.MustForArg(nameof(properties));
            notNullProps.NotBeNullNorEmptyDictionary();
            var containsFirstName = properties.Any(_ => _.Key == HubSpotContactPropertyNames.FirstName).MustForArg();
            containsFirstName.BeTrue(Invariant($"Must have a {nameof(HubSpotContactPropertyNames.FirstName)} property."));
            var cotnainsLastName = properties.Any(_ => _.Key == HubSpotContactPropertyNames.LastName && !string.IsNullOrEmpty(_.Value)).MustForArg();
            cotnainsLastName.BeTrue(Invariant($"Must have a {nameof(HubSpotContactPropertyNames.LastName)} property."));
            var containsEmail = properties.Any(_ => _.Key == HubSpotContactPropertyNames.EmailAddress && !string.IsNullOrWhiteSpace(_.Value)).MustForArg();
            containsEmail.BeTrue(Invariant($"Must have a {nameof(HubSpotContactPropertyNames.EmailAddress)} property."));

            this.Properties = properties;
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IReadOnlyDictionary<string, string> Properties { get; private set; }
    }
}
