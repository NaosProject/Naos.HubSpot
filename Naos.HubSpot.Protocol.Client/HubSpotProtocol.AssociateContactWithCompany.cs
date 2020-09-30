// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.AssociateContactWithCompany.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
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
    public partial class HubSpotProtocol : ISyncAndAsyncVoidProtocol<AssociateContactWithCompanyOp>
    {
        /// <inheritdoc />
        public void Execute(AssociateContactWithCompanyOp operation)
        {
            var task = this.ExecuteAsync(operation);
            Run.TaskUntilCompletion(task);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(AssociateContactWithCompanyOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("crm-associations/v1/associations");
            uri.WithBody(operation.CreateRequest()).Put();
            await Task.Run(() => true);
        }
    }
}
