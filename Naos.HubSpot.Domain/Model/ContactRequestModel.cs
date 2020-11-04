﻿// <copyright file="ContactRequestModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Internal model used for requests that involve contacts.
    /// </summary>
    public partial class ContactRequestModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRequestModel"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="properties">The properties.</param>
        public ContactRequestModel(string id, IReadOnlyDictionary<string, string> properties)
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