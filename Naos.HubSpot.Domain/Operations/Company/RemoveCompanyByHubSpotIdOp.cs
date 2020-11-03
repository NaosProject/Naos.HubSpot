// <copyright file="RemoveCompanyByHubSpotIdOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class RemoveCompanyByHubSpotIdOp.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class RemoveCompanyByHubSpotIdOp : ReturningOperationBase<Company>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveCompanyByHubSpotIdOp"/> class.
        /// </summary>
        /// <param name="hubSpotId">The hub spot identifier.</param>
        public RemoveCompanyByHubSpotIdOp(string hubSpotId)
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
