﻿// <copyright file="ContactPropertyModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class ContactProperty.
    /// </summary>
    public partial class ContactPropertyModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPropertyModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="label">The label.</param>
        /// <param name="groupName">Name of the group.</param>
        /// <param name="type">The type.</param>
        /// <param name="fieldType">Type of the field.</param>
        /// <param name="displayOrder">The display order.</param>
        /// <param name="readOnlyDefinition">The read only definition.</param>
        /// <param name="favoriteOrder">The favorited order.</param>
        /// <param name="displayMode">The display mode.</param>
        /// <param name="formField">The form field.</param>
        /// <param name="deleted">if set to <c>true</c> [deleted].</param>
        /// <param name="readOnlyValue">if set to <c>true</c> [read only value].</param>
        /// <param name="hidden">if set to <c>true</c> [hidden].</param>
        /// <param name="mutableDefinitionCannotBeDeleted">if set to <c>true</c> [mutable definition not deletable].</param>
        /// <param name="favorite">if set to <c>true</c> [favorited].</param>
        /// <param name="calculated">if set to <c>true</c> [calculated].</param>
        /// <param name="externalOptions">if set to <c>true</c> [external options].</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Naming",
            "CA1704:IdentifiersShouldBeSpelledCorrectly",
            MessageId = "deletable",
            Justification = NaosSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Naming",
            "CA1704:IdentifiersShouldBeSpelledCorrectly",
            MessageId = "favorited",
            Justification = NaosSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public ContactPropertyModel(
            string name,
            string label,
            string groupName,
            string type,
            string fieldType,
            int? displayOrder,
            string readOnlyDefinition,
            int? favoriteOrder,
            string displayMode,
            string formField,
            bool? deleted = false,
            bool? readOnlyValue = false,
            bool? hidden = false,
            bool? mutableDefinitionCannotBeDeleted = false,
            bool? favorite = false,
            bool? calculated = false,
            bool? externalOptions = false)
        {
            this.Name = name;
            this.Label = label;
            this.GroupName = groupName;
            this.Type = type;
            this.FieldType = fieldType;
            this.Deleted = deleted;
            this.DisplayOrder = displayOrder;
            this.ReadOnlyValue = readOnlyValue;
            this.ReadOnlyDefinition = readOnlyDefinition;
            this.Hidden = hidden;
            this.MutableDefinitionNotDeletable = mutableDefinitionCannotBeDeleted;
            this.Favorited = favorite;
            this.FavoritedOrder = favoriteOrder;
            this.Calculated = calculated;
            this.ExternalOptions = externalOptions;
            this.DisplayMode = displayMode;
            this.FormField = formField;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the name of the group.
        /// </summary>
        /// <value>The name of the group.</value>
        public string GroupName { get; private set; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Naming",
            "CA1721:PropertyNamesShouldNotMatchGetMethods",
            MessageId = "_Type",
            Justification = "Name is controlled by external API.  Cannot be changed internally.")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        public string FieldType { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ContactPropertyModel"/> is deleted.
        /// </summary>
        /// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
        public bool? Deleted { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        /// <value>The display order.</value>
        public int? DisplayOrder { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [read only value].
        /// </summary>
        /// <value><c>true</c> if [read only value]; otherwise, <c>false</c>.</value>
        public bool? ReadOnlyValue { get; private set; }

        /// <summary>
        /// Gets the read only definition.
        /// </summary>
        /// <value>The read only definition.</value>
        public string ReadOnlyDefinition { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ContactPropertyModel"/> is hidden.
        /// </summary>
        /// <value><c>true</c> if hidden; otherwise, <c>false</c>.</value>
        public bool? Hidden { get; private set; }

        /// <summary>
        /// Gets a value indicating whether /[mutable definition not deletable].
        /// </summary>
        /// <value><c>true</c> if [mutable definition not deletable]; otherwise, <c>false</c>.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Naming",
            "CA1704:IdentifiersShouldBeSpelledCorrectly",
            MessageId = "Deletable",
            Justification = NaosSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public bool? MutableDefinitionNotDeletable { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ContactPropertyModel"/> is favorited.
        /// </summary>
        /// <value><c>true</c> if favorited; otherwise, <c>false</c>.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Naming",
            "CA1704:IdentifiersShouldBeSpelledCorrectly",
            MessageId = "Favorited",
            Justification = NaosSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public bool? Favorited { get; private set; }

        /// <summary>
        /// Gets the favorited order.
        /// </summary>
        /// <value>The favorited order.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Naming",
            "CA1704:IdentifiersShouldBeSpelledCorrectly",
            MessageId = "Favorited",
            Justification = NaosSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public int? FavoritedOrder { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ContactPropertyModel"/> is calculated.
        /// </summary>
        /// <value><c>true</c> if calculated; otherwise, <c>false</c>.</value>
        public bool? Calculated { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [external options].
        /// </summary>
        /// <value><c>true</c> if [external options]; otherwise, <c>false</c>.</value>
        public bool? ExternalOptions { get; private set; }

        /// <summary>
        /// Gets the display mode.
        /// </summary>
        /// <value>The display mode.</value>
        public string DisplayMode { get; private set; }

        /// <summary>
        /// Gets the form field.
        /// </summary>
        /// <value>The form field.</value>
        public string FormField { get; private set; }
    }
}