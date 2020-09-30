// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssociateContactWithCompanyOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.HubSpot.Domain.Model;
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
        /// <param name="companyHubSpotId">The ID of the company with which the contact is to be associated.</param>
        public AssociateContactWithCompanyOp(int contactHubSpotId, int companyHubSpotId)
        {
            this.ContactHubSpotId = contactHubSpotId;
            this.CompanyHubSpotId = companyHubSpotId;
        }

        /// <summary>
        /// Gets the Contact to be associated.
        /// </summary>
        public int ContactHubSpotId { get; private set; }

        /// <summary>
        /// Gets the Company with which the contact should be associated.
        /// </summary>
        public int CompanyHubSpotId { get; private set; }

        /// <summary>
        /// Creates the payload of a HubSpot request representing the request to associate the client
        /// in this object to the company in this object.
        /// </summary>
        /// <returns cref="AssociateContactToCompanyRequest">The payload for a association API request.</returns>
        public AssociateContactToCompanyRequest CreateRequest()
        {
            return new AssociateContactToCompanyRequest(this.ContactHubSpotId, this.CompanyHubSpotId, "HUBSPOT_DEFINED", 1);
        }
    }
}