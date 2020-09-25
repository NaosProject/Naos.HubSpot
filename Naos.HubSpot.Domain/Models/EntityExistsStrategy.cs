// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityExistsStrategy.cs" company="Naos Project">
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
    /// Strategy for what do when an unexpected entity is present.
    /// </summary>
    public enum EntityExistsStrategy
    {
        /// <summary>
        /// Throws an exception as the entity was not expected to exist.
        /// </summary>
        Throw,

        /// <summary>
        /// Overwrites the unexpected entity.
        /// </summary>
        Overwrite,
    }
}
