// <copyright file="GetAllCompaniesModelV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// Class GetAllContactsOrCompaniesModelV3.
    /// </summary>
    public class GetAllCompaniesModelV3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllCompaniesModelV3"/> class.
        /// </summary>
        /// <param name="results">The results.</param>
        /// <param name="paging">The paging.</param>
        public GetAllCompaniesModelV3(IReadOnlyCollection<CompanyModelV3> results, PagingModel paging)
        {
            this.Results = results;
            this.Paging = paging;
        }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <value>The results.</value>
        public IReadOnlyCollection<CompanyModelV3> Results { get; private set; }

        /// <summary>
        /// Gets the paging.
        /// </summary>
        /// <value>The paging.</value>
        public PagingModel Paging { get; private set; }
    }
}
