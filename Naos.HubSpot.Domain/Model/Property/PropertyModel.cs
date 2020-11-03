// <copyright file="PropertyModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class PropertyModel.
    /// </summary>
    public partial class PropertyModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModel"/> class.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        /// <param name="hidden">if set to <c>true</c> [hidden].</param>
        /// <param name="name">The name.</param>
        /// <param name="displayOrder">The display order.</param>
        /// <param name="label">The label.</param>
        /// <param name="type">Type of the property.</param>
        /// <param name="hasUniqueValue">if set to <c>true</c> [has unique value].</param>
        /// <param name="fieldType">Type of the field.</param>
        /// <param name="formField">if set to <c>true</c> [form field].</param>
        /// <param name="modificationMetadataModel">The modification metadata model.</param>
        /// <param name="options">The options.</param>
        public PropertyModel(
            string groupName,
            bool hidden,
            string name,
            long displayOrder,
            string label,
            string type,
            bool hasUniqueValue,
            string fieldType,
            bool formField,
            ModificationMetadataModel modificationMetadataModel = null,
            IReadOnlyCollection<OptionModel> options = null)
        {
            this.GroupName = groupName;
            this.Hidden = hidden;
            this.ModificationMetadataModel = modificationMetadataModel;
            this.Name = name;
            this.DisplayOrder = displayOrder;
            this.Options = options;
            this.Label = label;
            this.Type = type;
            this.HasUniqueValue = hasUniqueValue;
            this.FieldType = fieldType;
            this.FormField = formField;
        }

        /// <summary>
        /// Gets the name of the group.
        /// </summary>
        /// <value>The name of the group.</value>
        public string GroupName { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="PropertyModel"/> is hidden.
        /// </summary>
        /// <value><c>true</c> if hidden; otherwise, <c>false</c>.</value>
        public bool Hidden { get; private set; }

        /// <summary>
        /// Gets the modification metadata model.
        /// </summary>
        /// <value>The modification metadata model.</value>
        public ModificationMetadataModel ModificationMetadataModel { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        /// <value>The display order.</value>
        public long DisplayOrder { get; private set; }

        /// <summary>
        /// Gets the options.
        /// </summary>
        /// <value>The options.</value>
        public IReadOnlyCollection<OptionModel> Options { get; private set; }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance has unique value.
        /// </summary>
        /// <value><c>true</c> if this instance has unique value; otherwise, <c>false</c>.</value>
        public bool HasUniqueValue { get; private set; }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Justification = "Naming controlled by external api")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        public string FieldType { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [form field].
        /// </summary>
        /// <value><c>true</c> if [form field]; otherwise, <c>false</c>.</value>
        public bool FormField { get; private set; }
    }
}