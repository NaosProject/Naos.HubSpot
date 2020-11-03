// <copyright file="GetAllCompaniesModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// Class GetAllContactsOrCompaniesModelV3.
    /// </summary>
    public class GetAllCompaniesModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllCompaniesModel"/> class.
        /// </summary>
        /// <param name="results">The results.</param>
        /// <param name="paging">The paging.</param>
        public GetAllCompaniesModel(IReadOnlyCollection<CompanyModel> results, PagingModel paging)
        {
            this.Results = results;
            this.Paging = paging;
        }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <value>The results.</value>
        public IReadOnlyCollection<CompanyModel> Results { get; private set; }

        /// <summary>
        /// Gets the paging.
        /// </summary>
        /// <value>The paging.</value>
        public PagingModel Paging { get; private set; }
    }
}
