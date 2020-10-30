﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.121.0)
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
    public partial class GetAllCompanyPropertiesResponse : IModel<GetAllCompanyPropertiesResponse>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="GetAllCompanyPropertiesResponse"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(GetAllCompanyPropertiesResponse left, GetAllCompanyPropertiesResponse right)
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
        /// Determines whether two objects of type <see cref="GetAllCompanyPropertiesResponse"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(GetAllCompanyPropertiesResponse left, GetAllCompanyPropertiesResponse right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(GetAllCompanyPropertiesResponse other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Name.IsEqualTo(other.Name, StringComparer.Ordinal)
                      && this.Description.IsEqualTo(other.Description, StringComparer.Ordinal)
                      && this.Label.IsEqualTo(other.Label, StringComparer.Ordinal)
                      && this.Type.IsEqualTo(other.Type, StringComparer.Ordinal)
                      && this.FieldType.IsEqualTo(other.FieldType, StringComparer.Ordinal)
                      && this.FormField.IsEqualTo(other.FormField, StringComparer.Ordinal)
                      && this.DisplayOrder.IsEqualTo(other.DisplayOrder);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as GetAllCompanyPropertiesResponse);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Name)
            .Hash(this.Description)
            .Hash(this.Label)
            .Hash(this.Type)
            .Hash(this.FieldType)
            .Hash(this.FormField)
            .Hash(this.DisplayOrder)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public GetAllCompanyPropertiesResponse DeepClone()
        {
            var result = new GetAllCompanyPropertiesResponse(
                                 this.Name?.Clone().ToString(),
                                 this.Description?.Clone().ToString(),
                                 this.Label?.Clone().ToString(),
                                 this.Type?.Clone().ToString(),
                                 this.FieldType?.Clone().ToString(),
                                 this.FormField?.Clone().ToString(),
                                 this.DisplayOrder);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Name" />.
        /// </summary>
        /// <param name="name">The new <see cref="Name" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetAllCompanyPropertiesResponse" /> using the specified <paramref name="name" /> for <see cref="Name" /> and a deep clone of every other property.</returns>
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
        public GetAllCompanyPropertiesResponse DeepCloneWithName(string name)
        {
            var result = new GetAllCompanyPropertiesResponse(
                                 name,
                                 this.Description?.Clone().ToString(),
                                 this.Label?.Clone().ToString(),
                                 this.Type?.Clone().ToString(),
                                 this.FieldType?.Clone().ToString(),
                                 this.FormField?.Clone().ToString(),
                                 this.DisplayOrder);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Description" />.
        /// </summary>
        /// <param name="description">The new <see cref="Description" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetAllCompanyPropertiesResponse" /> using the specified <paramref name="description" /> for <see cref="Description" /> and a deep clone of every other property.</returns>
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
        public GetAllCompanyPropertiesResponse DeepCloneWithDescription(string description)
        {
            var result = new GetAllCompanyPropertiesResponse(
                                 this.Name?.Clone().ToString(),
                                 description,
                                 this.Label?.Clone().ToString(),
                                 this.Type?.Clone().ToString(),
                                 this.FieldType?.Clone().ToString(),
                                 this.FormField?.Clone().ToString(),
                                 this.DisplayOrder);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Label" />.
        /// </summary>
        /// <param name="label">The new <see cref="Label" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetAllCompanyPropertiesResponse" /> using the specified <paramref name="label" /> for <see cref="Label" /> and a deep clone of every other property.</returns>
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
        public GetAllCompanyPropertiesResponse DeepCloneWithLabel(string label)
        {
            var result = new GetAllCompanyPropertiesResponse(
                                 this.Name?.Clone().ToString(),
                                 this.Description?.Clone().ToString(),
                                 label,
                                 this.Type?.Clone().ToString(),
                                 this.FieldType?.Clone().ToString(),
                                 this.FormField?.Clone().ToString(),
                                 this.DisplayOrder);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Type" />.
        /// </summary>
        /// <param name="type">The new <see cref="Type" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetAllCompanyPropertiesResponse" /> using the specified <paramref name="type" /> for <see cref="Type" /> and a deep clone of every other property.</returns>
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
        public GetAllCompanyPropertiesResponse DeepCloneWithType(string type)
        {
            var result = new GetAllCompanyPropertiesResponse(
                                 this.Name?.Clone().ToString(),
                                 this.Description?.Clone().ToString(),
                                 this.Label?.Clone().ToString(),
                                 type,
                                 this.FieldType?.Clone().ToString(),
                                 this.FormField?.Clone().ToString(),
                                 this.DisplayOrder);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="FieldType" />.
        /// </summary>
        /// <param name="fieldType">The new <see cref="FieldType" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetAllCompanyPropertiesResponse" /> using the specified <paramref name="fieldType" /> for <see cref="FieldType" /> and a deep clone of every other property.</returns>
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
        public GetAllCompanyPropertiesResponse DeepCloneWithFieldType(string fieldType)
        {
            var result = new GetAllCompanyPropertiesResponse(
                                 this.Name?.Clone().ToString(),
                                 this.Description?.Clone().ToString(),
                                 this.Label?.Clone().ToString(),
                                 this.Type?.Clone().ToString(),
                                 fieldType,
                                 this.FormField?.Clone().ToString(),
                                 this.DisplayOrder);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="FormField" />.
        /// </summary>
        /// <param name="formField">The new <see cref="FormField" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetAllCompanyPropertiesResponse" /> using the specified <paramref name="formField" /> for <see cref="FormField" /> and a deep clone of every other property.</returns>
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
        public GetAllCompanyPropertiesResponse DeepCloneWithFormField(string formField)
        {
            var result = new GetAllCompanyPropertiesResponse(
                                 this.Name?.Clone().ToString(),
                                 this.Description?.Clone().ToString(),
                                 this.Label?.Clone().ToString(),
                                 this.Type?.Clone().ToString(),
                                 this.FieldType?.Clone().ToString(),
                                 formField,
                                 this.DisplayOrder);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="DisplayOrder" />.
        /// </summary>
        /// <param name="displayOrder">The new <see cref="DisplayOrder" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetAllCompanyPropertiesResponse" /> using the specified <paramref name="displayOrder" /> for <see cref="DisplayOrder" /> and a deep clone of every other property.</returns>
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
        public GetAllCompanyPropertiesResponse DeepCloneWithDisplayOrder(int displayOrder)
        {
            var result = new GetAllCompanyPropertiesResponse(
                                 this.Name?.Clone().ToString(),
                                 this.Description?.Clone().ToString(),
                                 this.Label?.Clone().ToString(),
                                 this.Type?.Clone().ToString(),
                                 this.FieldType?.Clone().ToString(),
                                 this.FormField?.Clone().ToString(),
                                 displayOrder);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.HubSpot.Domain.GetAllCompanyPropertiesResponse: Name = {this.Name?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Description = {this.Description?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Label = {this.Label?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Type = {this.Type?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, FieldType = {this.FieldType?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, FormField = {this.FormField?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, DisplayOrder = {this.DisplayOrder.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}