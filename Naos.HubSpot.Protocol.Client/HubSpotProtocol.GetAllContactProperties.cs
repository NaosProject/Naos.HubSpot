// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotProtocol.GetAllContactProperties.cs" company="Naos Project">
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

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class HubSpotProtocol : ISyncAndAsyncReturningProtocol<GetAllContactPropertiesOp, IReadOnlyCollection<ContactPropertyModel>>
    {
        /// <inheritdoc />
        public IReadOnlyCollection<ContactPropertyModel> Execute(GetAllContactPropertiesOp operation)
        {
            var task = this.ExecuteAsync(operation);
            var result = Run.TaskUntilCompletion(task);
            return result;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyCollection<ContactPropertyModel>> ExecuteAsync(GetAllContactPropertiesOp operation)
        {
            var uri = this.baseUri;
            uri = uri.AppendPathSegment("properties/v1/contacts/properties");
            var properties = uri.Get<ContactPropertyModel[]>();
            return await Task.FromResult(properties);
        }
    }
}
