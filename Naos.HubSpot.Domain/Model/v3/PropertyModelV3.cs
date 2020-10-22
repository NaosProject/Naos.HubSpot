// <copyright file="PropertyModelV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class PropertyModelV3.
    /// </summary>
    public partial class PropertyModelV3 : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModelV3"/> class.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        /// <param name="hidden">if set to <c>true</c> [hidden].</param>
        /// <param name="modificationMetadataModel">The modification metadata model.</param>
        /// <param name="name">The name.</param>
        /// <param name="displayOrder">The display order.</param>
        /// <param name="options">The options.</param>
        /// <param name="label">The label.</param>
        /// <param name="propertyType">Type of the property.</param>
        /// <param name="hasUniqueValue">if set to <c>true</c> [has unique value].</param>
        /// <param name="fieldType">Type of the field.</param>
        /// <param name="formField">if set to <c>true</c> [form field].</param>
        public PropertyModelV3(string groupName, bool hidden, ModificationMetadataModel modificationMetadataModel, string name, long displayOrder, IReadOnlyCollection<OptionModel> options, string label, string propertyType, bool hasUniqueValue, string fieldType, bool formField)
        {
            this.GroupName = groupName;
            this.Hidden = hidden;
            this.ModificationMetadataModel = modificationMetadataModel;
            this.Name = name;
            this.DisplayOrder = displayOrder;
            this.Options = options;
            this.Label = label;
            this.PropertyType = propertyType;
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
        /// Gets a value indicating whether this <see cref="PropertyModelV3"/> is hidden.
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
        [JsonProperty("type")]
        public string PropertyType { get; private set; }

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

    /// <summary>
    /// Class ModificationMetadataModel.
    /// </summary>
    public partial class ModificationMetadataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationMetadataModel"/> class.
        /// </summary>
        /// <param name="readOnlyOptions">if set to <c>true</c> [read only options].</param>
        /// <param name="readOnlyValue">if set to <c>true</c> [read only value].</param>
        /// <param name="readOnlyDefinition">if set to <c>true</c> [read only definition].</param>
        /// <param name="canBeArchived">if set to <c>true</c> [can be archived].</param>
        public ModificationMetadataModel(bool readOnlyOptions, bool readOnlyValue, bool readOnlyDefinition, bool canBeArchived)
        {
            this.ReadOnlyOptions = readOnlyOptions;
            this.ReadOnlyValue = readOnlyValue;
            this.ReadOnlyDefinition = readOnlyDefinition;
            this.CanBeArchived = canBeArchived;
        }

        /// <summary>
        /// Gets a value indicating whether [read only options].
        /// </summary>
        /// <value><c>true</c> if [read only options]; otherwise, <c>false</c>.</value>
        public bool ReadOnlyOptions { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [read only value].
        /// </summary>
        /// <value><c>true</c> if [read only value]; otherwise, <c>false</c>.</value>
        public bool ReadOnlyValue { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [read only definition].
        /// </summary>
        /// <value><c>true</c> if [read only definition]; otherwise, <c>false</c>.</value>
        public bool ReadOnlyDefinition { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance can be archived.
        /// </summary>
        /// <value><c>true</c> if this instance can be archived; otherwise, <c>false</c>.</value>
        [JsonProperty("archivable")]
        public bool CanBeArchived { get; private set; }
    }

    /// <summary>
    /// Class OptionModel.
    /// </summary>
    public partial class OptionModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionModel"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="description">The description.</param>
        /// <param name="value">The value.</param>
        /// <param name="displayOrder">The display order.</param>
        /// <param name="hidden">if set to <c>true</c> [hidden].</param>
        public OptionModel(string label, string description, string value, long displayOrder, bool hidden)
        {
            this.Label = label;
            this.Description = description;
            this.Value = value;
            this.DisplayOrder = displayOrder;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        /// <value>The display order.</value>
        public long DisplayOrder { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="OptionModel"/> is hidden.
        /// </summary>
        /// <value><c>true</c> if hidden; otherwise, <c>false</c>.</value>
        public bool Hidden { get; private set; }
    }
}