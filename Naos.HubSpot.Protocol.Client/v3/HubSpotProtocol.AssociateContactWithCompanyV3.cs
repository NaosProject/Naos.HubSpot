// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.AssociateContactWithCompanyV3.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<AssociateContactWithCompanyV3Op, AssociationResultV3>
    {
        /// <inheritdoc />
        public AssociationResultV3 Execute(AssociateContactWithCompanyV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<AssociationResultV3> ExecuteAsync(AssociateContactWithCompanyV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/contacts");
            uri = uri.AppendPathSegment(operation.ContactId);
            uri = uri.AppendPathSegment("associations");
            uri = uri.AppendPathSegment(operation.CompanyId);
            uri = uri.AppendPathSegment("contact_to_company");
            var result = uri.Put<AssociationResultV3>();
            return await Task.FromResult(result);
        }
    }
}