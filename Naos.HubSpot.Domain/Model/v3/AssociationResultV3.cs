// <copyright file="AssociationResultV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class AssociationResultV3.
    /// Implements the <see cref="IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="IModelViaCodeGen" />
    public class AssociationResultV3 : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationResultV3"/> class.
        /// </summary>
        /// <param name="createdAt">The created at.</param>
        /// <param name="archived">if set to <c>true</c> [archived].</param>
        /// <param name="id">The identifier.</param>
        /// <param name="properties">The properties.</param>
        /// <param name="updatedAt">The updated at.</param>
        /// <param name="associations">The associations.</param>
        public AssociationResultV3(string createdAt, bool archived, string id, IReadOnlyDictionary<string, string> properties, string updatedAt, AssociationsAssociationsSection associations)
        {
            this.CreatedAt = createdAt;
            this.Archived = archived;
            this.Id = id;
            this.Properties = properties;
            this.UpdatedAt = updatedAt;
            this.Associations = associations;
        }

        /// <summary>
        /// Gets the created at.
        /// </summary>
        /// <value>The created at.</value>
        public string CreatedAt { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="AssociationResultV3"/> is archived.
        /// </summary>
        /// <value><c>true</c> if archived; otherwise, <c>false</c>.</value>
        public bool Archived { get; private set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IReadOnlyDictionary<string, string> Properties { get; private set; }

        /// <summary>
        /// Gets the updated at.
        /// </summary>
        /// <value>The updated at.</value>
        public string UpdatedAt { get; private set; }

        /// <summary>
        /// Gets the associations.
        /// </summary>
        /// <value>The associations.</value>
        public AssociationsAssociationsSection Associations { get; private set; }
    }

    /// <summary>
    /// Class AssociationsAssociationsSection.
    /// </summary>
    public class AssociationsAssociationsSection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationsAssociationsSection"/> class.
        /// </summary>
        /// <param name="contacts">The contacts.</param>
        public AssociationsAssociationsSection(AssociationContactsSection contacts)
        {
            this.Contacts = contacts;
        }

        /// <summary>
        /// Gets the contacts.
        /// </summary>
        /// <value>The contacts.</value>
        public AssociationContactsSection Contacts { get; private set; }
    }

    /// <summary>
    /// Class AssociationContactsSection.
    /// </summary>
    public class AssociationContactsSection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationContactsSection"/> class.
        /// </summary>
        /// <param name="results">The results.</param>
        public AssociationContactsSection(AssociationResultsSection results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <value>The results.</value>
        public AssociationResultsSection Results { get; private set; }
    }

    /// <summary>
    /// Class AssociationResultsSection.
    /// </summary>
    public class AssociationResultsSection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationResultsSection"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="associationType">Type of the association.</param>
        public AssociationResultsSection(string id, string associationType)
        {
            this.Id = id;
            this.AssociationType = associationType;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the association.
        /// </summary>
        /// <value>The type of the association.</value>
        [JsonProperty("type")]
        public string AssociationType { get; private set; }
    }
}
