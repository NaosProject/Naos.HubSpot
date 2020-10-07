// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocolTest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client.Test
{
    using System;
    using System.Collections.Generic;
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
            var op = new AssociateContactWithCompanyOp(1, 1);

            // Act & Assert - Will throw exception on failure
            protocol.Execute(op);
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
        public static void AddCompany___Does_not_return_null_contact___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var companyProps = new Dictionary<string, string>();
            companyProps.Add(HubSpotCompanyPropertyNames.CompanyName, "testCompany");
            companyProps.Add(HubSpotCompanyPropertyNames.Description, "A test company");
            var companyToAdd = new Company(companyProps);
            var op = new AddCompanyOp(companyToAdd);
            
            // Act
            var company = protocol.Execute(op);

            // Assert
            company.MustForTest(nameof(company)).NotBeNull();
        }

        [Fact]
        public static void UpdateCompanies___Does_not_return_http_error___When_executed()
        {
            // Arrange
            var protocol = new HubSpotProtocol(BaseUri, ApiKey);
            var initialProps = new Dictionary<string, string>
            {
                { HubSpotCompanyPropertyNames.CompanyName, "testCompany" },
                { HubSpotCompanyPropertyNames.Description, "this is the initial description." },
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
                { HubSpotCompanyPropertyNames.CompanyId, createdCompany.Properties["hs_object_id"] },
            };
            var companyList = new List<Company> { new Company(companyProps)  };
            var op = new UpdateCompaniesOp(companyList);

            // Act & Assert - Will throw exception on failure
            protocol.Execute(op);
        }
    }
}
