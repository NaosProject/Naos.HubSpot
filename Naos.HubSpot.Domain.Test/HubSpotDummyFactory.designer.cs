﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.75.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;

    using global::FakeItEasy;

    using global::OBeautifulCode.AutoFakeItEasy;

    /// <summary>
    /// The default (code generated) Dummy Factory.
    /// Derive from this class to add any overriding or custom registrations.
    /// </summary>
    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.75.0")]
    public abstract class DefaultHubSpotDummyFactory : IDummyFactory
    {
        public DefaultHubSpotDummyFactory()
        {
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Contact(
                    A.Dummy<IReadOnlyDictionary<string, string>>()));
        }

        /// <inheritdoc />
        public Priority Priority => new FakeItEasy.Priority(1);

        /// <inheritdoc />
        public bool CanCreate(Type type)
        {
            return false;
        }

        /// <inheritdoc />
        public object Create(Type type)
        {
            return null;
        }
    }
}