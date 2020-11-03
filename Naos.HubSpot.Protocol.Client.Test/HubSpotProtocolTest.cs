// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocolTest.cs" company="Naos Project">
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
        private const string ApiKey = "Get this here: https://app.hubspot.com/api-key/";
        private static readonly Uri BaseUri = new Uri("https://api.hubapi.com/");

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void GetAllContactsV3___Returns_nonempty_list_of_contacts___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var op = new GetAllContactsV3Op();
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyNameV3.Email.ToString(), "addcontacttest@testemail.com" },
                { StandardContactPropertyNameV3.FirstName.ToString(), "testContactFirst" },
                { StandardContactPropertyNameV3.LastName.ToString(), "testcontactLast" },
                { StandardContactPropertyNameV3.CompanyName.ToString(), "testCompany" },
                { StandardContactPropertyNameV3.Website.ToString(), "www.testwebsite.com" },
            };
            var contactToCreate = new ContactV3(contactToAddProps);
            var createContactOp = new CreateContactV3Op(contactToCreate);
            var createdContact = protocol.Execute(createContactOp);

            // Act
            var contacts = protocol.Execute(op);

            // Assert
            contacts.MustForTest().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            
            //Clean Up
            createdContact.Properties.TryGetValue(StandardContactPropertyNameV3.HubSpotId.ToString(), out var createdId);
            var removeContactOp = new RemoveContactByHubSpotIdV3Op(createdId);
            protocol.Execute(removeContactOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void CreateContactV3___Returns_valid_contact___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var guid = Guid.NewGuid();
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyNameV3.FirstName.ToString(), "firstName" + guid },
                { StandardContactPropertyNameV3.LastName.ToString(), "lastName" + guid },
                { StandardContactPropertyNameV3.Website.ToString(), "www.testwebsite" + guid + ".com" },
                { StandardContactPropertyNameV3.PhoneNumber.ToString(), guid.ToString() },
            };
            var contactToCreate = new ContactV3(contactToAddProps);
            var createContactOp = new CreateContactV3Op(contactToCreate);

            // Act
            var createdContact = protocol.Execute(createContactOp);

            // Assert
            createdContact.MustForTest().NotBeNull();
            createdContact.Properties.TryGetValue(StandardContactPropertyNameV3.HubSpotId.ToString(), out var createdId).MustForTest().BeTrue();

            // Clean Up

            var removeContactOp = new RemoveContactByHubSpotIdV3Op(createdId);
            protocol.Execute(removeContactOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void CreateCompanyV3___Returns_a_valid_company___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var companyToCreateProps = new Dictionary<string, string>()
            {
                { StandardCompanyPropertyNameV3.CompanyName.ToString(), "testcompany" },
                { StandardCompanyPropertyNameV3.Domain.ToString(), "testcompanydomain.com" },
                { StandardCompanyPropertyNameV3.Industry.ToString(), "testcompanyindustry" },
                { StandardCompanyPropertyNameV3.PhoneNumber.ToString(), "18001231234" },
                { StandardCompanyPropertyNameV3.City.ToString(), "San Antonio" },
                { StandardCompanyPropertyNameV3.State.ToString(), "Texas" },
            };

            var companyToCreate = new CompanyV3(companyToCreateProps);
            var createCompanyOp = new CreateCompanyV3Op(companyToCreate);

            // Act
            var createdCompany = protocol.Execute(createCompanyOp);

            // Assert 
            createdCompany.MustForTest().NotBeNull();
            createdCompany.Properties.TryGetValue(StandardCompanyPropertyNameV3.HubSpotId.ToString(), out var createdId).MustForTest().BeTrue();

            //Clean Up
            var removeCompanyOp = new RemoveContactByHubSpotIdV3Op(createdId);
            protocol.Execute(removeCompanyOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void UpdateContactV3___Returns_valid_contact___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyNameV3.Email.ToString(), "addcontacttest@testemail.com" },
                { StandardContactPropertyNameV3.FirstName.ToString(), "testContactFirst" },
                { StandardContactPropertyNameV3.LastName.ToString(), "testcontactLast" },
                { StandardContactPropertyNameV3.CompanyName.ToString(), "testCompany" },
                { StandardContactPropertyNameV3.Website.ToString(), "www.testwebsite.com" },
            };
            var contactToCreate = new ContactV3(contactToAddProps);
            var createContactOp = new CreateContactV3Op(contactToCreate);
            var createdContact = protocol.Execute(createContactOp);

            var propsToUpdate = createdContact.Properties.ToDictionary(k => k.Key, v => v.Value);
            propsToUpdate[StandardContactPropertyNameV3.LastName.ToString()] = "updatedContactLastName";
            var contactToUpdate = new ContactV3(propsToUpdate);

            // Act
            var updatedContact = protocol.Execute(new UpdateContactV3Op(contactToUpdate));

            // Assert
            updatedContact.Properties.TryGetValue(StandardContactPropertyNameV3.HubSpotId.ToString(), out var createdId).MustForTest().BeTrue();
            updatedContact.Properties[StandardContactPropertyNameV3.LastName.ToString()].MustForTest()
                .NotBeEqualTo(updatedContact.Properties[StandardContactPropertyNameV3.LastName.ToString()]);

            // Clean Up

            var removeContactOp = new RemoveCompanyByHubSpotIdV3Op(createdId);
            protocol.Execute(removeContactOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void UpdateCompanyV3___Returns_valid_company___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var companyToCreateProps = new Dictionary<string, string>()
            {
                { StandardCompanyPropertyNameV3.CompanyName.ToString(), "testcompany" },
                { StandardCompanyPropertyNameV3.Domain.ToString(), "testcompanydomain.com" },
                { StandardCompanyPropertyNameV3.Industry.ToString(), "testcompanyindustry" },
                { StandardCompanyPropertyNameV3.PhoneNumber.ToString(), "18001231234" },
                { StandardCompanyPropertyNameV3.City.ToString(), "San Antonio" },
                { StandardCompanyPropertyNameV3.State.ToString(), "Texas" },
            };

            var companyToCreate = new CompanyV3(companyToCreateProps);
            var createCompanyOp = new CreateCompanyV3Op(companyToCreate);
            var createdCompany = protocol.Execute(createCompanyOp);
            var companyToUpdateProps = createdCompany.Properties.ToDictionary(k => k.Key, v => v.Value);
            companyToUpdateProps[StandardCompanyPropertyNameV3.CompanyName.ToString()] = "updatedCompanyName"; 
            var companyToUpdate = new CompanyV3(companyToUpdateProps);
            var updateCompanyOp = new UpdateCompanyV3Op(companyToUpdate);

            // Act
            var updatedCompany = protocol.Execute(updateCompanyOp);

            // Assert 
            updatedCompany.Properties.TryGetValue(StandardCompanyPropertyNameV3.HubSpotId.ToString(), out var updatedId).MustForTest().BeTrue();
            updatedCompany.Properties[StandardCompanyPropertyNameV3.Domain.ToString()].MustForTest()
                .NotBeEqualTo(updatedCompany.Properties[StandardCompanyPropertyNameV3.Domain.ToString()]);

            // Clean Up
            var removeCompanyOp = new RemoveCompanyByHubSpotIdV3Op(updatedId);
            protocol.Execute(removeCompanyOp);
        }
    }
}
