// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetCompaniesByCustomEntityIdsOp.cs" company="Naos Project">
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
    /// The operation to get companies by custom entity identifiers.
    /// </summary>
    public partial class GetCompaniesByCustomEntityIdsOp : ReturningOperationBase<IReadOnlyCollection<Company>>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCompaniesByCustomEntityIdsOp"/> class.
        /// </summary>
        /// <param name="entityIds">The entity ids.</param>
        public GetCompaniesByCustomEntityIdsOp(
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
