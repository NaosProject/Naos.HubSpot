﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssertionTrackerShould.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Assertion.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Assertion.Recipes
{
    using global::System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Specifies what should or should not be true about an <see cref="AssertionTracker"/>.
    /// </summary>
#if !OBeautifulCodeAssertionSolution
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Assertion.Recipes", "See package version number")]
    internal
#else
    public
#endif
    enum AssertionTrackerShould
    {
        /// <summary>
        /// Unknown (default).
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        Unknown,

        /// <summary>
        /// The tracker should exist.
        /// </summary>
        Exist,

        /// <summary>
        /// The tracker should not exist.
        /// </summary>
        NotExist,

        /// <summary>
        /// The tracker should be <see cref="Actions.Categorized"/>.
        /// </summary>
        BeCategorized,

        /// <summary>
        /// The tracker should not be <see cref="Actions.Categorized"/>.
        /// </summary>
        NotBeCategorized,

        /// <summary>
        /// The tracker should be <see cref="Actions.Named"/>.
        /// </summary>
        BeNamed,

        /// <summary>
        /// The tracker should not be <see cref="Actions.Named"/>.
        /// </summary>
        NotBeNamed,

        /// <summary>
        /// The tracker should be <see cref="Actions.Musted"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Musted", Justification = "This is the best wording for this identifier.")]
        BeMusted,

        /// <summary>
        /// The tracker should not be <see cref="Actions.Musted"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Musted", Justification = "This is the best wording for this identifier.")]
        NotBeMusted,

        /// <summary>
        /// The tracker should be <see cref="Actions.Eached"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Eached", Justification = "This is the best wording for this identifier.")]
        BeEached,

        /// <summary>
        /// The tracker should not be <see cref="Actions.Eached"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Eached", Justification = "This is the best wording for this identifier.")]
        NotBeEached,

        /// <summary>
        /// The tracker should be <see cref="Actions.VerifiedAtLeastOnce"/>.
        /// </summary>
        BeVerifiedAtLeastOnce,

        /// <summary>
        /// The tracker should not be <see cref="Actions.VerifiedAtLeastOnce"/>.
        /// </summary>
        NotBeVerified,
    }
}
