// <copyright file="GetSingleContactByHubSpotIdV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetSingleContactByHubSpotIdV3Op.
    /// Implements the <see cref="CompanyModelV3" />.
    /// </summary>
    /// <seealso cref="CompanyModelV3" />
    public partial class GetSingleContactByHubSpotIdV3Op : ReturningOperationBase<ContactV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSingleContactByHubSpotIdV3Op"/> class.
        /// </summary>
        /// <param name="hubSpotId">The hub spot identifier.</param>
        public GetSingleContactByHubSpotIdV3Op(string hubSpotId)
        {
            this.HubSpotId = hubSpotId;
        }

        /// <summary>
        /// Gets the contact identifier.
        /// </summary>
        /// <value>The contact identifier.</value>
        public string HubSpotId { get; private set; }
    }
}
