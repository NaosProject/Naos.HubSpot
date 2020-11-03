// <copyright file="UpdateCompanyOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class UpdateCompanyOp.
    /// Implements the <see cref="Company" />.
    /// </summary>
    /// <seealso cref="Company" />
    public partial class UpdateCompanyOp : ReturningOperationBase<Company>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCompanyOp"/> class.
        /// </summary>
        /// <param name="companyToUpdate">The company to update.</param>
        public UpdateCompanyOp(Company companyToUpdate)
        {
            this.CompanyToUpdate = companyToUpdate;
        }

        /// <summary>
        /// Gets the contact to update.
        /// </summary>
        /// <value>The contact to update.</value>
        public Company CompanyToUpdate { get; private set; }
    }
}
