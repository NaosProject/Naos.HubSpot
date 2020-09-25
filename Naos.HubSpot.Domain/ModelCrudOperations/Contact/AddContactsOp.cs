// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddContactsOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// Operation to add a contact.
    /// </summary>
    public partial class AddContactsOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddContactsOp"/> class.
        /// </summary>
        /// <param name="contactsToAdd">The contacts to add.</param>
        /// <param name="entityExistsStrategy">The entity exists strategy.</param>
        public AddContactsOp(
            IReadOnlyCollection<Contact> contactsToAdd,
            EntityExistsStrategy entityExistsStrategy = EntityExistsStrategy.Throw)
        {
            contactsToAdd.MustForArg(nameof(contactsToAdd)).NotBeNull();
            this.ContactsToAdd = contactsToAdd;
            this.EntityExistsStrategy = entityExistsStrategy;
        }

        /// <summary>
        /// Gets the contacts to add.
        /// </summary>
        /// <value>The contacts to add.</value>
        public IReadOnlyCollection<Contact> ContactsToAdd { get; private set; }

        /// <summary>
        /// Gets the entity exists strategy.
        /// </summary>
        /// <value>The entity exists strategy.</value>
        public EntityExistsStrategy EntityExistsStrategy { get; private set; }
    }
}
