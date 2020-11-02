// <copyright file="PropertyV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Class PropertyV3.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class PropertyV3 : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyV3"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public PropertyV3(string propertyName)
        {
            this.PropertyName = propertyName;
        }

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        public string PropertyName { get; private set; }
    }
}
