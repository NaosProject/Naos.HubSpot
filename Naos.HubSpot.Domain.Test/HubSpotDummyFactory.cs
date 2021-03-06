﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotDummyFactory.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package Naos.Build.Conventions.VisualStudioProjectTemplates.Domain.Test (1.55.30)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;

    /// <summary>
    /// A Dummy Factory for types in <see cref="Naos.HubSpot.Domain"/>.
    /// </summary>
#if !NaosHubSpotRecipesProject
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("Naos.HubSpot.Domain.Test", "See package version number")]
#endif
    public class HubSpotDummyFactory : DefaultHubSpotDummyFactory
    {
        public HubSpotDummyFactory()
        {
            /* Add any overriding or custom registrations here. */
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var readOnlyDictionary = A.Dummy<Dictionary<string, string>>();
                    readOnlyDictionary.Add(Contact.FirstNamePropertyKey, A.Dummy<string>());
                    readOnlyDictionary.Add(Contact.LastNamePropertyKey, A.Dummy<string>());
                    return new Contact(
                        A.Dummy<string>(),
                        A.Dummy<string>(),
                        readOnlyDictionary);
                });
        }
    }
}
