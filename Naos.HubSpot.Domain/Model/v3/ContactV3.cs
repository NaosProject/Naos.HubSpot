// <copyright file="ContactV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class ContactAndContactModelV3.
    /// Implements the <see cref="IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="IModelViaCodeGen" />
    public partial class ContactV3 : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactV3"/> class.
        /// </summary>
        /// <param name="properties">The properties.</param>
        public ContactV3(IReadOnlyDictionary<string, string> properties)
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
