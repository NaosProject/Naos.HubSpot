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
    using System.Web;
    using Naos.HubSpot.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Enum.Recipes;
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
            var apiKey = "Get API key from here: ";
            var baseUri = new Uri("https://api.hubapi.com/");
            var protocol = new HubSpotProtocol("entityId", baseUri, apiKey);
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
            var apiKey = "Get HubSpot Api Key from https://app.hubspot.com/api-key/";
            var baseUri = new Uri("https://api.hubapi.com/");
            var protocol = new HubSpotProtocol("entityId", baseUri, apiKey);
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
            var apiKey = "Get HubSpot Api Key from https://app.hubspot.com/api-key/";
            var baseUri = new Uri("https://api.hubapi.com/");
            var protocol = new HubSpotProtocol("entityId", baseUri, apiKey);
            var op = new AssociateContactWithCompanyOp(1, 1);
            HttpException exception = null;
            // Act
            try
            {
                protocol.Execute(op);
            }
            catch (HttpException e)
            {
                exception = e;
            }
            
            // Assert
            exception.MustForTest().BeNull();
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void AddOrUpdateContactsOp___Does_not_return_http_error___When_executed()
        {
            // Arrange
            var apiKey = "Get HubSpot Api Key from https://app.hubspot.com/api-key/";
            var baseUri = new Uri("https://api.hubapi.com/");
            var protocol = new HubSpotProtocol("entityId", baseUri, apiKey);
            var op = new AddOrUpdateContactsOp(new List<Contact>());
            HttpException exception = null;
            // Act
            try
            {
                protocol.Execute(op);
            }
            catch (HttpException e)
            {
                exception = e;
            }

            // Assert
            exception.MustForTest().BeNull();
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void AddCompany___Does_not_return_null_contact___When_executed()
        {
            // Arrange
            var apiKey = "Get HubSpot Api Key from https://app.hubspot.com/api-key/";
            var baseUri = new Uri("https://api.hubapi.com/");
            var protocol = new HubSpotProtocol("entityId", baseUri, apiKey);
            var companyProps = new Dictionary<string, string>();
            companyProps.Add("name", "testCompany");
            var companyToAdd = new Company(companyProps);
            var op = new AddCompanyOp(companyToAdd);
            
            // Act
            var company = protocol.Execute(op);

            // Assert
            company.MustForTest(nameof(company)).NotBeNull();
        }

        [Fact(Skip = "Skipping because this uses external resources")]
        public static void UpdateCompany___Does_not_return_http_error___When_executed()
        {
            // Arrange
            var apiKey = "Get HubSpot Api Key from https://app.hubspot.com/api-key/";
            var baseUri = new Uri("https://api.hubapi.com/");
            var protocol = new HubSpotProtocol("entityId", baseUri, apiKey);
            var companyProps = new Dictionary<string, string>
            {
                { "name", "testCompany" },
                { HubSpotCompanyPropertyNames.ObjectId, "1" },
            };
            var companyList = new List<Company> { new Company(companyProps)  };
            var op = new UpdateCompanyOp(companyList);
            HttpException exception = null;
            // Act
            try
            {
                protocol.Execute(op);
            }
            catch (HttpException e)
            {
                exception = e;
            }

            // Assert
            exception.MustForTest().BeNull();
        }
    }
}
