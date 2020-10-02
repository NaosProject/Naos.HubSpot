﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddCompanyOp.cs" company="Naos Project">
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
    public partial class AddCompanyOp : ReturningOperationBase<Company>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCompanyOp"/> class.
        /// </summary>
        /// <param name="companyToAdd">The companies to add.</param>
        public AddCompanyOp(Company companyToAdd)
        {
            companyToAdd.MustForArg(nameof(companyToAdd)).NotBeNull();
            this.CompanyToAdd = companyToAdd;
        }

        /// <summary>
        /// Gets the companies to add.
        /// </summary>
        /// <value>The companies to add.</value>
        public Company CompanyToAdd { get; private set; }
    }
}