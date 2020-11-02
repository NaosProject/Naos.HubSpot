// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetSingleCompanyV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetSingleCompanyByHubSpotIdV3Op, CompanyV3>
    {
        /// <inheritdoc />
        public CompanyV3 Execute(GetSingleCompanyByHubSpotIdV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<CompanyV3> ExecuteAsync(GetSingleCompanyByHubSpotIdV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/contacts");
            uri = uri.AppendPathSegment(operation.HubSpotId);
            var result = uri.Get<CompanyModelV3>();
            var companyToReturn = result.ToCompanyV3();
            return await Task.FromResult(companyToReturn);
        }
    }
}
