// <copyright file="PropertyModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a property passed to the HubSpot API.
    /// </summary>
    public partial class PropertyModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModel"/> class.
        /// </summary>
        /// <param name="name">The name of the property to pass to HubSpot.</param>
        /// <param name="value">The value of the property to pass to HubSpot.</param>
        public PropertyModel(string name, string value)
        {
            name.MustForArg().NotBeNullNorWhiteSpace();
            value.MustForArg().NotBeNullNorWhiteSpace();
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the value of the property.
        /// </summary>
        public string Value { get; private set; }
    }
}
