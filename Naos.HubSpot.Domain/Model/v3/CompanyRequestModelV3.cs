﻿// <copyright file="CompanyRequestModelV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Internal model used to generate requests involving a company.
    /// </summary>
    public partial class CompanyRequestModelV3 : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRequestModelV3"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="properties">The properties dictionary.</param>
        public CompanyRequestModelV3(string id, IReadOnlyDictionary<string, string> properties)
        {
            var keys = properties.Keys.ToList();
            keys.MustForArg("Company properties must contain the company name").ContainElement(StandardCompanyPropertyNameV3.CompanyName.ToString());
            keys.MustForArg("Company properties must contain the city").ContainElement(StandardCompanyPropertyNameV3.City.ToString());
            keys.MustForArg("Company properties must contain the phone number").ContainElement(StandardCompanyPropertyNameV3.PhoneNumber.ToString());
            keys.MustForArg("Company properties must contain the city").ContainElement(StandardCompanyPropertyNameV3.City.ToString());
            keys.MustForArg("Company properties must contain the state").ContainElement(StandardCompanyPropertyNameV3.State.ToString());

            this.Id = id;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IReadOnlyDictionary<string, string> Properties { get; private set; }
    }
}
