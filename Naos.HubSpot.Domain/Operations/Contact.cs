// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain.Model
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
        /// The first name key for the properties dictionary.
        /// </summary>
        public const string FirstNamePropertyKey = "firstName";

        /// <summary>
        /// The last name key for the properties dictionary.
        /// </summary>
        public const string LastNamePropertyKey = "lastName";

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="vid">The vid.</param>
        /// <param name="properties">The properties.</param>
        public Contact(
            string                              email,
            string                              vid,
            IReadOnlyDictionary<string, string> properties)
        {
            email.MustForArg(nameof(email)).NotBeNullNorWhiteSpace();
            vid.MustForArg(nameof(vid)).BeNullOrNotWhiteSpace();
            properties.MustForArg(nameof(properties)).NotBeNullNorEmptyDictionary();
            properties.ContainsKey(FirstNamePropertyKey).MustForArg().NotBeFalse(Invariant($"Must have a {FirstNamePropertyKey} property."));
            properties.ContainsKey(LastNamePropertyKey).MustForArg().NotBeFalse(Invariant($"Must have a {LastNamePropertyKey} property."));

            this.Email = email;
            this.Vid = vid;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; private set; }

        /// <summary>
        /// Gets the vid.
        /// </summary>
        /// <value>The vid.</value>
        public string Vid { get; private set; }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IReadOnlyDictionary<string, string> Properties { get; private set; }
    }
}
