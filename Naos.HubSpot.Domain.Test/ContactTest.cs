// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactTest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FakeItEasy;
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Math.Recipes;
    using Xunit;

    using static System.FormattableString;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = "Not a big deal in this situation.")]
    public static partial class ContactTest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = NaosSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = "Not a big deal in this situation.")]
        static ContactTest()
        {
            /*
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios();
            ConstructorArgumentValidationTestScenarios
               .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Contact>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'email' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Contact>();

                        var result = new Contact(
                                             referenceObject.EntityId,
                                             null,
                                             referenceObject.Vid,
                                             referenceObject.Properties);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "email" },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Contact>
                {
                    Name = "constructor should throw ArgumentException when parameter 'email' is white space scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Contact>();

                        var result = new Contact(
                                             referenceObject.EntityId,
                                             Invariant($"  {Environment.NewLine}  "),
                                             referenceObject.Vid,
                                             referenceObject.Properties);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "email", "white space" },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Contact>
                {
                    Name = "constructor should throw ArgumentException when parameter 'vid' is white space scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Contact>();

                        var result = new Contact(
                                             referenceObject.EntityId,
                                             referenceObject.Email,
                                             Invariant($"  {Environment.NewLine}  "),
                                             referenceObject.Properties);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "vid", "white space" },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Contact>
                {
                    Name = "constructor should throw ArgumentNullException when parameter 'properties' is null scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Contact>();

                        var result = new Contact(
                                             referenceObject.EntityId,
                                             referenceObject.Email,
                                             referenceObject.Vid,
                                             null);

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentNullException),
                    ExpectedExceptionMessageContains = new[] { "properties" },
                })
            .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Contact>
                {
                    Name = "constructor should throw ArgumentException when parameter 'properties' is an empty dictionary scenario",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Contact>();

                        var result = new Contact(
                                             referenceObject.EntityId,
                                             referenceObject.Email,
                                             referenceObject.Vid,
                                             new Dictionary<string, object>());

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "properties", "is an empty dictionary" },
                })
           .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Contact>
                {
                    Name = "constructor should throw ArgumentException when parameter 'properties' does not have first name key",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Contact>();

                        var result = new Contact(
                            referenceObject.EntityId,
                            referenceObject.Email,
                            referenceObject.Vid,
                            new Dictionary<string, object>
                            {
                                { Contact.LastNamePropertyKey, A.Dummy<string>() },
                            });

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "Must have a firstName property.  Provided value is false." },
                })
           .AddScenario(() =>
                new ConstructorArgumentValidationTestScenario<Contact>
                {
                    Name = "constructor should throw ArgumentException when parameter 'properties' does not have last name key",
                    ConstructionFunc = () =>
                    {
                        var referenceObject = A.Dummy<Contact>();

                        var result = new Contact(
                                             referenceObject.EntityId,
                                             referenceObject.Email,
                                             referenceObject.Vid,
                                             new Dictionary<string, object>
                                             {
                                                 { Contact.FirstNamePropertyKey, A.Dummy<string>() },
                                             });

                        return result;
                    },
                    ExpectedExceptionType = typeof(ArgumentException),
                    ExpectedExceptionMessageContains = new[] { "Must have a lastName property.  Provided value is false." },
                }); */
        } 
    }
}