﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.127.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class ModificationMetadataModel : IModel<ModificationMetadataModel>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModificationMetadataModel"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModificationMetadataModel left, ModificationMetadataModel right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="ModificationMetadataModel"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModificationMetadataModel left, ModificationMetadataModel right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModificationMetadataModel other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ReadOnlyOptions.IsEqualTo(other.ReadOnlyOptions)
                      && this.ReadOnlyValue.IsEqualTo(other.ReadOnlyValue)
                      && this.ReadOnlyDefinition.IsEqualTo(other.ReadOnlyDefinition)
                      && this.Archivable.IsEqualTo(other.Archivable);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModificationMetadataModel);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ReadOnlyOptions)
            .Hash(this.ReadOnlyValue)
            .Hash(this.ReadOnlyDefinition)
            .Hash(this.Archivable)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModificationMetadataModel DeepClone()
        {
            var result = new ModificationMetadataModel(
                                 this.ReadOnlyOptions,
                                 this.ReadOnlyValue,
                                 this.ReadOnlyDefinition,
                                 this.Archivable);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyOptions" />.
        /// </summary>
        /// <param name="readOnlyOptions">The new <see cref="ReadOnlyOptions" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModificationMetadataModel" /> using the specified <paramref name="readOnlyOptions" /> for <see cref="ReadOnlyOptions" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ModificationMetadataModel DeepCloneWithReadOnlyOptions(bool readOnlyOptions)
        {
            var result = new ModificationMetadataModel(
                                 readOnlyOptions,
                                 this.ReadOnlyValue,
                                 this.ReadOnlyDefinition,
                                 this.Archivable);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyValue" />.
        /// </summary>
        /// <param name="readOnlyValue">The new <see cref="ReadOnlyValue" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModificationMetadataModel" /> using the specified <paramref name="readOnlyValue" /> for <see cref="ReadOnlyValue" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ModificationMetadataModel DeepCloneWithReadOnlyValue(bool readOnlyValue)
        {
            var result = new ModificationMetadataModel(
                                 this.ReadOnlyOptions,
                                 readOnlyValue,
                                 this.ReadOnlyDefinition,
                                 this.Archivable);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDefinition" />.
        /// </summary>
        /// <param name="readOnlyDefinition">The new <see cref="ReadOnlyDefinition" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModificationMetadataModel" /> using the specified <paramref name="readOnlyDefinition" /> for <see cref="ReadOnlyDefinition" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ModificationMetadataModel DeepCloneWithReadOnlyDefinition(bool readOnlyDefinition)
        {
            var result = new ModificationMetadataModel(
                                 this.ReadOnlyOptions,
                                 this.ReadOnlyValue,
                                 readOnlyDefinition,
                                 this.Archivable);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Archivable" />.
        /// </summary>
        /// <param name="archivable">The new <see cref="Archivable" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModificationMetadataModel" /> using the specified <paramref name="archivable" /> for <see cref="Archivable" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ModificationMetadataModel DeepCloneWithArchivable(bool archivable)
        {
            var result = new ModificationMetadataModel(
                                 this.ReadOnlyOptions,
                                 this.ReadOnlyValue,
                                 this.ReadOnlyDefinition,
                                 archivable);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.HubSpot.Domain.ModificationMetadataModel: ReadOnlyOptions = {this.ReadOnlyOptions.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ReadOnlyValue = {this.ReadOnlyValue.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ReadOnlyDefinition = {this.ReadOnlyDefinition.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Archivable = {this.Archivable.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}