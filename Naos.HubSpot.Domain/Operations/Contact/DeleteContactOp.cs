// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteContactOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// The operation to get all contacts.
    /// </summary>
    public partial class DeleteContactOp : ReturningOperationBase<DeleteContactResponse>, IModelViaCodeGen
    {
        /// <summary>
        /// Gets the vid.
        /// </summary>
        /// <value>The vid.</value>
        public int Vid { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteContactOp"/> class.
        /// </summary>
        /// <param name="vid">The HubSpot ID of the contact to be deleted.</param>
        public DeleteContactOp(int vid)
        {
            vid.MustForArg(nameof(vid)).BeGreaterThan(0, "You must provide a HubSpot ID in order to delete a contact.");
            this.Vid = vid;
        }
    }
}
