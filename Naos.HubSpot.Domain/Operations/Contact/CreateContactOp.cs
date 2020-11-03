// <copyright file="CreateContactOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class CreateContactOp.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class CreateContactOp : ReturningOperationBase<Contact>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactOp"/> class.
        /// </summary>
        /// <param name="contactToCreate">The contact to create.</param>
        public CreateContactOp(Contact contactToCreate)
        {
            this.ContactToCreate = contactToCreate;
        }

        /// <summary>
        /// Gets the contact and Contact to create.
        /// </summary>
        /// <value>The contact and Contact to create.</value>
        public Contact ContactToCreate { get; private set; }
    }
}
