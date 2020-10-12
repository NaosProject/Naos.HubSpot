﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardContactPropertyName.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
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
}
