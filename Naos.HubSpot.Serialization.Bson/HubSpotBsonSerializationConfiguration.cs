// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotBsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Serialization.Bson
{
    using System;
    using System.Collections.Generic;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Serialization.Bson;

    /// <inheritdoc />
    public class HubSpotBsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters => new[]
                                                                                               {
                                                                                                   FormattableString.Invariant($"{nameof(Naos)}.{nameof(HubSpot)}.{nameof(Domain)}"),
                                                                                               };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson => new[]
        {
            typeof(Contact).ToTypeToRegisterForBson(),
            typeof(Company).ToTypeToRegisterForBson(),
            typeof(IOperation).ToTypeToRegisterForBson(),
        };
    }
}
