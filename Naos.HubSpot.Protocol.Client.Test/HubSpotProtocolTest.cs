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
    using System.Runtime.CompilerServices;
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
        public static void GetAllContacts___Returns_nonempty_list_of_contacts___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var op = new GetAllContactsOp();
            var uniqueGuid = Guid.NewGuid();
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyName.Email.ToString(), "addcontacttest" + uniqueGuid + "@testemail.com" },
                { StandardContactPropertyName.FirstName.ToString(), "testContactFirst" + uniqueGuid },
                { StandardContactPropertyName.LastName.ToString(), "testcontactLast" + uniqueGuid },
                { StandardContactPropertyName.Website.ToString(), "www.test" + uniqueGuid + "website.com" },
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
        public static void CreateContact___Returns_valid_contact___When_executed()
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
        public static void CreateCompany___Returns_a_valid_company___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var uniqueGuid = Guid.NewGuid();
            var companyToCreateProps = new Dictionary<string, string>()
            {
                { StandardCompanyPropertyName.CompanyName.ToString(), "testcompany" + uniqueGuid },
                { StandardCompanyPropertyName.Domain.ToString(), "testcompanydomain" + uniqueGuid + ".com" },
                { StandardCompanyPropertyName.Industry.ToString(), "testcompanyindustry" + uniqueGuid },
                { StandardCompanyPropertyName.PhoneNumber.ToString(), uniqueGuid.ToString() },
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
        public static void UpdateContact___Returns_valid_contact___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var uniqueGuid = Guid.NewGuid();
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyName.FirstName.ToString(), "testContactFirst" + uniqueGuid },
                { StandardContactPropertyName.LastName.ToString(), "testcontactLast" + uniqueGuid },
                { StandardContactPropertyName.CompanyName.ToString(), "testCompany" + uniqueGuid },
                { StandardContactPropertyName.Website.ToString(), "www.testwebsite" + uniqueGuid + ".com" },
            };
            var contactToCreate = new Contact(contactToAddProps);
            var createContactOp = new CreateContactOp(contactToCreate);
            var createdContact = protocol.Execute(createContactOp);

            var propsToUpdate = createdContact.Properties.ToDictionary(k => k.Key, v => v.Value);
            propsToUpdate[StandardContactPropertyName.LastName.ToString()] = "updatedContactLastName" + uniqueGuid;
            var contactToUpdate = new Contact(propsToUpdate);

            // Act
            var updatedContact = protocol.Execute(new UpdateContactOp(contactToUpdate));

            // Assert
            updatedContact.Properties.TryGetValue(StandardContactPropertyName.HubSpotId.ToString(), out var createdId).MustForTest().BeTrue();
            updatedContact.Properties[StandardContactPropertyName.LastName.ToString()].MustForTest()
                .NotBeEqualTo(createdContact.Properties[StandardContactPropertyName.LastName.ToString()]);

            // Clean Up

            var removeContactOp = new RemoveCompanyByHubSpotIdOp(createdId);
            protocol.Execute(removeContactOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void UpdateCompany___Returns_valid_company___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var uniqueGuid = Guid.NewGuid();
            var companyToCreateProps = new Dictionary<string, string>()
            {
                { StandardCompanyPropertyName.CompanyName.ToString(), "testcompany" + uniqueGuid },
                { StandardCompanyPropertyName.Domain.ToString(), "testcompanydomain" + uniqueGuid + ".com" },
                { StandardCompanyPropertyName.Industry.ToString(), "testcompanyindustry" + uniqueGuid },
                { StandardCompanyPropertyName.PhoneNumber.ToString(), uniqueGuid.ToString() },
                { StandardCompanyPropertyName.City.ToString(), "San Antonio" },
                { StandardCompanyPropertyName.State.ToString(), "Texas" },
            };

            var companyToCreate = new Company(companyToCreateProps);
            var createCompanyOp = new CreateCompanyOp(companyToCreate);
            var createdCompany = protocol.Execute(createCompanyOp);
            var companyToUpdateProps = createdCompany.Properties.ToDictionary(k => k.Key, v => v.Value);
            companyToUpdateProps[StandardCompanyPropertyName.Domain.ToString()] = "updatedCompanyName" + uniqueGuid; 
            var companyToUpdate = new Company(companyToUpdateProps);
            var updateCompanyOp = new UpdateCompanyOp(companyToUpdate);

            // Act
            var updatedCompany = protocol.Execute(updateCompanyOp);

            // Assert 
            updatedCompany.Properties.TryGetValue(StandardCompanyPropertyName.HubSpotId.ToString(), out var updatedId).MustForTest().BeTrue();
            updatedCompany.Properties[StandardCompanyPropertyName.Domain.ToString()].MustForTest()
                .NotBeEqualTo(createdCompany.Properties[StandardCompanyPropertyName.Domain.ToString()]);

            // Clean Up
            var removeCompanyOp = new RemoveCompanyByHubSpotIdOp(updatedId);
            protocol.Execute(removeCompanyOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void AssociateContactWithCompany___Returns_valid_association___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var uniqueGuid = Guid.NewGuid();
            var companyToCreateProps = new Dictionary<string, string>()
            {
                {StandardCompanyPropertyName.CompanyName.ToString(), "testcompany" + uniqueGuid},
                {StandardCompanyPropertyName.Domain.ToString(), "testcompanydomain" + uniqueGuid + ".com"},
                {StandardCompanyPropertyName.Industry.ToString(), "testcompanyindustry" + uniqueGuid},
                {StandardCompanyPropertyName.PhoneNumber.ToString(), uniqueGuid.ToString() },
                {StandardCompanyPropertyName.City.ToString(), "San Antonio"},
                {StandardCompanyPropertyName.State.ToString(), "Texas"},
            };
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyName.FirstName.ToString(), "testContactFirst" + uniqueGuid },
                { StandardContactPropertyName.LastName.ToString(), "testcontactLast" + uniqueGuid },
                { StandardContactPropertyName.CompanyName.ToString(), "testCompany" + uniqueGuid },
                { StandardContactPropertyName.Website.ToString(), "www.testwebsite" + uniqueGuid + ".com" },
            };
            var contactToCreate = new Contact(contactToAddProps);
            var createContactOp = new CreateContactOp(contactToCreate);
            var createdContact = protocol.Execute(createContactOp);
            var companyToCreate = new Company(companyToCreateProps);
            var createCompanyOp = new CreateCompanyOp(companyToCreate);
            var createdCompany = protocol.Execute(createCompanyOp);
            string createdContactId = createdContact.Properties[StandardContactPropertyName.HubSpotId.ToString()];
            string createdCompanyId = createdCompany.Properties[StandardCompanyPropertyName.HubSpotId.ToString()];

            var associationToCreate = new AssociateContactWithCompanyOp(createdContactId, createdCompanyId );
            
            // Act 
            var association = protocol.Execute(associationToCreate);

            // Assert 
            association.Associations.MustForTest().NotBeNull();

            // Clean Up
            var contactToRemove = new RemoveContactByHubSpotIdOp(createdContactId);
            protocol.Execute(contactToRemove);
            var companyToRemove = new RemoveCompanyByHubSpotIdOp(createdCompanyId);
            protocol.Execute(companyToRemove);
    }
}
