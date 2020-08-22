// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotJsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Serialization.Json
{
    using System;
    using System.Collections.Generic;
    using Naos.HubSpot.Domain;
    using OBeautifulCode.Serialization.Json;

    /// <inheritdoc />
    public class HubSpotJsonSerializationConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson => new[]
        {
            typeof(Contact).ToTypeToRegisterForJson(),
        };
    }
}
