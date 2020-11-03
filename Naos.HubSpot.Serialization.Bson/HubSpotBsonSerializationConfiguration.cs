// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotBsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Serialization.Bson
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Protocol.Serialization.Bson;
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    /// <inheritdoc />
    public class HubSpotBsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters
            => new[]
               {
                   Naos.HubSpot.Domain.ProjectInfo.Namespace,
               };

        /// <inheritdoc />
        protected override IReadOnlyCollection<BsonSerializationConfigurationType> DependentBsonSerializationConfigurationTypes
            => new[]
               {
                   typeof(ProtocolBsonSerializationConfiguration).ToBsonSerializationConfigurationType(),
               };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson =>
            new Type[0]
               .Concat(
                    new[]
                    {
                        typeof(IModel),
                    })
               .Concat(Naos.HubSpot.Domain.ProjectInfo.Assembly.GetPublicEnumTypes())
               .Select(_ => _.ToTypeToRegisterForBson())
               .ToList();
    }
}
