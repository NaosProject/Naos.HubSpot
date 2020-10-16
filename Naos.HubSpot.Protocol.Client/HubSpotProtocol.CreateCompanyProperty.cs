// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.CreateCompanyProperty.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<CreateCompanyPropertyOp, GetAllCompanyPropertiesResponse>
    {
        /// <inheritdoc />
        public GetAllCompanyPropertiesResponse Execute(CreateCompanyPropertyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<GetAllCompanyPropertiesResponse> ExecuteAsync(CreateCompanyPropertyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("properties/v1/companies/properties");
            var properties = uri.WithBody(operation.Request)
                .Post<GetAllCompanyPropertiesResponse>();
            return await Task.FromResult(properties);
        }
    }
}
