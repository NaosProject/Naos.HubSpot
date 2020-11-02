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
    public partial class CompanyModelV3 : IModel<CompanyModelV3>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="CompanyModelV3"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(CompanyModelV3 left, CompanyModelV3 right)
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
        /// Determines whether two objects of type <see cref="CompanyModelV3"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(CompanyModelV3 left, CompanyModelV3 right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CompanyModelV3 other)
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
                      && this.UpdatedAt.IsEqualTo(other.UpdatedAt, StringComparer.Ordinal)
                      && this.Archived.IsEqualTo(other.Archived)
                      && this.Id.IsEqualTo(other.Id, StringComparer.Ordinal)
                      && this.Properties.IsEqualTo(other.Properties);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CompanyModelV3);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.CreatedAt)
            .Hash(this.UpdatedAt)
            .Hash(this.Archived)
            .Hash(this.Id)
            .Hash(this.Properties)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public CompanyModelV3 DeepClone()
        {
            var result = new CompanyModelV3(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.Archived);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CreatedAt" />.
        /// </summary>
        /// <param name="createdAt">The new <see cref="CreatedAt" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompanyModelV3" /> using the specified <paramref name="createdAt" /> for <see cref="CreatedAt" /> and a deep clone of every other property.</returns>
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
        public CompanyModelV3 DeepCloneWithCreatedAt(string createdAt)
        {
            var result = new CompanyModelV3(
                                 createdAt,
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.Archived);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="UpdatedAt" />.
        /// </summary>
        /// <param name="updatedAt">The new <see cref="UpdatedAt" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompanyModelV3" /> using the specified <paramref name="updatedAt" /> for <see cref="UpdatedAt" /> and a deep clone of every other property.</returns>
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
        public CompanyModelV3 DeepCloneWithUpdatedAt(string updatedAt)
        {
            var result = new CompanyModelV3(
                                 this.CreatedAt?.Clone().ToString(),
                                 updatedAt,
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.Archived);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Archived" />.
        /// </summary>
        /// <param name="archived">The new <see cref="Archived" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompanyModelV3" /> using the specified <paramref name="archived" /> for <see cref="Archived" /> and a deep clone of every other property.</returns>
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
        public CompanyModelV3 DeepCloneWithArchived(bool archived)
        {
            var result = new CompanyModelV3(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Id?.Clone().ToString(),
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 archived);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Id" />.
        /// </summary>
        /// <param name="id">The new <see cref="Id" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompanyModelV3" /> using the specified <paramref name="id" /> for <see cref="Id" /> and a deep clone of every other property.</returns>
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
        public CompanyModelV3 DeepCloneWithId(string id)
        {
            var result = new CompanyModelV3(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.UpdatedAt?.Clone().ToString(),
                                 id,
                                 this.Properties?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 this.Archived);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Properties" />.
        /// </summary>
        /// <param name="properties">The new <see cref="Properties" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompanyModelV3" /> using the specified <paramref name="properties" /> for <see cref="Properties" /> and a deep clone of every other property.</returns>
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
        public CompanyModelV3 DeepCloneWithProperties(IReadOnlyDictionary<string, string> properties)
        {
            var result = new CompanyModelV3(
                                 this.CreatedAt?.Clone().ToString(),
                                 this.UpdatedAt?.Clone().ToString(),
                                 this.Id?.Clone().ToString(),
                                 properties,
                                 this.Archived);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.HubSpot.Domain.CompanyModelV3: CreatedAt = {this.CreatedAt?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, UpdatedAt = {this.UpdatedAt?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Archived = {this.Archived.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Id = {this.Id?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Properties = {this.Properties?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}