﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotContactPropertyNamesTest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using FakeItEasy;
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Math.Recipes;
    using Xunit;

    using static System.FormattableString;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = "Not a big deal in this situation.")]
    public static partial class HubSpotContactPropertyNamesTest
    {
        [Fact]
        public static void AllNames___Contains_all_constants()
        {
            var allConsts = typeof(HubSpotContactPropertyNames)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(_ => _.Name != nameof(HubSpotContactPropertyNames.AllNames))
                .Select(_ => _.GetRawConstantValue()?.ToString())
                .ToList();
            var symmetricDifferenceBetweenSelectedAndStatedNames = allConsts.SymmetricDifference(HubSpotContactPropertyNames.AllNames);
            symmetricDifferenceBetweenSelectedAndStatedNames.MustForTest().BeEmptyEnumerable();
        }
    }
}