// <copyright file="GetSingleContactByHubSpotIdOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetSingleContactByHubSpotIdOp.
    /// Implements the <see cref="CompanyModel" />.
    /// </summary>
    /// <seealso cref="CompanyModel" />
    public partial class GetSingleContactByHubSpotIdOp : ReturningOperationBase<Contact>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSingleContactByHubSpotIdOp"/> class.
        /// </summary>
        /// <param name="hubSpotId">The hub spot identifier.</param>
        public GetSingleContactByHubSpotIdOp(string hubSpotId)
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
