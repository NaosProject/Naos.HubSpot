// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllCompaniesV3.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetAllCompaniesV3Op, IReadOnlyCollection<ContactAndCompanyModelV3>>
    {
        /// <inheritdoc />
        public IReadOnlyCollection<ContactAndCompanyModelV3> Execute(GetAllCompaniesV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyCollection<ContactAndCompanyModelV3>> ExecuteAsync(GetAllCompaniesV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("/crm/v3/objects/companies");
            uri = uri.AppendQueryStringParam("limit", "100");
            uri = uri.AppendQueryStringParam("paginateAssociations", false.ToString());
            uri = uri.AppendQueryStringParam("archived", false.ToString());
            bool hasMore = true;
            string skip = string.Empty;
            var results = new List<ContactAndCompanyModelV3>();
            while (hasMore)
            {
                var reqUri = uri;
                if (!string.IsNullOrEmpty(skip))
                {
                    reqUri = reqUri.AppendQueryStringParam("after", skip);
                }

                var result = reqUri.Get<GetAllContactsOrCompaniesModel>();
                if (!string.IsNullOrWhiteSpace(result.Paging.Next.After))
                {
                    skip = result.Paging.Next.After;
                }
                else
                {
                    hasMore = false;
                }

                results.AddRange(result.Results);
            }

            return await Task.FromResult(results);
        }
    }
}
