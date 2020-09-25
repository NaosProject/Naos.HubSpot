// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddCompaniesOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// Operation to add a company.
    /// </summary>
    public partial class AddCompaniesOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCompaniesOp"/> class.
        /// </summary>
        /// <param name="companiesToAdd">The companies to add.</param>
        /// <param name="entityExistsStrategy">The entity exists strategy.</param>
        public AddCompaniesOp(
            IReadOnlyCollection<Company> companiesToAdd,
            EntityExistsStrategy entityExistsStrategy = EntityExistsStrategy.Throw)
        {
            companiesToAdd.MustForArg(nameof(companiesToAdd)).NotBeNull();
            this.CompaniesToAdd = companiesToAdd;
            this.EntityExistsStrategy = entityExistsStrategy;
        }

        /// <summary>
        /// Gets the companies to add.
        /// </summary>
        /// <value>The companies to add.</value>
        public IReadOnlyCollection<Company> CompaniesToAdd { get; private set; }

        /// <summary>
        /// Gets the entity exists strategy.
        /// </summary>
        /// <value>The entity exists strategy.</value>
        public EntityExistsStrategy EntityExistsStrategy { get; private set; }
    }
}
