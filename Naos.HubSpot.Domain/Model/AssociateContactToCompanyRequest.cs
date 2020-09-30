// <copyright file="AssociateContactToCompanyRequest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Model
{
    using OBeautifulCode.Type;

    /// <summary>
    /// This class represents the response from the HubSpot API after a successful Association.
    /// </summary>
    public class AssociateContactToCompanyRequest : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociateContactToCompanyRequest"/> class.
        /// </summary>
        /// <param name="fromObjectId">The HubSpot ID of the client that is being associated.</param>
        /// <param name="toObjectId">The HubSpot ID of the company to which the client is being associated.</param>
        /// <param name="category">The category field currently only supports one value which is supplied by HubSpot.</param>
        /// <param name="definitionId">The ID of the definition of the of the association type.</param>
        public AssociateContactToCompanyRequest(int fromObjectId, int toObjectId, string category, int definitionId)
        {
            this.FromObjectId = fromObjectId;
            this.ToObjectId = toObjectId;
            this.DefinitionId = definitionId;
            this.Category = category;
        }

        /// <summary>
        /// Gets or sets the HubSpot ID of the client that is the subject of the association.
        /// </summary>
        public int FromObjectId { get; set; }

        /// <summary>
        /// Gets or sets the HubSpot ID of the company to which the client has been associated.
        /// </summary>
        public int  ToObjectId { get; set; }

        /// <summary>
        /// Gets or sets the category currently only supports one value.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the definition of the type of association that was performed.
        /// </summary>
        public int DefinitionId { get; set; }
    }
}
