// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.CompanyCanonicalizationV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Security",
            "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes",
            Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<StandardCompanyPropertyNameV3, string>
            StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMapV3 =
                new Dictionary<StandardCompanyPropertyNameV3, string>
                {
                    { StandardCompanyPropertyNameV3.CompanyName, "name" },
                    { StandardCompanyPropertyNameV3.HubSpotId, "id" },
                    { StandardCompanyPropertyNameV3.Domain, "domain" },
                    { StandardCompanyPropertyNameV3.Industry, "industry" },
                    { StandardCompanyPropertyNameV3.PhoneNumber, "phone" },
                    { StandardCompanyPropertyNameV3.City, "city" },
                    { StandardCompanyPropertyNameV3.State, "state" },
                };

        /// <summary>
        /// Gets the HubSpot standard company property name string from the HubSpot property name string.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Security",
            "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes",
            Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, string>
            StandardCompanyPropertyNameStringToHubSpotPropertyNameMapV3 =
                StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMapV3
                    .ToDictionary(k => k.Key.ToString(), v => v.Value);

        /// <summary>
        /// Gets the HubSpot company property name string from the HubSpot standard property name string.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Security",
            "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes",
            Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, string>
            HubSpotCompanyPropertyNameToStandardCompanyPropertyNameStringMapV3 =
                StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMapV3
                    .ToDictionary(k => k.Value, v => v.Key.ToString());

        /// <summary>
        /// Gets the HubSpot company property name string from the HubSpot standard property name enumeration.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Security",
            "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes",
            Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, StandardCompanyPropertyNameV3>
            HubSpotCompanyPropertyNameToStandardCompanyPropertyNameMapV3 =
                StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMapV3
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
        public static string ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessaryV3(
            this string propertyNameFromModel)
        {
            var isStandard =
                HubSpotProtocol.StandardCompanyPropertyNameStringToHubSpotPropertyNameMap.TryGetValue(
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
        public static string ConvertFromCompanyHubSpotHubSpotNameToCompanyStandardNameIfNecessaryV3(
            this string propertyNameFromHubSpot)
        {
            var isStandard =
                HubSpotProtocol.HubSpotContactPropertyNameToStandardContactPropertyNameStringMap.TryGetValue(
                    propertyNameFromHubSpot,
                    out var standardResult);
            var result = isStandard ? standardResult : propertyNameFromHubSpot;
            return result;
        }

        /// <summary>
        /// Converts to CompanyV3.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>CompanyV3.</returns>
        public static CompanyV3 ToCompanyV3(this CompanyModelV3 model)
        {
            var props = model.Properties.ToDictionary(k => k.Key.ConvertFromContactHubSpotNameToContactStandardNameIfNecessaryV3(), v => v.Value);
            props.Add(StandardCompanyPropertyNameV3.HubSpotId.ToString(), model.Id);
            return new CompanyV3(props);
        }

        /// <summary>
        /// Converts to companyrequestmodelv3.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns>CompanyRequestModelV3.</returns>
        public static CompanyRequestModelV3 ToCompanyRequestModelV3(this CompanyV3 company)
        {
            string id;
            if (!company.Properties.TryGetValue(StandardCompanyPropertyNameV3.HubSpotId.ToString(), out id) ||
                id == string.Empty)
            {
                id = null;
            }

            var props = company.Properties.Where(_ => _.Key != StandardCompanyPropertyNameV3.HubSpotId.ToString()).ToDictionary(k => k.Key.ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessaryV3(), v => v.Value);
            var companyRequestToReturn = new CompanyRequestModelV3(id, props);
            return companyRequestToReturn;
        }

        /// <summary>
        /// Converts to PropertyV3.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>PropertyV3.</returns>
        public static PropertyV3 ToPropertyV3(this PropertyModelV3 model)
        {
            return new PropertyV3(model.Name);
        }

        /// <summary>
        /// Converts to ContactPropertyModelV3.
        /// </summary>
        /// <param name="prop">The property.</param>
        /// <returns>PropertyModelV3.</returns>
        public static PropertyModelV3 ToContactPropertyModelV3(this PropertyV3 prop)
        {
            var propModel = new PropertyModelV3(
                "contactinformation",
                false,
                new ModificationMetadataModel(
                    false,
                    false,
                    false,
                    true),
                prop.PropertyName,
                -1,
                null,
                prop.PropertyName,
                "string",
                false,
                "text",
                false);
            return propModel;
        }

        /// <summary>
        /// Converts to CompanyPropertyModelV3.
        /// </summary>
        /// <param name="prop">The property.</param>
        /// <returns>PropertyModelV3.</returns>
        public static PropertyModelV3 ToCompanyPropertyModelV3(this PropertyV3 prop)
        {
            var propModel = new PropertyModelV3(
                "companyinformation",
                false,
                new ModificationMetadataModel(
                    false,
                    false,
                    false,
                    true),
                prop.PropertyName,
                -1,
                null,
                prop.PropertyName,
                "string",
                false,
                "text",
                false);
            return propModel;
        }
    }
}
