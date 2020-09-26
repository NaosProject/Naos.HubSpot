// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.Constructor.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Threading.Tasks;
    using Naos.CodeAnalysis.Recipes;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<SyncWithHubSpotOp, SyncWithHubSpotResult>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Justification = NaosSuppressBecause.CA_ALL_AgreeWithAssessmentAndNeedsRefactoring)]
        private readonly string customEntityIdMetadataKey;

        private readonly string apiKey;
        private readonly Uri baseUri;

        /// <summary>
        /// Initializes a new instance of the <see cref="HubSpotProtocol"/> class.
        /// </summary>
        /// <param name="customEntityIdMetadataKey">The custom entity identifier metadata key; this will add a piece of meta data with this key name to each entity for custom id tracking.</param>
        /// <param name="baseUri">The base URI of the Hubspot V3 API.</param>
        /// <param name="apiKey">An API key to a HubSpot account.</param>
        public HubSpotProtocol(
            string customEntityIdMetadataKey, Uri baseUri, string apiKey)
        {
            customEntityIdMetadataKey.MustForArg(nameof(customEntityIdMetadataKey)).NotBeNullNorWhiteSpace();
            this.customEntityIdMetadataKey = customEntityIdMetadataKey;
            baseUri.MustForArg(nameof(baseUri)).NotBeNullNorWhiteSpace();
            this.baseUri = baseUri;
            apiKey.MustForArg(nameof(apiKey)).NotBeNullNorWhiteSpace();
            this.apiKey = apiKey;

            baseUri.AppendQueryStringParam("apikey", this.apiKey);
        }
    }
}
