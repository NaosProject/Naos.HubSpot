// <copyright file="UpdateContactOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class UpdateContactOp.
    /// Implements the <see cref="ContactModel" />.
    /// </summary>
    /// <seealso cref="ContactModel" />
    public partial class UpdateContactOp : ReturningOperationBase<Contact>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactOp"/> class.
        /// </summary>
        /// <param name="contactToUpdate">The contact to update.</param>
        public UpdateContactOp(Contact contactToUpdate)
        {
            this.ContactToUpdate = contactToUpdate;
        }

        /// <summary>
        /// Gets the contact to update.
        /// </summary>
        /// <value>The contact to update.</value>
        public Contact ContactToUpdate { get; private set; }
    }
}
