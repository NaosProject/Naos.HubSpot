// <copyright file="RemoveCompanyByHubSpotIdV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class RemoveCompanyByHubSpotIdV3Op.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class RemoveCompanyByHubSpotIdV3Op : ReturningOperationBase<CompanyV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveCompanyByHubSpotIdV3Op"/> class.
        /// </summary>
        /// <param name="hubSpotId">The hub spot identifier.</param>
        public RemoveCompanyByHubSpotIdV3Op(string hubSpotId)
        {
            this.HubSpotId = hubSpotId;
        }

        /// <summary>
        /// Gets the hub spot identifier.
        /// </summary>
        /// <value>The hub spot identifier.</value>
        public string HubSpotId { get; private set; }
    }
}
