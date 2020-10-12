// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.DeleteCompany.cs" company="Naos Project">
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
    using Naos.HubSpot.Domain.Model;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<DeleteCompanyOp, DeleteCompanyResponse>
    {
        /// <inheritdoc />
        public DeleteCompanyResponse Execute(DeleteCompanyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<DeleteCompanyResponse> ExecuteAsync(DeleteCompanyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("companies/v2/companies");
            uri = uri.AppendPathSegment(operation.CompanyId.ToString());
            var result = uri.Delete<DeleteCompanyResponse>();
            return await Task.FromResult(result);
        }
    }
}
