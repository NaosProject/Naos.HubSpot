// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RemoveCompaniesByCustomEntityIdOp.cs" company="Naos Project">
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
    /// The operation to remove companies by custom entity identifiers.
    /// </summary>
    public partial class RemoveCompaniesByCustomEntityIdOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveCompaniesByCustomEntityIdOp"/> class.
        /// </summary>
        /// <param name="entityIdsToRemove">The custom entity identifiers to remove.</param>
        /// <param name="entityDoesNotExistStrategy">The entity does not exist strategy.</param>
        public RemoveCompaniesByCustomEntityIdOp(
            IReadOnlyCollection<string> entityIdsToRemove,
            EntityDoesNotExistStrategy entityDoesNotExistStrategy = EntityDoesNotExistStrategy.Throw)
        {
            entityIdsToRemove.MustForArg(nameof(entityIdsToRemove)).NotBeNull();
            this.EntityIdsToRemove = entityIdsToRemove;
            this.EntityDoesNotExistStrategy = entityDoesNotExistStrategy;
        }

        /// <summary>
        /// Gets the companies to add.
        /// </summary>
        /// <value>The companies to add.</value>
        public IReadOnlyCollection<string> EntityIdsToRemove { get; private set; }

        /// <summary>
        /// Gets the entity exists strategy.
        /// </summary>
        /// <value>The entity exists strategy.</value>
        public EntityDoesNotExistStrategy EntityDoesNotExistStrategy { get; private set; }
    }
}
