// <copyright file="UpdateCompanyV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class UpdateCompanyV3Op.
    /// Implements the <see cref="ContactAndCompanyModelV3" />.
    /// </summary>
    /// <seealso cref="ContactAndCompanyModelV3" />
    public partial class UpdateCompanyV3Op : ReturningOperationBase<ContactAndCompanyModelV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCompanyV3Op"/> class.
        /// </summary>
        /// <param name="companyToUpdate">The contact to update.</param>
        public UpdateCompanyV3Op(ContactAndCompanyModelV3 companyToUpdate)
        {
            this.CompanyToUpdate = companyToUpdate;
        }

        /// <summary>
        /// Gets the contact to update.
        /// </summary>
        /// <value>The contact to update.</value>
        public ContactAndCompanyModelV3 CompanyToUpdate { get; private set; }
    }
}
