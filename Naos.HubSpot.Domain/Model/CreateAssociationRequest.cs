// <copyright file="CreateAssociationRequest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// This class represents the response from the HubSpot API after a successful Association.
    /// </summary>
    public partial class CreateAssociationRequest : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssociationRequest"/> class.
        /// </summary>
        /// <param name="fromObjectId">The HubSpot ID of the client that is being associated.</param>
        /// <param name="toObjectId">The HubSpot ID of the company to which the client is being associated.</param>
        /// <param name="category">The category field currently only supports one value which is supplied by HubSpot.</param>
        /// <param name="definitionId">The ID of the definition of the of the association type.</param>
        public CreateAssociationRequest(int fromObjectId, int toObjectId, string category, int definitionId)
        {
            this.FromObjectId = fromObjectId;
            this.ToObjectId = toObjectId;
            this.DefinitionId = definitionId;
            this.Category = category;
        }

        /// <summary>
        /// Gets the HubSpot ID of the client that is the subject of the association.
        /// </summary>
        public int FromObjectId { get; private set; }

        /// <summary>
        /// Gets the HubSpot ID of the company to which the client has been associated.
        /// </summary>
        public int  ToObjectId { get; private set; }

        /// <summary>
        /// Gets the category currently only supports one value.
        /// </summary>
        public string Category { get; private set; }

        /// <summary>
        /// Gets the definition of the type of association that was performed.
        /// </summary>
        public int DefinitionId { get; private set; }
    }
}
