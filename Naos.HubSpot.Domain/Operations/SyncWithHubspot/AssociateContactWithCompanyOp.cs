// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssociateContactWithCompanyOp.cs" company="Naos Project">
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
    /// The operation to get contacts by custom entity identifiers.
    /// </summary>
    public partial class AssociateContactWithCompanyOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociateContactWithCompanyOp"/> class.
        /// </summary>
        /// <param name="contactHubSpotId">The ID of the contact to be associated.</param>
        /// <param name="companyHubSpotId">The id of the company with which the contact is to be associated.</param>
        public AssociateContactWithCompanyOp(string contactHubSpotId, string companyHubSpotId)
        {
            this.ContactHubSpotId = contactHubSpotId;
            this.CompanyHubSpotId = companyHubSpotId;
        }

        /// <summary>
        /// Gets the Contact to be associated.
        /// </summary>
        public string ContactHubSpotId { get; private set; }

        /// <summary>
        /// Gets the Company with which the contact should be associated.
        /// </summary>
        public string CompanyHubSpotId { get; private set; }
    }
}
