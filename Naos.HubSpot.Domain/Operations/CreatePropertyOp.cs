// <copyright file="CreatePropertyOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using Naos.HubSpot.Domain.Model;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class CreatePropertyOp.
    /// Implements the <see cref="ReturningOperationBase{PropertyModel}" />.
    /// Implements the <see cref="IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{PropertyModel}" />
    /// <seealso cref="IModelViaCodeGen" />
    public partial class CreatePropertyOp : ReturningOperationBase<PropModel>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePropertyOp"/> class.
        /// </summary>
        /// <param name="customPropertyName">Name of the custom property.</param>
        /// <param name="objectType">Type of the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Justification = "Must be lower case for API")]
        public CreatePropertyOp(string customPropertyName, HubSpotPropertyObjectType objectType)
        {
            customPropertyName.ToLowerInvariant().MustForArg().BeEqualTo(customPropertyName);
            customPropertyName.Replace("-", string.Empty).MustForArg().BeEqualTo(customPropertyName);
            this.CustomPropertyName = customPropertyName;
            this.ObjectType = objectType;
        }

        /// <summary>
        /// Gets the name of the custom property.
        /// </summary>
        /// <value>The name of the custom property.</value>
        public string CustomPropertyName { get; private set; }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        public HubSpotPropertyObjectType ObjectType { get; private set; }
    }
}
