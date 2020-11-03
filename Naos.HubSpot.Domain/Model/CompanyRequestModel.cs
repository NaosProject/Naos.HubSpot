// <copyright file="CompanyRequestModel.cs" company="Naos Project">
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
    public partial class CompanyRequestModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRequestModel"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="properties">The properties dictionary.</param>
        public CompanyRequestModel(string id, IReadOnlyDictionary<string, string> properties)
        {
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
