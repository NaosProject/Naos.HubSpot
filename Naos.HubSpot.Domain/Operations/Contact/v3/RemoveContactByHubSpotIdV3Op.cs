// <copyright file="RemoveContactByHubSpotIdV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class RemoveContactByHubSpotIdV3Op.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class RemoveContactByHubSpotIdV3Op : ReturningOperationBase<ContactV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveContactByHubSpotIdV3Op"/> class.
        /// </summary>
        /// <param name="hubSpotId">The hub spot identifier.</param>
        public RemoveContactByHubSpotIdV3Op(string hubSpotId)
        {
            this.HubSpotId = hubSpotId;
        }

        /// <summary>
        /// Gets the Contact to remove.
        /// </summary>
        /// <value>The Contact to remove.</value>
        public string HubSpotId { get; private set; }
    }
}
