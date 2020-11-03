// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocolTest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client.Test
{
    using System;
    using System.Collections.Generic;
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
            var op = new GetAllContactsOp();
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyName.Email.ToString(), "addcontacttest@testemail.com" },
                { StandardContactPropertyName.FirstName.ToString(), "testContactFirst" },
                { StandardContactPropertyName.LastName.ToString(), "testcontactLast" },
                { StandardContactPropertyName.CompanyName.ToString(), "testCompany" },
                { StandardContactPropertyName.Website.ToString(), "www.testwebsite.com" },
            };
            var contactToCreate = new Contact(contactToAddProps);
            var createContactOp = new CreateContactOp(contactToCreate);
            var createdContact = protocol.Execute(createContactOp);

            // Act
            var contacts = protocol.Execute(op);

            // Assert
            contacts.MustForTest().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            
            //Clean Up
            createdContact.Properties.TryGetValue(StandardContactPropertyName.HubSpotId.ToString(), out var createdId);
            var removeContactOp = new RemoveContactByHubSpotIdOp(createdId);
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
                { StandardContactPropertyName.FirstName.ToString(), "firstName" + guid },
                { StandardContactPropertyName.LastName.ToString(), "lastName" + guid },
                { StandardContactPropertyName.Website.ToString(), "www.testwebsite" + guid + ".com" },
                { StandardContactPropertyName.PhoneNumber.ToString(), guid.ToString() },
            };
            var contactToCreate = new Contact(contactToAddProps);
            var createContactOp = new CreateContactOp(contactToCreate);

            // Act
            var createdContact = protocol.Execute(createContactOp);

            // Assert
            createdContact.MustForTest().NotBeNull();
            createdContact.Properties.TryGetValue(StandardContactPropertyName.HubSpotId.ToString(), out var createdId).MustForTest().BeTrue();

            // Clean Up

            var removeContactOp = new RemoveContactByHubSpotIdOp(createdId);
            protocol.Execute(removeContactOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void CreateCompanyV3___Returns_a_valid_company___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var companyToCreateProps = new Dictionary<string, string>()
            {
                { StandardCompanyPropertyName.CompanyName.ToString(), "testcompany" },
                { StandardCompanyPropertyName.Domain.ToString(), "testcompanydomain.com" },
                { StandardCompanyPropertyName.Industry.ToString(), "testcompanyindustry" },
                { StandardCompanyPropertyName.PhoneNumber.ToString(), "18001231234" },
                { StandardCompanyPropertyName.City.ToString(), "San Antonio" },
                { StandardCompanyPropertyName.State.ToString(), "Texas" },
            };

            var companyToCreate = new Company(companyToCreateProps);
            var createCompanyOp = new CreateCompanyOp(companyToCreate);

            // Act
            var createdCompany = protocol.Execute(createCompanyOp);

            // Assert 
            createdCompany.MustForTest().NotBeNull();
            createdCompany.Properties.TryGetValue(StandardCompanyPropertyName.HubSpotId.ToString(), out var createdId).MustForTest().BeTrue();

            //Clean Up
            var removeCompanyOp = new RemoveContactByHubSpotIdOp(createdId);
            protocol.Execute(removeCompanyOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void UpdateContactV3___Returns_valid_contact___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyName.Email.ToString(), "addcontacttest@testemail.com" },
                { StandardContactPropertyName.FirstName.ToString(), "testContactFirst" },
                { StandardContactPropertyName.LastName.ToString(), "testcontactLast" },
                { StandardContactPropertyName.CompanyName.ToString(), "testCompany" },
                { StandardContactPropertyName.Website.ToString(), "www.testwebsite.com" },
            };
            var contactToCreate = new Contact(contactToAddProps);
            var createContactOp = new CreateContactOp(contactToCreate);
            var createdContact = protocol.Execute(createContactOp);

            var propsToUpdate = createdContact.Properties.ToDictionary(k => k.Key, v => v.Value);
            propsToUpdate[StandardContactPropertyName.LastName.ToString()] = "updatedContactLastName";
            var contactToUpdate = new Contact(propsToUpdate);

            // Act
            var updatedContact = protocol.Execute(new UpdateContactOp(contactToUpdate));

            // Assert
            updatedContact.Properties.TryGetValue(StandardContactPropertyName.HubSpotId.ToString(), out var createdId).MustForTest().BeTrue();
            updatedContact.Properties[StandardContactPropertyName.LastName.ToString()].MustForTest()
                .NotBeEqualTo(updatedContact.Properties[StandardContactPropertyName.LastName.ToString()]);

            // Clean Up

            var removeContactOp = new RemoveCompanyByHubSpotIdOp(createdId);
            protocol.Execute(removeContactOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void UpdateCompanyV3___Returns_valid_company___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var companyToCreateProps = new Dictionary<string, string>()
            {
                { StandardCompanyPropertyName.CompanyName.ToString(), "testcompany" },
                { StandardCompanyPropertyName.Domain.ToString(), "testcompanydomain.com" },
                { StandardCompanyPropertyName.Industry.ToString(), "testcompanyindustry" },
                { StandardCompanyPropertyName.PhoneNumber.ToString(), "18001231234" },
                { StandardCompanyPropertyName.City.ToString(), "San Antonio" },
                { StandardCompanyPropertyName.State.ToString(), "Texas" },
            };

            var companyToCreate = new Company(companyToCreateProps);
            var createCompanyOp = new CreateCompanyOp(companyToCreate);
            var createdCompany = protocol.Execute(createCompanyOp);
            var companyToUpdateProps = createdCompany.Properties.ToDictionary(k => k.Key, v => v.Value);
            companyToUpdateProps[StandardCompanyPropertyName.CompanyName.ToString()] = "updatedCompanyName"; 
            var companyToUpdate = new Company(companyToUpdateProps);
            var updateCompanyOp = new UpdateCompanyOp(companyToUpdate);

            // Act
            var updatedCompany = protocol.Execute(updateCompanyOp);

            // Assert 
            updatedCompany.Properties.TryGetValue(StandardCompanyPropertyName.HubSpotId.ToString(), out var updatedId).MustForTest().BeTrue();
            updatedCompany.Properties[StandardCompanyPropertyName.Domain.ToString()].MustForTest()
                .NotBeEqualTo(updatedCompany.Properties[StandardCompanyPropertyName.Domain.ToString()]);

            // Clean Up
            var removeCompanyOp = new RemoveCompanyByHubSpotIdOp(updatedId);
            protocol.Execute(removeCompanyOp);
        }
    }
}
