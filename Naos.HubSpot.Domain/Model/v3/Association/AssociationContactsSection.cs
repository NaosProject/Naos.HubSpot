// <copyright file="AssociationContactsSection.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Class AssociationContactsSection.
    /// </summary>
    public partial class AssociationContactsSection : IModelViaCodeGen
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
}