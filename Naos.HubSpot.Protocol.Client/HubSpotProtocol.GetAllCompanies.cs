// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllCompanies.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;
    using OBeautifulCode.Serialization.Json;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetAllCompaniesOp, IReadOnlyCollection<Company>>
    {
        /// <inheritdoc />
        public IReadOnlyCollection<Company> Execute(GetAllCompaniesOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyCollection<Company>> ExecuteAsync(GetAllCompaniesOp operation)
        {
            /*
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("companies/v2/companies/paged")
                .AppendQueryStringParam("limit", "250");
            var companies = new List<Company>();
            var hasMore = true;
            while (hasMore)
            {
                //var batchUri = uri.app
            }

            return await Task.FromResult(companies);
            */
            await Task.FromResult(new List<Company>());
            throw new NotImplementedException();
        }
    }
}
