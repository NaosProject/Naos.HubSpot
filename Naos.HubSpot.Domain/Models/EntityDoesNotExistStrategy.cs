// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityDoesNotExistStrategy.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// Strategy for what do when an expected entity is missing.
    /// </summary>
    public enum EntityDoesNotExistStrategy
    {
        /// <summary>
        /// Throws an exception as the entity was expected to exist.
        /// </summary>
        Throw,

        /// <summary>
        /// Ignores the a missing expected entity.
        /// </summary>
        Ignore,
    }
}
