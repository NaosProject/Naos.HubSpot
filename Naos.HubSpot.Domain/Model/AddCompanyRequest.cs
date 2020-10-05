// <copyright file="AddCompanyRequest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the body of a request to add a company to HubSpot.
    /// </summary>
    public partial class AddCompanyRequest : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCompanyRequest"/> class.
        /// </summary>
        /// <param name="properties">The properties of the company to be added.</param>
        public AddCompanyRequest(IReadOnlyCollection<PropertyModel> properties)
        {
            // properties.MustForArg(nameof(properties))
            //    .NotBeNullNorEmptyDictionaryNorContainAnyNullValues("A company must have properties.");
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the properties of the company to be added.
        /// </summary>
        public IReadOnlyCollection<PropertyModel> Properties { get; private set; }
    }

    /// <summary>
    /// Builds an add company request.
    /// </summary>
    public static class AddCompanyRequestBuilder
    {
        /// <summary>
        /// Converts a company object into an add company request model.
        /// </summary>
        /// <param name="company">The company to be converted.</param>
        /// <returns>An add company request.</returns>
        public static AddCompanyRequest ToAddCompanyRequest(this Company company)
        {
            company.MustForArg(nameof(company)).NotBeNull("The company cannot be null.");
            var properties = company.Properties;
            // TODO: Check if company name is present.
            var propertiesModel = properties.Select(_ => new PropertyModel(_.Key.ConvertIfStandardCompanyName(), _.Value)).ToList();
            var result = new AddCompanyRequest(propertiesModel);
            return result;
        }
    }
}
