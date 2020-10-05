// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateCompaniesOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Operation to add a company.
    /// </summary>
    public partial class UpdateCompaniesOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCompaniesOp"/> class.
        /// </summary>
        /// <param name="companiesToUpdate">The companies to add.</param>
        public UpdateCompaniesOp(IReadOnlyCollection<Company> companiesToUpdate)
        {
            companiesToUpdate.MustForArg(nameof(companiesToUpdate)).NotBeNull();
            companiesToUpdate.MustForArg(nameof(companiesToUpdate)).NotBeEmptyEnumerable();
            this.CompaniesToUpdate = companiesToUpdate;
        }

        /// <summary>
        /// Gets the companies to add.
        /// </summary>
        /// <value>The companies to add.</value>
        public IReadOnlyCollection<Company> CompaniesToUpdate { get; private set; }
    }
}
