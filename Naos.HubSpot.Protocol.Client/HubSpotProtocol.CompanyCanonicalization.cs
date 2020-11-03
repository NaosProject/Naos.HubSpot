// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.CompanyCanonicalization.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Security",
            "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes",
            Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<StandardCompanyPropertyName, string>
            StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMapV3 =
                new Dictionary<StandardCompanyPropertyName, string>
                {
                    { StandardCompanyPropertyName.CompanyName, "name" },
                    { StandardCompanyPropertyName.HubSpotId, "id" },
                    { StandardCompanyPropertyName.Domain, "domain" },
                    { StandardCompanyPropertyName.Industry, "industry" },
                    { StandardCompanyPropertyName.PhoneNumber, "phone" },
                    { StandardCompanyPropertyName.City, "city" },
                    { StandardCompanyPropertyName.State, "state" },
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
        public static readonly IReadOnlyDictionary<string, StandardCompanyPropertyName>
            HubSpotCompanyPropertyNameToStandardCompanyPropertyNameMapV3 =
                StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMapV3
                    .ToDictionary(k => k.Value, v => v.Key);
    }

    /// <summary>
    ///     Class provides extension methods with which to convert enum values to text and from text to enum values.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Prefer this location.")]
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1204:Static elements should appear before instance elements", Justification = "Prefer this location.")]
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
                HubSpotProtocol.StandardCompanyPropertyNameStringToHubSpotPropertyNameMapV3.TryGetValue(
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
                HubSpotProtocol.HubSpotContactPropertyNameToStandardContactPropertyNameStringMapV3.TryGetValue(
                    propertyNameFromHubSpot,
                    out var standardResult);
            var result = isStandard ? standardResult : propertyNameFromHubSpot;
            return result;
        }

        /// <summary>
        /// Converts to Company.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Company.</returns>
        public static Company ToCompanyV3(this CompanyModel model)
        {
            var props = model.Properties.ToDictionary(k => k.Key.ConvertFromContactHubSpotNameToContactStandardNameIfNecessaryV3(), v => v.Value);
            props.Add(StandardCompanyPropertyName.HubSpotId.ToString(), model.Id);
            return new Company(props);
        }

        /// <summary>
        /// Converts to company request model for v3.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns>CompanyRequestModel.</returns>
        public static CompanyRequestModel ToCompanyRequestModelV3(this Company company)
        {
            var hasId = company.Properties.TryGetValue(StandardCompanyPropertyName.HubSpotId.ToString(), out var id);
            if (hasId && string.IsNullOrWhiteSpace(id))
            {
                id = null;
            }

            var props = company.Properties.Where(_ => _.Key != StandardCompanyPropertyName.HubSpotId.ToString()).ToDictionary(k => k.Key.ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessaryV3(), v => v.Value);
            var companyRequestToReturn = new CompanyRequestModel(id, props);
            return companyRequestToReturn;
        }

        /// <summary>
        /// Converts to PropModel.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>PropModel.</returns>
        public static PropModel ToPropertyV3(this PropertyModel model)
        {
            return new PropModel(model.Name);
        }

        /// <summary>
        /// Converts to ContactPropertyModelV3.
        /// </summary>
        /// <param name="prop">The property.</param>
        /// <returns>PropertyModel.</returns>
        public static PropertyModel ToContactPropertyModelV3(this PropModel prop)
        {
            var propModel = new PropertyModel(
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
        /// <returns>PropertyModel.</returns>
        public static PropertyModel ToCompanyPropertyModelV3(this PropModel prop)
        {
            var propModel = new PropertyModel(
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
