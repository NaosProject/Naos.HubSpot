// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddOrUpdateContactsOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Operation to add a contact.
    /// </summary>
    public partial class AddOrUpdateContactsOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateContactsOp"/> class.
        /// </summary>
        /// <param name="contactsToAddOrUpdate">The contacts to add.</param>
        public AddOrUpdateContactsOp(
            IReadOnlyCollection<Contact> contactsToAddOrUpdate)
        {
            contactsToAddOrUpdate.MustForArg(nameof(contactsToAddOrUpdate)).NotBeNull();
            this.ContactsToAddOrUpdate = contactsToAddOrUpdate;
        }

        /// <summary>
        /// Gets the contacts to add.
        /// </summary>
        /// <value>The contacts to add.</value>
        public IReadOnlyCollection<Contact> ContactsToAddOrUpdate { get; private set; }
    }
}
