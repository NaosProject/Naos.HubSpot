// <copyright file="GetSingleCompanyByHubSpotIdOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetSingleCompanyV3Op.
    /// Implements the <see cref="ReturningOperationBase{Company}" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{Company}" />
    public partial class GetSingleCompanyByHubSpotIdOp : ReturningOperationBase<Company>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSingleCompanyByHubSpotIdOp"/> class.
        /// </summary>
        /// <param name="hubSpotId">The hub spot identifier.</param>
        public GetSingleCompanyByHubSpotIdOp(string hubSpotId)
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
