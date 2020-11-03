// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetSingleCompany.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetSingleCompanyByHubSpotIdOp, Company>
    {
        /// <inheritdoc />
        public Company Execute(GetSingleCompanyByHubSpotIdOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<Company> ExecuteAsync(GetSingleCompanyByHubSpotIdOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/contacts");
            uri = uri.AppendPathSegment(operation.HubSpotId);
            var result = uri.Get<CompanyModel>();
            var companyToReturn = result.ToCompanyV3();
            return await Task.FromResult(companyToReturn);
        }
    }
}
