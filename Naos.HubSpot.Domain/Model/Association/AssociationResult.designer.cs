﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.128.0)
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
    public partial class AssociationResult : IModel<AssociationResult>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="AssociationResult"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(AssociationResult left, AssociationResult right)
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
        /// Determines whether two objects of type <see cref="AssociationResult"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(AssociationResult left, AssociationResult right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(AssociationResult other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.CreatedAt.IsEqualTo(other.CreatedAt, StringComparer.Ordinal)
                      && this.Archived.IsEqualTo(other.Archived)
                      && this.Id.IsEqualTo(other.Id, StringComparer.Ordinal)
                      && this.Properties.IsEqualTo(other.Properties)
                      && this.UpdatedAt.IsEqualTo(other.UpdatedAt, StringComparer.Ordinal)
                      && this.Associations.IsEqualTo(other.Associations);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as AssociationResult);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.CreatedAt)
            .Hash(this.Archived)
            .Hash(this.Id)
            .Hash(this.Properties)
            .Hash(this.UpdatedAt)
            .Hash(this.Associations)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public AssociationResult DeepClone()
        {
            var result = new AssociationResult(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.Archived,
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Associations?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CreatedAt" />.
        /// </summary>
        /// <param name="createdAt">The new <see cref="CreatedAt" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="AssociationResult" /> using the specified <paramref name="createdAt" /> for <see cref="CreatedAt" /> and a deep clone of every other property.</returns>
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
        public AssociationResult DeepCloneWithCreatedAt(string createdAt)
        {
            var result = new AssociationResult(
                                 createdAt,
                                 this.Archived,
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Associations?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Archived" />.
        /// </summary>
        /// <param name="archived">The new <see cref="Archived" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="AssociationResult" /> using the specified <paramref name="archived" /> for <see cref="Archived" /> and a deep clone of every other property.</returns>
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
        public AssociationResult DeepCloneWithArchived(bool archived)
        {
            var result = new AssociationResult(
                                 this.CreatedAt?.Clone().ToString(),
                                 archived,
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Associations?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Id" />.
        /// </summary>
        /// <param name="id">The new <see cref="Id" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="AssociationResult" /> using the specified <paramref name="id" /> for <see cref="Id" /> and a deep clone of every other property.</returns>
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
        public AssociationResult DeepCloneWithId(string id)
        {
            var result = new AssociationResult(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.Archived,
                                 id,
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Associations?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Properties" />.
        /// </summary>
        /// <param name="properties">The new <see cref="Properties" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="AssociationResult" /> using the specified <paramref name="properties" /> for <see cref="Properties" /> and a deep clone of every other property.</returns>
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
        public AssociationResult DeepCloneWithProperties(IReadOnlyDictionary<string, string> properties)
        {
            var result = new AssociationResult(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.Archived,
                                 this.Id?.Clone().ToString(),
                                 properties,
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Associations?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="UpdatedAt" />.
        /// </summary>
        /// <param name="updatedAt">The new <see cref="UpdatedAt" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="AssociationResult" /> using the specified <paramref name="updatedAt" /> for <see cref="UpdatedAt" /> and a deep clone of every other property.</returns>
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
        public AssociationResult DeepCloneWithUpdatedAt(string updatedAt)
        {
            var result = new AssociationResult(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.Archived,
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 updatedAt,
                                 this.Associations?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Associations" />.
        /// </summary>
        /// <param name="associations">The new <see cref="Associations" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="AssociationResult" /> using the specified <paramref name="associations" /> for <see cref="Associations" /> and a deep clone of every other property.</returns>
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
        public AssociationResult DeepCloneWithAssociations(AssociationsAssociationsSection associations)
        {
            var result = new AssociationResult(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.Archived,
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.UpdatedAt?.Clone().ToString(),
                                 associations);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.HubSpot.Domain.AssociationResult: CreatedAt = {this.CreatedAt?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Archived = {this.Archived.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Id = {this.Id?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Properties = {this.Properties?.ToString() ?? "<null>"}, UpdatedAt = {this.UpdatedAt?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Associations = {this.Associations?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}