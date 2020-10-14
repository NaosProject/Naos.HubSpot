// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllCompanyProperties.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetAllCompanyPropertiesOp, IReadOnlyCollection<GetAllCompanyPropertiesResponse>>
    {
        /// <inheritdoc />
        public IReadOnlyCollection<GetAllCompanyPropertiesResponse> Execute(GetAllCompanyPropertiesOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyCollection<GetAllCompanyPropertiesResponse>> ExecuteAsync(GetAllCompanyPropertiesOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("properties/v1/companies/properties");
            var properties = uri.Get<GetAllCompanyPropertiesResponse[]>();
            return await Task.FromResult(properties);
        }
    }
}
