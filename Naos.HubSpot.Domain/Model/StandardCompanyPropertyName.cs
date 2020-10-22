// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardCompanyPropertyName.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    /// <summary>
    /// Object to describe a company in HubSpot.
    /// </summary>
    public enum StandardCompanyPropertyName
    {
        /// <summary>
        /// The HubSpot ID of the company.
        /// </summary>
        HubSpotId,

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
