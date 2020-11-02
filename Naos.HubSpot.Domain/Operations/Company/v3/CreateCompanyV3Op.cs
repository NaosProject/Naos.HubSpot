// <copyright file="CreateCompanyV3Op.cs" company="Naos Project">
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
    public partial class CreateCompanyV3Op : ReturningOperationBase<CompanyV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyV3Op"/> class.
        /// </summary>
        /// <param name="companyToCreate">The company to create.</param>
        public CreateCompanyV3Op(CompanyV3 companyToCreate)
        {
            this.CompanyToCreate = companyToCreate;
        }

        /// <summary>
        /// Gets the contact and company to create.
        /// </summary>
        /// <value>The contact and company to create.</value>
        public CompanyV3 CompanyToCreate { get; private set; }
    }
}
