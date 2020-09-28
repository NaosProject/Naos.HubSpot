// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardContactPropertyName.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System;
    using System.Collections.Generic;
    using Naos.CodeAnalysis.Recipes;

    /// <summary>
    ///     Object to describe a contact in HubSpot.
    /// </summary>
    public enum StandardContactPropertyName
    {
        /// <summary>
        ///     The HubSpot ID of the contact.
        /// </summary>
        HubSpotId,

        /// <summary>
        ///     The first name of the contact.
        /// </summary>
        FirstName,

        /// <summary>
        ///     The last name of the contact
        /// </summary>
        LastName,

        /// <summary>
        ///     The email address of the contact.
        /// </summary>
        EmailAddress,

        /// <summary>
        ///     The custom ID of the contact
        /// </summary>
        CustomId,

        /// <summary>
        ///     The phone number of the contact.
        /// </summary>
        PhoneNumber,
    }

    /// <summary>
    ///     Class provides extension methods with which to convert enum values to text and from text to enum values.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public static class StandardContactPropertyNameExtensions
#pragma warning restore SA1649 // File name should match first type name
    {
        /// <summary>
        ///     Converts an enumeration name to a string containing the name of the property.
        /// </summary>
        /// <param name="propertyNameEnum">The contact property name enumeration.</param>
        /// <returns cref="string">The name of the property recognized by HubSpot.</returns>
        public static string ToContactPropertyName(this StandardContactPropertyName propertyNameEnum)
        {
            switch (propertyNameEnum)
            {
                case StandardContactPropertyName.HubSpotId:
                    return HubSpotContactPropertyNames.Vid;
                case StandardContactPropertyName.FirstName:
                    return HubSpotContactPropertyNames.FirstName;
                case StandardContactPropertyName.LastName:
                    return HubSpotContactPropertyNames.LastName;
                case StandardContactPropertyName.EmailAddress:
                    return HubSpotContactPropertyNames.EmailAddress;
                case StandardContactPropertyName.CustomId:
                    return HubSpotContactPropertyNames.CustomId;
                case StandardContactPropertyName.PhoneNumber:
                    return HubSpotContactPropertyNames.PhoneNumber;
                default:
                    throw new NotSupportedException("The standard contact property name is not supported: " +
                                                    propertyNameEnum);
            }
        }

        /// <summary>
        ///     Attempts to convert a string into a contact property name enumeration.
        /// </summary>
        /// <param name="propertyName">The name of a property recognized by HubSpot.</param>
        /// <returns cref="StandardContactPropertyName">The enumeration of the contact property name.</returns>
        public static StandardContactPropertyName FromContactPropertyName(this string propertyName)
        {
            switch (propertyName)
            {
                case HubSpotContactPropertyNames.Vid:
                    return StandardContactPropertyName.HubSpotId;
                case HubSpotContactPropertyNames.FirstName:
                    return StandardContactPropertyName.FirstName;
                case HubSpotContactPropertyNames.LastName:
                    return StandardContactPropertyName.LastName;
                case HubSpotContactPropertyNames.EmailAddress:
                    return StandardContactPropertyName.EmailAddress;
                case HubSpotContactPropertyNames.CustomId:
                    return StandardContactPropertyName.CustomId;
                case HubSpotContactPropertyNames.PhoneNumber:
                    return StandardContactPropertyName.PhoneNumber;
                default:
                    throw new NotSupportedException("The standard contact property name is not supported: " +
                                                    propertyName);
            }
        }
    }

    /// <summary>
    ///     Represents the HubSpot-recognized, natively supported contact property names.
    /// </summary>
    public static class HubSpotContactPropertyNames
    {
        /// <summary>
        ///     The vid of the HubSpot contact.
        /// </summary>
        public const string Vid = "vid";

        /// <summary>
        ///     The first name of the HubSpot contact.
        /// </summary>
        public const string FirstName = "firstname";

        /// <summary>
        ///     The last name of the HubSpot contact.
        /// </summary>
        public const string LastName = "lastname";

        /// <summary>
        ///     The email address of the HubSpot contact.
        /// </summary>
        public const string EmailAddress = "email";

        /// <summary>
        ///     The customId of the HubSpot contact.
        /// </summary>
        public const string CustomId = "customid";

        /// <summary>
        ///     The phone number of the HubSpot contact.
        /// </summary>
        public const string PhoneNumber = "phone";

        /// <summary>
        ///     All natively included property names;.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = NaosSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyCollection<string> AllNames = new[]
        {
            Vid,
            FirstName,
            LastName,
            EmailAddress,
            CustomId,
            PhoneNumber,
        };
    }
}