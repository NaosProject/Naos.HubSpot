// <copyright file="CreateContactV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class CreateContactV3Op.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class CreateContactV3Op : ReturningOperationBase<ContactAndCompanyModelV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactV3Op"/> class.
        /// </summary>
        /// <param name="contactToCreate">The contact and Contact to create.</param>
        public CreateContactV3Op(ContactAndCompanyModelV3 contactToCreate)
        {
            this.ContactToCreate = contactToCreate;
        }

        /// <summary>
        /// Gets the contact and Contact to create.
        /// </summary>
        /// <value>The contact and Contact to create.</value>
        public ContactAndCompanyModelV3 ContactToCreate { get; private set; }
    }
}
