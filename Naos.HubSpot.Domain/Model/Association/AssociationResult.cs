// <copyright file="AssociationResult.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class AssociationResult.
    /// Implements the <see cref="IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="IModelViaCodeGen" />
    public partial class AssociationResult : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationResult"/> class.
        /// </summary>
        /// <param name="createdAt">The created at.</param>
        /// <param name="archived">if set to <c>true</c> [archived].</param>
        /// <param name="id">The identifier.</param>
        /// <param name="properties">The properties.</param>
        /// <param name="updatedAt">The updated at.</param>
        /// <param name="associations">The associations.</param>
        public AssociationResult(string createdAt, bool archived, string id, IReadOnlyDictionary<string, string> properties, string updatedAt, AssociationsAssociationsSection associations)
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
        /// Gets a value indicating whether this <see cref="AssociationResult"/> is archived.
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
}
