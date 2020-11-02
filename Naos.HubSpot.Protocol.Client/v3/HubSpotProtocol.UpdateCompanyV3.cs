// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.UpdateCompanyV3.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<UpdateCompanyV3Op, CompanyV3>
    {
        /// <inheritdoc />
        public CompanyV3 Execute(UpdateCompanyV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<CompanyV3> ExecuteAsync(UpdateCompanyV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/contacts");
            var companyToUpdate = operation.CompanyToUpdate.ToCompanyRequestModelV3();
            uri = uri.AppendPathSegment(companyToUpdate.Id);
            var result = uri.WithBody(companyToUpdate.Properties).Put<CompanyModelV3>();
            var companyToReturn = result.ToCompanyV3();
            return await Task.FromResult(companyToReturn);
        }
    }
}
