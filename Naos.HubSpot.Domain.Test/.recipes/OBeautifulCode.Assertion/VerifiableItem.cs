﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VerifiableItem.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Assertion.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Assertion.Recipes
{
    using global::System;

    /// <summary>
    /// Specifies a item that is verifiable.  The verification is directly applied to this item.
    /// This is not always the subject.  If the assertion includes a call to <see cref="WorkflowExtensions.Each(AssertionTracker)"/>
    /// then the <see cref="Verification"/>s after that call are applied to the elements of the enumerable.
    /// Those elements are the verifiable items.
    /// </summary>
#if !OBeautifulCodeAssertionSolution
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Assertion.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class VerifiableItem
    {
        /// <summary>
        /// Gets or sets the value of the verifiable item.
        /// </summary>
        public object ItemValue { get; set; }

        /// <summary>
        /// Gets or sets the type of the verifiable item.
        /// </summary>
        public Type ItemType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this verifiable item is an element in an enumerable.
        /// </summary>
        public bool ItemIsElementInEnumerable { get; set; }
    }
}
