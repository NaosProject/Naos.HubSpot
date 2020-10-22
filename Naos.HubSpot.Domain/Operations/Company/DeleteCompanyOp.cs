// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteCompanyOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Operation to add a company.
    /// </summary>
    public partial class DeleteCompanyOp : ReturningOperationBase<DeleteCompanyResponse>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCompanyOp"/> class.
        /// </summary>
        /// <param name="companyId">The ID of the company to be deleted.</param>
        public DeleteCompanyOp(long companyId)
        {
            this.CompanyId = companyId;
        }

        /// <summary>
        /// Gets the ID of the company to delete.
        /// </summary>
        /// <value>The companies to add.</value>
        public long CompanyId { get; private set; }
    }
}
