// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocolTestV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client.Test
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Naos.HubSpot.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using Xunit;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public static partial class HubSpotProtocolTest
    {
        [Fact]
        public static void GetAllContactsOpV3___Returns_nonempty_list_of_contacts___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var op = new GetAllContactsV3Op();
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyName.Email.ToString(), "addcontacttest@testemail.com" },
                { StandardContactPropertyName.FirstName.ToString(), "testContactFirst" },
                { StandardContactPropertyName.LastName.ToString(), "testcontactLast" },
            };
            var contactToCreate = new ContactAndCompanyModelV3(null, null, null, contactToAddProps);
            var createContactOp = new CreateContactV3Op(contactToCreate);
            var createdContact = protocol.Execute(createContactOp);
            
            // Act
            var contacts = protocol.Execute(op);

            // Assert
            contacts.MustForTest().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            //Clean Up

            var removeContactOp = new RemoveContactV3Op(createdContact.Id);
            protocol.Execute(removeContactOp);
        }
    }
}
