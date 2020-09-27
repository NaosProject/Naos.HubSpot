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
        /// The first name key for the properties dictionary.
        /// </summary>
        public const string FirstNamePropertyKey = "firstname";

        /// <summary>
        /// The last name key for the properties dictionary.
        /// </summary>
        public const string LastNamePropertyKey = "lastname";

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="entityId">The entity identifier.</param>
        /// <param name="email">The email.</param>
        /// <param name="vid">The vid.</param>
        /// <param name="properties">The properties.</param>
        public Contact(
            string entityId,
            string email,
            string vid,
            IReadOnlyDictionary<string, object> properties)
        {
            entityId.MustForArg(nameof(entityId)).NotBeNullNorWhiteSpace();
            email.MustForArg(nameof(email)).NotBeNullNorWhiteSpace();
            vid.MustForArg(nameof(vid)).BeNullOrNotWhiteSpace();
            properties.MustForArg(nameof(properties)).NotBeNullNorEmptyDictionary();
            properties.ContainsKey(FirstNamePropertyKey).MustForArg().NotBeFalse(Invariant($"Must have a {FirstNamePropertyKey} property."));
            properties.ContainsKey(LastNamePropertyKey).MustForArg().NotBeFalse(Invariant($"Must have a {LastNamePropertyKey} property."));

            this.EntityId = entityId;
            this.Email = email;
            this.Vid = vid;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the custom entity identifier.
        /// </summary>
        /// <value>The custom entity identifier.</value>
        public string EntityId { get; private set; }

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
        public IReadOnlyDictionary<string, object> Properties { get; private set; }
    }
}
