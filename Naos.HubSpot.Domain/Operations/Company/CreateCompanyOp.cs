// <copyright file="CreateCompanyOp.cs" company="Naos Project">
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
    public partial class CreateCompanyOp : ReturningOperationBase<Company>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyOp"/> class.
        /// </summary>
        /// <param name="companyToCreate">The company to create.</param>
        public CreateCompanyOp(Company companyToCreate)
        {
            this.CompanyToCreate = companyToCreate;
        }

        /// <summary>
        /// Gets the contact and company to create.
        /// </summary>
        /// <value>The contact and company to create.</value>
        public Company CompanyToCreate { get; private set; }
    }
}
