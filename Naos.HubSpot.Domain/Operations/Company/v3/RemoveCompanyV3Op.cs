// <copyright file="RemoveCompanyV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class RemoveCompanyV3Op.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class RemoveCompanyV3Op : ReturningOperationBase<ContactAndCompanyModelV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveCompanyV3Op"/> class.
        /// </summary>
        /// <param name="companyIdToRemove">The company to remove.</param>
        public RemoveCompanyV3Op(string companyIdToRemove)
        {
            this.CompanyIdToRemove = companyIdToRemove;
        }

        /// <summary>
        /// Gets the company to remove.
        /// </summary>
        /// <value>The company to remove.</value>
        public string CompanyIdToRemove { get; private set; }
    }
}
