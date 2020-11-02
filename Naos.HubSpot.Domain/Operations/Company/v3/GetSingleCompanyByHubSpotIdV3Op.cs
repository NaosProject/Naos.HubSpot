// <copyright file="GetSingleCompanyByHubSpotIdV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetSingleCompanyV3Op.
    /// Implements the <see cref="ReturningOperationBase{CompanyV3}" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{CompanyV3}" />
    public partial class GetSingleCompanyByHubSpotIdV3Op : ReturningOperationBase<CompanyV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSingleCompanyByHubSpotIdV3Op"/> class.
        /// </summary>
        /// <param name="hubSpotId">The hub spot identifier.</param>
        public GetSingleCompanyByHubSpotIdV3Op(string hubSpotId)
        {
            this.HubSpotId = hubSpotId;
        }

        /// <summary>
        /// Gets the company identifier.
        /// </summary>
        /// <value>The company identifier.</value>
        public string HubSpotId { get; private set; }
    }
}
