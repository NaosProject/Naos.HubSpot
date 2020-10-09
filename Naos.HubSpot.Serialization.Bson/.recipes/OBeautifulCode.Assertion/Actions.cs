﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Actions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Assertion.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Assertion.Recipes
{
    using global::System;
    using global::System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;

    /// <summary>
    /// The actions that have been performed in the lifecycle of an assertion.
    /// </summary>
    [Flags]
#if !OBeautifulCodeAssertionSolution
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Assertion.Recipes", "See package version number")]
    internal
#else
    public
#endif
    enum Actions
    {
        /// <summary>
        /// None (default).
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        None = 0,

        /// <summary>
        /// The subject should have been categorized with a call to:
        /// <see cref="WorkflowExtensions.AsArg{TSubject}(TSubject, string)"/> or
        /// <see cref="WorkflowExtensions.AsOp{TSubject}(TSubject, string)"/> or
        /// <see cref="WorkflowExtensions.AsTest{TSubject}(TSubject, string)"/>
        /// </summary>
        Categorized = 1,

        /// <summary>
        /// The subject should have been named with non-null value for the name parameter of:
        /// <see cref="WorkflowExtensions.AsArg{TSubject}(TSubject, string)"/> or
        /// <see cref="WorkflowExtensions.AsOp{TSubject}(TSubject, string)"/> or
        /// <see cref="WorkflowExtensions.AsTest{TSubject}(TSubject, string)"/>
        /// OR
        /// by calling <see cref="WorkflowExtensions.Must{TSubject}(TSubject)"/> on a single-property anonymous object.
        /// </summary>
        Named = 2,

        /// <summary>
        /// The subject should have been Must'ed with a call to
        /// <see cref="WorkflowExtensions.Must{TSubject}(TSubject)"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Musted", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        Musted = 4,

        /// <summary>
        /// The subject should have been Each'ed with a call to
        /// <see cref="WorkflowExtensions.Each(AssertionTracker)"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Eached", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        Eached = 8,

        /// <summary>
        /// The subject should have been verified by at least one verification.
        /// </summary>
        VerifiedAtLeastOnce = 16,
    }
}
