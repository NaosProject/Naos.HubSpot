// <copyright file="RemovePropertyOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using Naos.HubSpot.Domain.Model;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class RemovePropertyOp.
    /// </summary>
    public partial class RemovePropertyOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePropertyOp"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="propertyType">Type of the property.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Justification = "Must be lower case for API")]
        public RemovePropertyOp(string propertyName, HubSpotPropertyObjectType propertyType)
        {
            propertyName.ToLowerInvariant().MustForArg().BeEqualTo(propertyName);
            propertyName.Replace("-", string.Empty).MustForArg().BeEqualTo(propertyName);
            this.PropertyName = propertyName;
            this.PropertyType = propertyType;
        }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        public HubSpotPropertyObjectType PropertyType { get; private set; }

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        public string PropertyName { get; private set; }
    }
}
