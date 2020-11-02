// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.Constructor.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Serialization.Json;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<SyncWithHubSpotOp, SyncWithHubSpotResult>
    {
        private readonly Uri baseUri;
        private readonly ObcJsonSerializer bodySerializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="HubSpotProtocol"/> class.
        /// </summary>
        /// <param name="baseUri">The base URI of the Hubspot V3 API.</param>
        /// <param name="apiKey">An API key to a HubSpot account.</param>
        public HubSpotProtocol(Uri baseUri, string apiKey)
        {
            baseUri.MustForArg(nameof(baseUri)).NotBeNull();
            this.baseUri = baseUri;
            apiKey.MustForArg(nameof(apiKey)).NotBeNullNorWhiteSpace();
            this.baseUri = baseUri.AppendQueryStringParam("hapikey", apiKey);
            this.bodySerializer = new ObcJsonSerializer(typeof(MinimalFormatJsonSerializationConfiguration<NullJsonSerializationConfiguration>).ToJsonSerializationConfigurationType());
        }
    }
}
