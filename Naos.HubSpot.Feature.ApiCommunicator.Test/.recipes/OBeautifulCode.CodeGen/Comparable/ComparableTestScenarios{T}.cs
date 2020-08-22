﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComparableTestScenarios{T}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.CodeGen.ModelObject.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Recipes
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Specifies various scenarios for comparability tests.
    /// </summary>
    /// <typeparam name="T">The type of the object being tested.</typeparam>
#if !OBeautifulCodeCodeGenRecipesProject
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.CodeGen.ModelObject.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class ComparableTestScenarios<T>
        where T : class
    {
        private readonly object lockScenarios = new object();

        private readonly List<Lazy<ComparableTestScenario<T>>> scenarios = new List<Lazy<ComparableTestScenario<T>>>();

        /// <summary>
        /// Adds the specified scenario to the list of scenarios.
        /// </summary>
        /// <param name="scenario">The scenario to add.</param>
        /// <returns>
        /// This object.
        /// </returns>
        public ComparableTestScenarios<T> AddScenario(
            ComparableTestScenario<T> scenario)
        {
            new { scenario }.AsTest().Must().NotBeNull();

            this.AddScenario(() => scenario);

            return this;
        }

        /// <summary>
        /// Adds the specified scenario to the list of scenarios.
        /// </summary>
        /// <param name="scenarioFunc">A func that returns the scenario to add.</param>
        /// <returns>
        /// This object.
        /// </returns>
        public ComparableTestScenarios<T> AddScenario(
            Func<ComparableTestScenario<T>> scenarioFunc)
        {
            new { scenarioFunc }.AsTest().Must().NotBeNull();

            lock (this.lockScenarios)
            {
                var lazyScenario = new Lazy<ComparableTestScenario<T>>(scenarioFunc);

                this.scenarios.Add(lazyScenario);
            }

            return this;
        }

        /// <summary>
        /// Adds the specified scenarios to the list of scenarios.
        /// </summary>
        /// <param name="comparableTestScenarios">The scenarios to add.</param>
        /// <returns>
        /// This object.
        /// </returns>
        public ComparableTestScenarios<T> AddScenarios(
            ComparableTestScenarios<T> comparableTestScenarios)
        {
            new { comparableTestScenarios }.AsTest().Must().NotBeNull();

            lock (this.lockScenarios)
            {
                this.scenarios.AddRange(comparableTestScenarios.scenarios);
            }

            return this;
        }

        /// <summary>
        /// Removes all scenarios.
        /// </summary>
        /// <returns>
        /// This object.
        /// </returns>
        public ComparableTestScenarios<T> RemoveAllScenarios()
        {
            lock (this.lockScenarios)
            {
                this.scenarios.Clear();
            }

            return this;
        }

        /// <summary>
        /// Validates the scenarios and prepares them for testing.
        /// </summary>
        /// <returns>
        /// The validated/prepared scenarios.
        /// </returns>
        public IReadOnlyList<ValidatedComparableTestScenario<T>> ValidateAndPrepareForTesting()
        {
            lock (this.lockScenarios)
            {
                var typeCompilableString = typeof(T).ToStringCompilable();

                var becauseNoScenarios = new[]
                {
                    Invariant($"Use a static constructor on your test class to add scenarios by calling {nameof(ComparableTestScenarios<object>)}.{nameof(ComparableTestScenarios<object>.AddScenario)}(...)."),
                    Invariant($"If you need to force the consuming unit tests to pass and you'll write your own unit tests, clear all scenarios by calling {nameof(ComparableTestScenarios<object>)}.{nameof(ComparableTestScenarios<object>.RemoveAllScenarios)}() and then add {nameof(ComparableTestScenario<object>)}<{typeCompilableString}>.{nameof(ComparableTestScenario<object>.ForceGeneratedTestsToPassAndWriteMyOwnScenario)}."),
                };

                this.scenarios.AsTest(Invariant($"{nameof(ComparableTestScenarios<object>)}.{nameof(ComparableTestScenarios<object>.scenarios)}")).Must().NotBeEmptyEnumerable(because: string.Join(Environment.NewLine, becauseNoScenarios), applyBecause: ApplyBecause.SuffixedToDefaultMessage);

                var result = new List<ValidatedComparableTestScenario<T>>();

                var scenariosCount = this.scenarios.Count;

                for (var x = 0; x < scenariosCount; x++)
                {
                    var scenario = this.scenarios[x].Value;

                    var scenarioNumber = x + 1;

                    var scenarioName = string.IsNullOrWhiteSpace(scenario.Name) ? "<Unnamed Scenario>" : scenario.Name;

                    var scenarioId = Invariant($"{scenarioName} ({nameof(ComparableTestScenario<object>)} #{scenarioNumber} of {scenariosCount}):");

                    var validatedScenario = new ValidatedComparableTestScenario<T>(
                        scenarioId,
                        scenario.ReferenceObject,
                        scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject ?? new List<T>(),
                        scenario.ObjectsThatAreLessThanReferenceObject ?? new List<T>(),
                        scenario.ObjectsThatAreGreaterThanReferenceObject ?? new List<T>(),
                        scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject ?? new List<T>(),
                        scenario.ObjectsThatAreNotOfTheSameTypeAsReferenceObject ?? new List<object>());

                    result.Add(validatedScenario);
                }

                return result;
            }
        }
    }
}
