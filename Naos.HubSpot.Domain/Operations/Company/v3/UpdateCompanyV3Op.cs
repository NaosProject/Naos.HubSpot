// <copyright file="UpdateCompanyV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class UpdateCompanyV3Op.
    /// Implements the <see cref="CompanyV3" />.
    /// </summary>
    /// <seealso cref="CompanyV3" />
    public partial class UpdateCompanyV3Op : ReturningOperationBase<CompanyV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCompanyV3Op"/> class.
        /// </summary>
        /// <param name="companyToUpdate">The company to update.</param>
        public UpdateCompanyV3Op(CompanyV3 companyToUpdate)
        {
            this.CompanyToUpdate = companyToUpdate;
        }

        /// <summary>
        /// Gets the contact to update.
        /// </summary>
        /// <value>The contact to update.</value>
        public CompanyV3 CompanyToUpdate { get; private set; }
    }
}
