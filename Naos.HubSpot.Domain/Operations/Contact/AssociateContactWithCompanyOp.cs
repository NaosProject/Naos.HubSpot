// <copyright file="AssociateContactWithCompanyOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class AssociateContactWithCompanyOp.
    /// Implements the <see cref="ReturningOperationBase{AssociationResult}" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{AssociationResult}" />
    public partial class AssociateContactWithCompanyOp : ReturningOperationBase<AssociationResult>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociateContactWithCompanyOp"/> class.
        /// </summary>
        /// <param name="contactId">The contact identifier.</param>
        /// <param name="companyId">The company identifier.</param>
        public AssociateContactWithCompanyOp(string contactId, string companyId)
        {
            this.ContactId = contactId;
            this.CompanyId = companyId;
        }

        /// <summary>
        /// Gets the contact identifier.
        /// </summary>
        /// <value>The contact identifier.</value>
        public string ContactId { get; private set; }

        /// <summary>
        /// Gets the company identifier.
        /// </summary>
        /// <value>The company identifier.</value>
        public string CompanyId { get; private set; }
    }
}
