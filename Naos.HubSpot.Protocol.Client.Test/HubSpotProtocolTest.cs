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
        public static void GetAllContactsOp___Returns_nonempty_list_of_contacts___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var op = new GetAllContactsOp();
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyName.Email.ToString(), "addcontacttest@testemail.com" },
                { StandardContactPropertyName.FirstName.ToString(), "testContactFirst" },
                { StandardContactPropertyName.LastName.ToString(), "testcontactLast" },
            };
            var contactToCreate = new Contact(contactToAddProps);
            var createContactOp = new AddOrUpdateContactsOp(new[] { contactToCreate });
            protocol.Execute(createContactOp);
            
            // Act
            var contacts = protocol.Execute(op);

            // Assert
            contacts.MustForTest().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void GetAllCompaniesOp___Returns_nonempty_list_of_companies___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var op = new GetAllCompaniesOp();

            // Act
            var companies = protocol.Execute(op);

            // Assert
            companies.MustForTest().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void AssociateContactWithCompanyOp___Does_not_return_http_error___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            
            // Create a contact
            var contactEmail = "testcontact@testemail.com";
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyName.Email.ToString(), contactEmail },
                { StandardContactPropertyName.FirstName.ToString(), "test" },
                { StandardContactPropertyName.LastName.ToString(), "contact" },
            };
            
            var contactToAdd = new Contact(contactToAddProps);
            var addContactOp = new AddOrUpdateContactsOp(new[] { contactToAdd });
            protocol.Execute(addContactOp);

            // Get contact that was created.

            var contacts = protocol.Execute(new GetAllContactsOp());
            var addedContactVid = contacts.First(_ =>
                    _.Properties[StandardContactPropertyName.Email.ToString().ConvertFromContactHubSpotNameToContactStandardNameIfNecessary()] == contactEmail)
                .Properties[StandardContactPropertyName.HubSpotId.ToString()];
            var addedIntContactId = Convert.ToInt32(addedContactVid, CultureInfo.InvariantCulture);
            // create a company
            var companyToAddProps = new Dictionary<string, string>()
            {
                { StandardCompanyPropertyName.CompanyName.ToString(), "testCompany" },
            };
            var companyToAdd = new Company(companyToAddProps);
            var addCompanyOp = new AddCompanyOp(companyToAdd);
            var addedCompany = protocol.Execute(addCompanyOp);
            var addedCompanyId = addedCompany;
            var addedLongCompanyId = Convert.ToInt64(addedCompanyId, CultureInfo.InvariantCulture);
            
            var assignOp = new AssociateContactWithCompanyOp(addedIntContactId, addedLongCompanyId);

            // Act & Assert - Will throw exception on failure
            protocol.Execute(assignOp);

            // Clean up
            var deleteContactOp = new DeleteContactOp(addedIntContactId);
            protocol.Execute(deleteContactOp);

            var deleteCompanyOp = new DeleteCompanyOp(addedLongCompanyId);
            protocol.Execute(deleteCompanyOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void AddOrUpdateContactsOp___Does_not_return_http_error___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var contactDict = new Dictionary<string, string>
            {
                { StandardContactPropertyName.EmailAddress.ToString(), "testemail@email.com" },
                { StandardContactPropertyName.FirstName.ToString(), "Dave" },
                { StandardContactPropertyName.LastName.ToString(), "C" },
            };

            var contactToAdd = new Contact(contactDict);
            var contactList = new[]
            {
                contactToAdd,
            };

            var op = new AddOrUpdateContactsOp(contactList);

            // Act & Assert - Will throw exception on failure
            protocol.Execute(op);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void AddCompanyOp___Does_not_return_null_contact___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var companyProps = new Dictionary<string, string>
            {
                { StandardCompanyPropertyName.CompanyName.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(), "testCompany" },
                { StandardCompanyPropertyName.Description.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(), "A test company" },
            };
            var companyToAdd = new Company(companyProps);
            var op = new AddCompanyOp(companyToAdd);
            
            // Act
            var company = protocol.Execute(op);

            // Assert
            company.MustForTest(nameof(company)).NotBeNull();
        }

        [Fact]
        public static void UpdateCompaniesOp___Does_not_return_http_error___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var initialProps = new Dictionary<string, string>
            {
                { StandardCompanyPropertyName.CompanyName.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(), "testCompany" },
                { StandardCompanyPropertyName.Description.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(), "this is the initial description." },
            };
            var companyToAdd = new Company(initialProps);
            var createCompanyOp = new AddCompanyOp(companyToAdd);
            // Create a company in HubSpot
            var createdCompany = protocol.Execute(createCompanyOp);

            // Update the company just created.
            var companyProps = new Dictionary<string, string>
            {
                { "name", "testCompany" },
                { "description", "this is a new company description" },
                { StandardCompanyPropertyName.HubSpotId.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(), createdCompany },
            };
            var companyList = new List<Company> { new Company(companyProps)  };
            var op = new UpdateCompaniesOp(companyList);

            // Act & Assert - Will throw exception on failure
            protocol.Execute(op);

            // Clean Up
            var createdCompanyLongId = Convert.ToInt64(createdCompany, CultureInfo.InvariantCulture);
            var deleteCompanyOp = new DeleteCompanyOp(createdCompanyLongId);
            protocol.Execute(deleteCompanyOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void DeleteContactOp___Does_not_return_http_error___When_executed()
        {
            // Arrange
            var email = "testemail@email.com";
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var contactDict = new Dictionary<string, string>
            {
                { StandardContactPropertyName.Email.ToString(), email },
                { StandardContactPropertyName.FirstName.ToString(), "Dave" },
                { StandardContactPropertyName.LastName.ToString(), "C" },
            };

            var contactToAdd = new Contact(contactDict);
            var contactList = new[]
            {
                contactToAdd,
            };
            var addOp = new AddOrUpdateContactsOp(contactList);
            protocol.Execute(addOp);
            var contacts = protocol.Execute(new GetAllContactsOp());
            var addedContact = contacts
                .First(_ => _.Properties.ContainsKey(StandardContactPropertyName.Email.ToString()) & 
                                             _.Properties.TryGetValue(StandardContactPropertyName.Email.ToString(), out var emailValue) &  
                                             emailValue == email);
            var vidStringToDelete = addedContact.Properties[StandardContactPropertyName.HubSpotId.ToString()];
            var vidIntToDelete = Convert.ToInt32(vidStringToDelete, CultureInfo.InvariantCulture);
            var deleteOp = new DeleteContactOp(vidIntToDelete);

            // Act
            protocol.Execute(deleteOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void DeleteCompany___Returns_a_deleted_company___When_executed()
        {
            // Arrange
            var proto = new HubSpotProtocol(BaseUri, ApiKey);
            var companyToAddProps = new Dictionary<string, string>
            {
                { StandardCompanyPropertyName.CompanyName.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(), "CompanyForDeleteCompanyTest" },
                { StandardCompanyPropertyName.Description.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(), "A test company that should be deleted." },
            };
            var companyToAdd = new Company(companyToAddProps);
            var addCompanyOp = new AddCompanyOp(companyToAdd);
            var addedCompany = proto.Execute(addCompanyOp);
            var companyIntId = Convert.ToInt64(addedCompany, CultureInfo.InvariantCulture);
            var deleteCompanyOp = new DeleteCompanyOp(companyIntId);

            // Act
            var deletedCompany = proto.Execute(deleteCompanyOp);

            // Assert
            deletedCompany.Deleted.MustForTest().BeTrue();
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void GetAllContactProperties___Returns_nonempty_collection___When_Executed()
        {
            // Arrange
            var operation = new GetAllContactPropertiesOp();
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            // Act
            var contactProperties = protocol.Execute(operation);

            // Assert
            contactProperties.ToList().MustForTest().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void GetAllCompanyProperties___Returns_nonempty_collection___When_Executed()
        {
            // Arrange
            var operation = new GetAllCompanyPropertiesOp();
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            // Act
            var contactProperties = protocol.Execute(operation);

            // Assert
            contactProperties.ToList().MustForTest().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void CreateCompanyProperty___Returns_company_property_with_matching_name_and_label___When_Executed()
        {
            // Arrange
            const string propName = "testprop";
            const string propLabel = "testlabel";
            var companyPropToBeCreated = new CreateCompanyPropertyRequest(propName, propLabel);
            var createOperation = new CreateCompanyPropertyOp(companyPropToBeCreated);
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            
            // Act 
            var companyProperty = protocol.Execute(createOperation);

            // Assert 
            companyProperty.Name.MustForTest().BeEqualTo(propName);
            companyProperty.Label.MustForTest().BeEqualTo(propLabel);

            // Clean up
            var deleteCompanyPropertyOp = new DeleteCompanyPropertyOp(propName);
            protocol.Execute(deleteCompanyPropertyOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void CreateContactProperty___Returns_contact_property_with_matching_name_and_label___When_Executed()
        {
            // Arrange
            const string propName = "testprop";
            const string propLabel = "testlabel";
            var contactPropToBeCreated = new CreateContactPropertyRequest(propName, propLabel);
            var createOperation = new CreateContactPropertyOp(contactPropToBeCreated);
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);

            // Act 
            var contactProperty = protocol.Execute(createOperation);

            // Assert 
            contactProperty.Name.MustForTest().BeEqualTo(propName);
            contactProperty.Label.MustForTest().BeEqualTo(propLabel);

            // Clean up
            var deleteContactPropertyOp = new DeleteContactPropertyOp(propName);
            protocol.Execute(deleteContactPropertyOp);
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void GetAllContactsOpV3___Returns_nonempty_list_of_contacts___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var op = new GetAllContactsV3Op();
            var contactToAddProps = new Dictionary<string, string>
            {
                { StandardContactPropertyNameV3.Email.ToString().ConvertFromContactStandardNameToContactHubSpotNameIfNecessaryV3(), "addcontacttest@testemail.com" },
                { StandardContactPropertyNameV3.FirstName.ToString().ConvertFromContactStandardNameToContactHubSpotNameIfNecessaryV3(), "testContactFirst" },
                { StandardContactPropertyNameV3.LastName.ToString().ConvertFromContactStandardNameToContactHubSpotNameIfNecessaryV3(), "testcontactLast" },
                { StandardContactPropertyNameV3.CompanyName.ToString().ConvertFromContactStandardNameToContactHubSpotNameIfNecessaryV3(), "testCompany" },
                { StandardContactPropertyNameV3.Website.ToString().ConvertFromContactStandardNameToContactHubSpotNameIfNecessaryV3(), "www.testwebsite.com" },
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

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void CreateContactOpV3___Returns_valid_contact___When_executed()
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
            var contactToCreate = new ContactAndCompanyModelV3(null, null, null, contactToAddProps);
            var createContactOp = new CreateContactV3Op(contactToCreate);

            // Act
            var createdContact = protocol.Execute(createContactOp);

            // Assert
            createdContact.MustForTest().NotBeNull();
            createdContact.Id.MustForTest().NotBeNull();

            // Clean Up

            var removeContactOp = new RemoveContactV3Op(createdContact.Id);
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

            var companyToCreate = new ContactAndCompanyModelV3(null, null, null, companyToCreateProps);
            var createCompanyOp = new CreateCompanyV3Op(companyToCreate);

            // Act
            var createdCompany = protocol.Execute(createCompanyOp);

            // Assert 
            createdCompany.MustForTest().NotBeNull();
            createdCompany.Id.MustForTest().NotBeNull();

            //Clean Up
            var removeCompanyOp = new RemoveContactV3Op(createdCompany.Id);
            protocol.Execute(removeCompanyOp);
        }
    }
}
