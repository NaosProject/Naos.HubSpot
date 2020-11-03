// <copyright file="AssociationsAssociationsSection.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Class AssociationsAssociationsSection.
    /// </summary>
    public partial class AssociationsAssociationsSection : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationsAssociationsSection"/> class.
        /// </summary>
        /// <param name="contacts">The contacts.</param>
        public AssociationsAssociationsSection(AssociationContactsSection contacts = null)
        {
            this.Contacts = contacts;
        }

        /// <summary>
        /// Gets the contacts.
        /// </summary>
        /// <value>The contacts.</value>
        public AssociationContactsSection Contacts { get; private set; }
    }
}