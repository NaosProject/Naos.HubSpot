// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Company.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// Object to describe a company in HubSpot.
    /// </summary>
    public partial class Company : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        /// <param name="properties">The properties.</param>
        public Company(
            IReadOnlyDictionary<string, string> properties)
        {
            properties.MustForArg(nameof(properties)).NotBeNullNorEmptyDictionary();
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IReadOnlyDictionary<string, string> Properties { get; private set; }
    }
}