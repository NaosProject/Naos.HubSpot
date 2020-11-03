// <copyright file="HubSpotProtocol.CreateCompany.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<CreateCompanyOp, Company>
    {
        /// <inheritdoc />
        public Company Execute(CreateCompanyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<Company> ExecuteAsync(CreateCompanyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/companies");
            var result = uri.WithBody(operation.CompanyToCreate.ToCompanyRequestModel()).WithSerializer(this.bodySerializer).Post<CompanyModel>();
            var companyToReturn = result.ToCompany();
            return await Task.FromResult(companyToReturn);
        }
    }
}
