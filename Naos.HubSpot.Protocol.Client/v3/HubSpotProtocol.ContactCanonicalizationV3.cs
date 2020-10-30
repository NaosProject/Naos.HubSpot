// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.ContactCanonicalizationV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Collections.Generic;
    using System.Linq;
    using Naos.CodeAnalysis.Recipes;
    using Naos.HubSpot.Domain;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol
    {
        /// <summary>
        ///     All natively included property names;.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<StandardContactPropertyNameV3, string>
            StandardContactPropertyNameToHubSpotContactPropertyNameMapV3 =
                new Dictionary<StandardContactPropertyNameV3, string>
                {
                    { StandardContactPropertyNameV3.HubSpotId, "id" },
                    { StandardContactPropertyNameV3.FirstName, "firstname" },
                    { StandardContactPropertyNameV3.LastName, "lastname" },
                    { StandardContactPropertyNameV3.Email, "email" },
                    { StandardContactPropertyNameV3.CompanyName, "company" },
                    { StandardContactPropertyNameV3.PhoneNumber, "phone" },
                    { StandardContactPropertyNameV3.Website, "website   " },
                };

        /// <summary>
        /// Gets the HubSpot standard contact property name string from the HubSpot property name string.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, string>
            StandardContactPropertyNameStringToHubSpotPropertyNameMapV3 =
                StandardContactPropertyNameToHubSpotContactPropertyNameMapV3
                    .ToDictionary(k => k.Key.ToString(), v => v.Value);

        /// <summary>
        /// Gets the HubSpot contact property name string from the HubSpot standard property name string.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, string>
            HubSpotContactPropertyNameToStandardContactPropertyNameStringMapV3 =
                StandardContactPropertyNameToHubSpotContactPropertyNameMapV3
                    .ToDictionary(k => k.Value, v => v.Key.ToString());

        /// <summary>
        /// Gets the HubSpot contact property name string from the HubSpot standard property name enumeration.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, StandardContactPropertyNameV3>
            HubSpotContactPropertyNameToStandardContactPropertyNameMapV3 =
                StandardContactPropertyNameToHubSpotContactPropertyNameMapV3
                    .ToDictionary(k => k.Value, v => v.Key);
    }

    /// <summary>
    ///     Class provides extension methods with which to convert enum values to text and from text to enum values.
    /// </summary>
    public static partial class PropertyNameCanonicalizationExtensions
    {
        /// <summary>
        ///     Converts an name to a string containing the name of the property.
        /// </summary>
        /// <param name="propertyNameFromModel">The contact property name.</param>
        /// <returns cref="string">The name of the property recognized by HubSpot.</returns>
        public static string ConvertFromContactStandardNameToContactHubSpotNameIfNecessaryV3(
            this string propertyNameFromModel)
        {
            var isStandard =
                HubSpotProtocol.StandardContactPropertyNameStringToHubSpotPropertyNameMap.TryGetValue(
                    propertyNameFromModel,
                    out var standardResult);
            var result = isStandard ? standardResult : propertyNameFromModel;
            return result;
        }

        /// <summary>
        ///     Attempts to convert a string into a contact property name enumeration.
        /// </summary>
        /// <param name="propertyNameFromHubSpot">The name of a property recognized by HubSpot.</param>
        /// <returns cref="StandardContactPropertyName">The enumeration of the contact property name.</returns>
        public static string ConvertFromContactHubSpotNameToContactStandardNameIfNecessaryV3(this string propertyNameFromHubSpot)
        {
            var isStandard =
                HubSpotProtocol.HubSpotContactPropertyNameToStandardContactPropertyNameStringMap.TryGetValue(
                    propertyNameFromHubSpot,
                    out var standardResult);
            var result = isStandard ? standardResult : propertyNameFromHubSpot;
            return result;
        }
    }
}
