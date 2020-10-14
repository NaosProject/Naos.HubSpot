// <copyright file="GetAllCompanyPropertiesResponse.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Diagnostics.CodeAnalysis;
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class ContactProperty.
    /// </summary>
    public partial class GetAllCompanyPropertiesResponse : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllCompanyPropertiesResponse"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="label">The label.</param>
        /// <param name="type">The type.</param>
        /// <param name="fieldType">Type of the field.</param>
        /// <param name="formField">The form field.</param>
        /// <param name="displayOrder">The display order.</param>
        public GetAllCompanyPropertiesResponse(string name, string description, string label, string type, string fieldType, string formField, int displayOrder)
        {
            this.Name = name;
            this.Description = description;
            this.Label = label;
            this.Type = type;
            this.FieldType = fieldType;
            this.FormField = formField;
            this.DisplayOrder = displayOrder;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Justification = NaosSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        public string FieldType { get; private set; }

        /// <summary>
        /// Gets the form field.
        /// </summary>
        /// <value>The form field.</value>
        public string FormField { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        /// <value>The display order.</value>
        public int DisplayOrder { get; private set; }
    }
}
