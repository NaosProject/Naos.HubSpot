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
    using System.Runtime.InteropServices;
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
            StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMap =
                new Dictionary<StandardCompanyPropertyName, string>
                {
                    { StandardCompanyPropertyName.CompanyName, "name" },
                    { StandardCompanyPropertyName.HubSpotId, "id" },
                    { StandardCompanyPropertyName.Domain, "domain" },
                    { StandardCompanyPropertyName.Industry, "industry" },
                    { StandardCompanyPropertyName.PhoneNumber, "phone" },
                    { StandardCompanyPropertyName.City, "city" },
                    { StandardCompanyPropertyName.State, "state" },
                    { StandardCompanyPropertyName.Website, "website" },
                };

        /// <summary>
        /// Gets the HubSpot standard company property name string from the HubSpot property name string.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Security",
            "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes",
            Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, string>
            StandardCompanyPropertyNameStringToHubSpotPropertyNameMap =
                StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMap
                    .ToDictionary(k => k.Key.ToString(), v => v.Value);

        /// <summary>
        /// Gets the HubSpot company property name string from the HubSpot standard property name string.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Security",
            "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes",
            Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, string>
            HubSpotCompanyPropertyNameToStandardCompanyPropertyNameStringMap =
                StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMap
                    .ToDictionary(k => k.Value, v => v.Key.ToString());

        /// <summary>
        /// Gets the HubSpot company property name string from the HubSpot standard property name enumeration.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Security",
            "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes",
            Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<string, StandardCompanyPropertyName>
            HubSpotCompanyPropertyNameToStandardCompanyPropertyNameMap =
                StandardCompanyPropertyNameToHubSpotCompanyPropertyNameMap
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
        public static string ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(
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
        public static string ConvertFromCompanyHubSpotHubSpotNameToCompanyStandardNameIfNecessary(
            this string propertyNameFromHubSpot)
        {
            var isStandard =
                HubSpotProtocol.HubSpotCompanyPropertyNameToStandardCompanyPropertyNameStringMap.TryGetValue(
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
        public static Company ToCompany(this CompanyModel model)
        {
            var props = model.Properties
                .Where(_ => _.Key != StandardCompanyPropertyName.HubSpotId.ToString() &&
                            _.Key != StandardCompanyPropertyName.HubSpotId.ToString().ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary())
                .ToDictionary(k => k.Key.ConvertFromCompanyHubSpotHubSpotNameToCompanyStandardNameIfNecessary(), v => v.Value);
            props.Add(StandardCompanyPropertyName.HubSpotId.ToString(), model.Id);
            return new Company(props);
        }

        /// <summary>
        /// Converts to company request model for .
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns>CompanyRequestModel.</returns>
        public static CompanyRequestModel ToCompanyRequestModel(this Company company)
        {
            var hasId = company.Properties.TryGetValue(StandardCompanyPropertyName.HubSpotId.ToString(), out var id);
            if (hasId && string.IsNullOrWhiteSpace(id))
            {
                id = null;
            }

            var filteredProps = company.Properties
                .Where(_ => _.Key != StandardCompanyPropertyName.HubSpotId.ToString() &&
                            _.Key != StandardCompanyPropertyName.HubSpotId.ToString().ConvertFromCompanyHubSpotHubSpotNameToCompanyStandardNameIfNecessary() &&
                            _.Key != "hs_lastmodifieddate" &&
                            _.Key != "hs_object_id" &&
                            _.Key != "createdate");
            var props = new Dictionary<string, string>();
            foreach (var prop in filteredProps)
            {
                props.Add(prop.Key.ConvertFromCompanyStandardNameToCompanyHubSpotNameIfNecessary(), prop.Value);
            }

            var companyRequestToReturn = new CompanyRequestModel(id, props);
            return companyRequestToReturn;
        }

        /// <summary>
        /// Converts to PropModel.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>PropModel.</returns>
        public static PropModel ToProperty(this PropertyModel model)
        {
            return new PropModel(model.Name);
        }

        /// <summary>
        /// Converts to Company Property Model.
        /// </summary>
        /// <param name="propName">Name of the property.</param>
        /// <returns>PropertyModel.</returns>
        public static PropertyModel ToCompanyPropertyModel(this string propName)
        {
            var propModel = new PropertyModel(
                "companyinformation",
                false,
                propName,
                -1,
                propName,
                "string",
                false,
                "text",
                false,
                new ModificationMetadataModel(
                    false,
                    false,
                    false,
                    true), null);
            return propModel;
        }
    }
}
