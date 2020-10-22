// <copyright file="ContactAndCompanyModelV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class ContactAndCompanyModelV3.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class ContactAndCompanyModelV3 : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactAndCompanyModelV3"/> class.
        /// </summary>
        /// <param name="createdAd">The created ad.</param>
        /// <param name="updatedAt">The updated at.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="properties">The properties.</param>
        /// <param name="archived">if set to <c>true</c> [archived].</param>
        public ContactAndCompanyModelV3(string createdAd, string updatedAt, string id, IReadOnlyDictionary<string, string> properties, bool archived = false)
        {
            this.CreatedAd = createdAd;
            this.UpdatedAt = updatedAt;
            this.Archived = archived;
            this.Id = id;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the created ad.
        /// </summary>
        /// <value>The created ad.</value>
        public string CreatedAd { get; private set; }

        /// <summary>
        /// Gets the updated at.
        /// </summary>
        /// <value>The updated at.</value>
        public string UpdatedAt { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ContactAndCompanyModelV3"/> is archived.
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
    }
}
