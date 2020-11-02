// <copyright file="CompanyV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// The consumer-facing company model.
    /// </summary>
    public partial class CompanyV3 : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyV3"/> class.
        /// </summary>
        /// <param name="properties">The properties.</param>
        public CompanyV3(IReadOnlyDictionary<string, string> properties)
        {
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IReadOnlyDictionary<string, string> Properties { get; private set; }
    }
}
