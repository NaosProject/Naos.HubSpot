// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.UpdateContactV3.cs" company="Naos Project">
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
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<UpdateContactV3Op, ContactAndCompanyModelV3>
    {
        /// <inheritdoc />
        public ContactAndCompanyModelV3 Execute(UpdateContactV3Op operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<ContactAndCompanyModelV3> ExecuteAsync(UpdateContactV3Op operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm/v3/objects/contacts");
            uri = uri.AppendPathSegment(operation.ContactToUpdate.Id);
            var result = uri.WithBody(operation.ContactToUpdate).CallWithVerb<ContactAndCompanyModelV3>("PATCH");
            return await Task.FromResult(result);
        }
    }
}
