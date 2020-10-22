// <copyright file="DeleteCompanyResponse.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    /// <summary>
    /// The response of a delete company request.
    /// </summary>
    public class DeleteCompanyResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCompanyResponse"/> class.
        /// </summary>
        /// <param name="companyId">The ID of a the company for which the delete request was sent.</param>
        /// <param name="deleted">Whether or not the company was deleted.</param>
        public DeleteCompanyResponse(long companyId, bool deleted)
        {
            this.CompanyId = companyId;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Gets the company identifier.
        /// </summary>
        /// <value>The company identifier.</value>
        public long CompanyId { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="DeleteCompanyResponse"/> is deleted.
        /// </summary>
        /// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
        public bool Deleted { get; private set; }
    }
}
