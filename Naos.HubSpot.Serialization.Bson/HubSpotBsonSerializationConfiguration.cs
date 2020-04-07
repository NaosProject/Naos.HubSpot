// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotBsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Serialization.Bson
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Serialization.Bson;

    /// <inheritdoc />
    public class HubSpotBsonSerializationConfiguration : BsonConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<Type> TypesToAutoRegister => new Type[]
        {
            // ADD TYPES TO REGISTER HERE
        };
    }
}
