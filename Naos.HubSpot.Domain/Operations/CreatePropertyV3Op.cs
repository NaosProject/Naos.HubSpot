﻿// <copyright file="CreatePropertyV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class CreatePropertyV3Op.
    /// Implements the <see cref="ReturningOperationBase{PropertyModel}" />.
    /// Implements the <see cref="IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{PropertyModel}" />
    /// <seealso cref="IModelViaCodeGen" />
    public partial class CreatePropertyV3Op : ReturningOperationBase<PropertyModel>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePropertyV3Op"/> class.
        /// </summary>
        /// <param name="propertyToAdd">The property to add.</param>
        /// <param name="objectType">Type of the property.</param>
        public CreatePropertyV3Op(PropertyModelV3 propertyToAdd, string objectType)
        {
            this.PropertyToAdd = propertyToAdd;
            this.ObjectType = objectType;
        }

        /// <summary>
        /// Gets the property to add.
        /// </summary>
        /// <value>The property to add.</value>
        public PropertyModelV3 PropertyToAdd { get; private set; }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        public string ObjectType { get; private set; }
    }
}
