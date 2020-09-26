// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetContactsByCustomEntityIdsOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// The operation to get contacts by custom entity identifiers.
    /// </summary>
    public partial class GetContactsByCustomEntityIdsOp : ReturningOperationBase<IReadOnlyCollection<Contact>>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactsByCustomEntityIdsOp"/> class.
        /// </summary>
        /// <param name="entityIds">The entity ids.</param>
        public GetContactsByCustomEntityIdsOp(
            IReadOnlyCollection<string> entityIds)
        {
            entityIds.MustForArg(nameof(entityIds)).NotBeNull();
            this.EntityIds = entityIds;
        }

        /// <summary>
        /// Gets the custom entity identifiers to filter with.
        /// </summary>
        /// <value>The custom entity identifiers to filter with.</value>
        public IReadOnlyCollection<string> EntityIds { get; private set; }
    }
}
