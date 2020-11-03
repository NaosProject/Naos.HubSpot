// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.UpdateCompany.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<UpdateCompanyOp, Company>
    {
        /// <inheritdoc />
        public Company Execute(UpdateCompanyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<Company> ExecuteAsync(UpdateCompanyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/companies");
            uri.AppendPathSegment(
                operation.CompanyToUpdate.Properties[StandardCompanyPropertyName.HubSpotId.ToString()]);
            var companyToUpdate = operation.CompanyToUpdate.ToCompanyRequestModel();
            uri = uri.AppendPathSegment(companyToUpdate.Id);
            var result = uri.WithBody(companyToUpdate).CallWithVerb<CompanyModel>("PATCH");
            var companyToReturn = result.ToCompany();
            return await Task.FromResult(companyToReturn);
        }
    }
}
