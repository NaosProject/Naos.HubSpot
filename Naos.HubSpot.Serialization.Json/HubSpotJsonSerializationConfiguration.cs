// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotJsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Serialization.Json
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Protocol.Serialization.Json;
    using OBeautifulCode.Serialization.Json;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    /// <inheritdoc />
    public class HubSpotJsonSerializationConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters
            => new[]
               {
                   Naos.HubSpot.Domain.ProjectInfo.Namespace,
               };

        /// <inheritdoc />
        protected override IReadOnlyCollection<JsonSerializationConfigurationType> DependentJsonSerializationConfigurationTypes
            => new[]
               {
                   typeof(ProtocolJsonSerializationConfiguration).ToJsonSerializationConfigurationType(),
               };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson =>
            new Type[0]
               .Concat(
                    new[]
                    {
                        typeof(IModel),
                    })
               .Concat(Naos.HubSpot.Domain.ProjectInfo.Assembly.GetPublicEnumTypes())
               .Select(_ => _.ToTypeToRegisterForJson())
               .ToList();
    }
}
