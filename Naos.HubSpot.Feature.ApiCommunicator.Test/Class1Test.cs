// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1Test.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Feature.ApiCommunicator.Test
{
    using System;
    using System.Collections.Generic;
    using Naos.HubSpot.Domain;
    using OBeautifulCode.Assertion.Recipes;

    using Xunit;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public static partial class Class1Test
    {
        [Fact]
        public static void Method___Should_do_something___When_called()
        {
            // Arrange
            var contacts = new List<Contact>(); // this is where you would get the contacts from the DB
            var protocol = new HubspotProtocol();
            var operation = new SyncContactsWithHubspotOp(contacts); // <- contact goes here.
            var result = protocol.Execute(operation);

            // Act

            // Assert
        }
    }
}
