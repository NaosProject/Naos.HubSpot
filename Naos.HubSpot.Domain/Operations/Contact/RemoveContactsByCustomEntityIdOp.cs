// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RemoveContactsByCustomEntityIdOp.cs" company="Naos Project">
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
    /// The operation to remove contacts by custom entity identifiers.
    /// </summary>
    public partial class RemoveContactsByCustomEntityIdOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveContactsByCustomEntityIdOp"/> class.
        /// </summary>
        /// <param name="entityIdsToRemove">The custom entity identifiers to remove.</param>
        /// <param name="entityDoesNotExistStrategy">The entity does not exist strategy.</param>
        public RemoveContactsByCustomEntityIdOp(
            IReadOnlyCollection<string> entityIdsToRemove,
            EntityDoesNotExistStrategy entityDoesNotExistStrategy = EntityDoesNotExistStrategy.Throw)
        {
            entityIdsToRemove.MustForArg(nameof(entityIdsToRemove)).NotBeNull();
            this.EntityIdsToRemove = entityIdsToRemove;
            this.EntityDoesNotExistStrategy = entityDoesNotExistStrategy;
        }

        /// <summary>
        /// Gets the contacts to add.
        /// </summary>
        /// <value>The contacts to add.</value>
        public IReadOnlyCollection<string> EntityIdsToRemove { get; private set; }

        /// <summary>
        /// Gets the entity exists strategy.
        /// </summary>
        /// <value>The entity exists strategy.</value>
        public EntityDoesNotExistStrategy EntityDoesNotExistStrategy { get; private set; }
    }
}
