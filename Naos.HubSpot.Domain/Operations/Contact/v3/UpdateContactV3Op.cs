// <copyright file="UpdateContactV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class UpdateContactV3Op.
    /// Implements the <see cref="ContactAndCompanyModelV3" />.
    /// </summary>
    /// <seealso cref="ContactAndCompanyModelV3" />
    public partial class UpdateContactV3Op : ReturningOperationBase<ContactAndCompanyModelV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactV3Op"/> class.
        /// </summary>
        /// <param name="contactToUpdate">The contact to update.</param>
        public UpdateContactV3Op(ContactAndCompanyModelV3 contactToUpdate)
        {
            this.ContactToUpdate = contactToUpdate;
        }

        /// <summary>
        /// Gets the contact to update.
        /// </summary>
        /// <value>The contact to update.</value>
        public ContactAndCompanyModelV3 ContactToUpdate { get; private set; }
    }
}
