// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllContact.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetAllContactsOp, IReadOnlyCollection<Contact>>
    {
        /// <inheritdoc />
        public IReadOnlyCollection<Contact> Execute(GetAllContactsOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyCollection<Contact>> ExecuteAsync(GetAllContactsOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("/crm/v3/objects/contacts");
            uri = uri.AppendQueryStringParam("limit", "100");
            uri = uri.AppendQueryStringParam("paginateAssociations", false.ToString());
            uri = uri.AppendQueryStringParam("archived", false.ToString());
            bool hasMore = true;
            string skip = string.Empty;
            var results = new List<Contact>();
            while (hasMore)
            {
                var reqUri = uri;
                if (!string.IsNullOrEmpty(skip))
                {
                    reqUri = reqUri.AppendQueryStringParam("after", skip);
                }

                var result = reqUri.Get<GetAllContactsModel>();
                if (!string.IsNullOrWhiteSpace(result.Paging.Next.After))
                {
                    skip = result.Paging.Next.After;
                }
                else
                {
                    hasMore = false;
                }

                var runList = result.Results.Select(_ => _.ToContactV3());
                results.AddRange(runList);
            }

            return await Task.FromResult(results);
        }
    }
}
