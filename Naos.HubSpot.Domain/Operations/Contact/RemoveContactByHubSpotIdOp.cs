// <copyright file="RemoveContactByHubSpotIdOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class RemoveContactByHubSpotIdOp.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class RemoveContactByHubSpotIdOp : ReturningOperationBase<Contact>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveContactByHubSpotIdOp"/> class.
        /// </summary>
        /// <param name="hubSpotId">The hub spot identifier.</param>
        public RemoveContactByHubSpotIdOp(string hubSpotId)
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
