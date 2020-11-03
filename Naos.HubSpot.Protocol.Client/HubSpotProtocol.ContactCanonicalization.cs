// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.ContactCanonicalization.cs" company="Naos Project">
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<StandardContactPropertyName, string>
            StandardContactPropertyNameToHubSpotContactPropertyNameMapV3 =
                new Dictionary<StandardContactPropertyName, string>
                {
                    { StandardContactPropertyName.HubSpotId, "id" },
                    { StandardContactPropertyName.FirstName, "firstname" },
                    { StandardContactPropertyName.LastName, "lastname" },
                    { StandardContactPropertyName.Email, "email" },
                    { StandardContactPropertyName.CompanyName, "company" },
                    { StandardContactPropertyName.PhoneNumber, "phone" },
                    { StandardContactPropertyName.Website, "website" },
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
        public static readonly IReadOnlyDictionary<string, StandardContactPropertyName>
            HubSpotContactPropertyNameToStandardContactPropertyNameMapV3 =
                StandardContactPropertyNameToHubSpotContactPropertyNameMapV3
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
        public static string ConvertFromContactStandardNameToContactHubSpotNameIfNecessaryV3(
            this string propertyNameFromModel)
        {
            var isStandard =
                HubSpotProtocol.StandardContactPropertyNameStringToHubSpotPropertyNameMapV3.TryGetValue(
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
                HubSpotProtocol.HubSpotContactPropertyNameToStandardContactPropertyNameStringMapV3.TryGetValue(
                    propertyNameFromHubSpot,
                    out var standardResult);
            var result = isStandard ? standardResult : propertyNameFromHubSpot;
            return result;
        }

        /// <summary>
        /// Converts to ContactRequestModel.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <returns>ContactRequestModel.</returns>
        public static ContactRequestModel ToContactRequestModel(this Contact contact)
        {
            var hasId = contact.Properties.TryGetValue(StandardContactPropertyName.HubSpotId.ToString(), out var id);
            if (hasId && string.IsNullOrWhiteSpace(id))
            {
                id = null;
            }

            var filteredProperties = contact.Properties
                .Where(_ => _.Key != StandardContactPropertyName.HubSpotId.ToString().ConvertFromContactHubSpotNameToContactStandardNameIfNecessaryV3())
                .ToDictionary(k => k.Key.ConvertFromContactHubSpotNameToContactStandardNameIfNecessaryV3(), v => v.Value);
            return new ContactRequestModel(id, filteredProperties);
        }

        /// <summary>
        /// Converts to Contact.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Contact.</returns>
        public static Contact ToContactV3(this ContactModel model)
        {
            var props = model.Properties.ToDictionary(k => k.Key.ConvertFromContactStandardNameToContactHubSpotNameIfNecessaryV3(), v => v.Value);
            props.Add(StandardContactPropertyName.HubSpotId.ToString(), model.Id);
            return new Contact(props);
        }
    }
}
