// <copyright file="RemovePropertyV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class RemovePropertyV3Op.
    /// </summary>
    public partial class RemovePropertyV3Op : ReturningOperationBase<PropertyModelV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePropertyV3Op"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="propertyType">Type of the property.</param>
        public RemovePropertyV3Op(string propertyName, string propertyType)
        {
            this.PropertyName = propertyName;
            this.PropertyType = propertyType;
        }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        public string PropertyType { get; private set; }

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        public string PropertyName { get; private set; }
    }
}
