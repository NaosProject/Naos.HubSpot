// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardCompanyPropertyName.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.Enum.Recipes;

    /// <summary>
    /// Object to describe a company in HubSpot.
    /// </summary>
    public enum StandardCompanyPropertyName
    {
        /// <summary>
        /// The HubSpot ID of the company.
        /// </summary>
        ObjectId,

        /// <summary>
        /// The name of the company.
        /// </summary>
        CompanyName,

        /// <summary>
        /// The custom ID of the company.
        /// </summary>
        CustomId,
    }

    /// <summary>
    /// Extensions to convert the enum property names to strings and back.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public static class StandardCompanyPropertyNameExtensions
#pragma warning restore SA1649 // File name should match first type name
    {
        /// <summary>
        /// Translates an enumeration to the string HubSpot-recognized property name.
        /// </summary>
        /// <param name="propertyNameEnum">The enumeration to be converted to a string.</param>
        /// <returns cref="string">The string representation of the HubSpot recognizable property name.</returns>
        public static string ToCompanyPropertyName(this StandardCompanyPropertyName propertyNameEnum)
        {
            switch (propertyNameEnum)
            {
                case StandardCompanyPropertyName.ObjectId:
                    return HubSpotCompanyPropertyNames.ObjectId;
                case StandardCompanyPropertyName.CompanyName:
                    return HubSpotCompanyPropertyNames.CompanyName;
                case StandardCompanyPropertyName.CustomId:
                    return HubSpotCompanyPropertyNames.CustomId;
                default:
                    throw new NotSupportedException("The standard company property name is not supported: " + propertyNameEnum);
            }
        }

        /// <summary>
        /// Translates string value into an enumerated value.
        /// </summary>
        /// <param name="propertyName">The string property name.</param>
        /// <returns cref="StandardCompanyPropertyName">The enumeration value that corresponds to the company property name.</returns>
        public static StandardCompanyPropertyName FromCompanyPropertyName(this string propertyName)
        {
            switch (propertyName)
            {
                case HubSpotCompanyPropertyNames.ObjectId:
                    return StandardCompanyPropertyName.ObjectId;
                case HubSpotCompanyPropertyNames.CompanyName:
                    return StandardCompanyPropertyName.CompanyName;
                case HubSpotCompanyPropertyNames.CustomId:
                    return StandardCompanyPropertyName.CustomId;
                default:
                    throw new NotSupportedException("The standard company property name is not supported: " + propertyName);
            }
        }
    }

    /// <summary>
    /// Represents the HubSpot-readable names of the company properties.
    /// </summary>
    public static class HubSpotCompanyPropertyNames
    {
        /// <summary>
        /// The vid of the company.
        /// </summary>
        public const string ObjectId = "objectId";

        /// <summary>
        /// The name of the company.
        /// </summary>
        public const string CompanyName = "name";

        /// <summary>
        /// The custom ID of the company.
        /// </summary>
        public const string CustomId = "customid";

        /// <summary>
        /// Represents the HubSpot-recognized, natively supported company property names.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyCollection<string> AllNames = new[]
        {
            ObjectId,
            CompanyName,
            CustomId,
        };

        /// <summary>
        /// Converts a string to a specific company property if that property is already defined.
        /// </summary>
        /// <param name="proposedName">The string that is to be converted.</param>
        /// <returns>Converted property name if applicable.</returns>
        public static string ConvertIfStandardCompanyName(this string proposedName)
        {
            var isStandardPropertyName = typeof(StandardCompanyPropertyName).GetDefinedEnumValues()
                .Select(_ => _.ToString())
                .Contains(proposedName);
            var adjustedName = proposedName;
            if (isStandardPropertyName)
            {
                var enumName = (StandardCompanyPropertyName)Enum.Parse(typeof(StandardCompanyPropertyName), proposedName);
                adjustedName = enumName.ToCompanyPropertyName();
            }

            return adjustedName;
        }
    }
}
