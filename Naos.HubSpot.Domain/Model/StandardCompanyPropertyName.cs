// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardCompanyPropertyName.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.Enum.Recipes;

    /// <summary>
    /// Object to describe a company in HubSpot.
    /// </summary>
    public enum StandardCompanyPropertyName
    {
        /// <summary>
        /// The HubSpot ID of the company.
        /// </summary>
        ObjectId,

        /// <summary>
        /// The name of the company.
        /// </summary>
        CompanyName,

        /// <summary>
        /// The custom ID of the company.
        /// </summary>
        CustomId,

        /// <summary>
        /// The description
        /// </summary>
        Description,
    }
}
