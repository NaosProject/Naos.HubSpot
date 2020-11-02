// <copyright file="AssociationResultsSection.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Newtonsoft.Json;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class AssociationResultsSection.
    /// </summary>
    public partial class AssociationResultsSection : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationResultsSection"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="type">Type of the association.</param>
        public AssociationResultsSection(string id, string type)
        {
            this.Id = id;
            this.Type = type;
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
        public string Type { get; private set; }
    }
}