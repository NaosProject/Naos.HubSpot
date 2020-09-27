// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocolTest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client.Test
{
    using System;
    using Naos.HubSpot.Domain;
    using OBeautifulCode.Assertion.Recipes;

    using Xunit;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public static partial class HubSpotProtocolTest
    {
        [Fact(Skip = "Skipping because this uses external resources")]
        public static void GetAllContactsOp___Returns_nonempty_list_of_contacts___When_executed()
        {
            // Arrange
            var apiKey = "Get HubSpot Api Key from https://app.hubspot.com/api-key/";
            var baseUri = new Uri("https://api.hubapi.com/");
            var protocol = new HubSpotProtocol("entitiyId", baseUri, apiKey);
            var op = new GetAllContactsOp();
            
            // Act
            var contacts = protocol.Execute(op);

            // Assert
            contacts.MustForTest().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
        }
    }
}
