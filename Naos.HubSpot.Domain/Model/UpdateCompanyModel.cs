// <copyright file="UpdateCompanyModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using System.Globalization;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the body of an update company post request.
    /// </summary>
    public partial class UpdateCompanyModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCompanyModel"/> class.
        /// </summary>
        /// <param name="objectId">The object ID of the company to be updated.</param>
        /// <param name="properties">The properties of the company to be updated.</param>
        public UpdateCompanyModel(int objectId, IReadOnlyCollection<PropertyModel> properties)
        {
            objectId.MustForArg(nameof(objectId)).NotBeLessThan(1, "Object ID must be greater than 0.: " + objectId.ToString(CultureInfo.InvariantCulture));
            properties.MustForArg(nameof(properties)).NotBeEmptyEnumerable("Company must contain at least one property.  Current: " + properties.Count.ToString(CultureInfo.InvariantCulture));
            this.ObjectId = objectId;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets the object ID of the company that is to be updated.
        /// </summary>
        public int ObjectId { get; private set; }

        /// <summary>
        /// Gets the list of properties of the company to be updated.
        /// </summary>
        public IReadOnlyCollection<PropertyModel> Properties { get; private set; }
    }
}
