// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
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
            properties.MustForArg(nameof(properties)).NotBeNullNorEmptyDictionary();
            properties.ContainsKey(nameof(StandardContactPropertyName.FirstName)).MustForArg().NotBeFalse(Invariant($"Must have a {nameof(StandardContactPropertyName.FirstName)} property."));
            properties.ContainsKey(nameof(StandardContactPropertyName.LastName)).MustForArg().NotBeFalse(Invariant($"Must have a {nameof(StandardContactPropertyName.LastName)} property."));
            properties.ContainsKey(nameof(StandardContactPropertyName.EmailAddress)).MustForArg().NotBeFalse(Invariant($"Must have a {nameof(StandardContactPropertyName.EmailAddress)} property."));

            this.Properties = properties;
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IReadOnlyDictionary<string, string> Properties { get; private set; }
    }
}
