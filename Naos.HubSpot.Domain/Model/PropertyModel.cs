// <copyright file="PropertyModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Model
{
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents a property passed to the HubSpot API.
    /// </summary>
    public class PropertyModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModel"/> class.
        /// </summary>
        /// <param name="propertyName">The name of the property to pass to HubSpot.</param>
        /// <param name="propertyValue">The value of the property to pass to HubSpot.</param>
        public PropertyModel(string propertyName, string propertyValue)
        {
            propertyName.MustForArg().NotBeNullNorWhiteSpace();
            propertyValue.MustForArg().NotBeNullNorWhiteSpace();
            this.Property = propertyName;
            this.Value = propertyValue;
        }

        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>
        public string Value { get; set; }
    }
}
