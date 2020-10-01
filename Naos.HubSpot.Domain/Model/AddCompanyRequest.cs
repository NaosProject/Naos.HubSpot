// <copyright file="AddCompanyRequest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Model
{
    using System.Collections.Generic;
    using System.Linq;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents the body of a request to add a company to HubSpot.
    /// </summary>
    public class AddCompanyRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCompanyRequest"/> class.
        /// </summary>
        /// <param name="properties">The properties of the company to be added.</param>
        public AddCompanyRequest(IReadOnlyDictionary<string, string> properties)
        {
            properties.MustForArg(nameof(properties))
                .NotBeNullNorEmptyDictionaryNorContainAnyNullValues("A company must have properties.");
            properties.Keys.MustForArg(nameof(properties.Keys))
                .ContainString("name", "A company name must be provided.");
            this.Properties = properties.Select(_ => new PropertyModel(_.Key, _.Value)).ToList();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCompanyRequest"/> class.
        /// </summary>
        /// <param name="company">The company to be added to HubSpot.</param>
        public AddCompanyRequest(Company company)
        {
            company.MustForArg(nameof(company)).NotBeNull("The company cannot be null.");
            var properties = company.Properties;
            properties.MustForArg(nameof(properties))
                .NotBeNullNorEmptyDictionaryNorContainAnyNullValues("A company must have properties.");
            properties.Keys.MustForArg(nameof(properties.Keys))
                .ContainString("name", "A company name must be provided.");
            this.Properties = properties.Select(_ => new PropertyModel(_.Key, _.Value)).ToList();
        }

        /// <summary>
        /// Gets the properties of the company to be added.
        /// </summary>
        public IReadOnlyCollection<PropertyModel> Properties { get; private set; }
    }
}
