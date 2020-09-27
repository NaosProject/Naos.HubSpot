// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllContactsOnlyInHubSpot.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain;
    using Naos.Protocol.Domain;
    using Naos.Recipes.RunWithRetry;

    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetAllContactsOnlyInHubSpotOp, IReadOnlyCollection<Contact>>
    {
        /// <inheritdoc />
        public IReadOnlyCollection<Contact> Execute(GetAllContactsOnlyInHubSpotOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyCollection<Contact>> ExecuteAsync(GetAllContactsOnlyInHubSpotOp operation)
        {
            var result = new List<Contact>();
            var allContacts = await this.ExecuteAsync(new GetAllContactsOp());
            // TODO: Logic this.
            return result;
        }
    }
}
