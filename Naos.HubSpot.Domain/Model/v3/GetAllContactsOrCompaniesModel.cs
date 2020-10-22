// <copyright file="GetAllContactsOrCompaniesModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// Class GetAllContactsOrCompaniesModel.
    /// </summary>
    public class GetAllContactsOrCompaniesModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllContactsOrCompaniesModel"/> class.
        /// </summary>
        /// <param name="results">The results.</param>
        /// <param name="paging">The paging.</param>
        public GetAllContactsOrCompaniesModel(IReadOnlyCollection<ContactAndCompanyModelV3> results, PagingModel paging)
        {
            this.Results = results;
            this.Paging = paging;
        }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <value>The results.</value>
        public IReadOnlyCollection<ContactAndCompanyModelV3> Results { get; private set; }

        /// <summary>
        /// Gets the paging.
        /// </summary>
        /// <value>The paging.</value>
        public PagingModel Paging { get; private set; }
    }

    /// <summary>
    /// Class PagingModel.
    /// </summary>
    public class PagingModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagingModel"/> class.
        /// </summary>
        /// <param name="prev">The previous.</param>
        /// <param name="next">The next.</param>
        public PagingModel(PrevModel prev, NextModel next)
        {
            this.Prev = prev;
            this.Next = next;
        }

        /// <summary>
        /// Gets the next.
        /// </summary>
        /// <value>The next.</value>
        public NextModel Next { get; private set; }

        /// <summary>
        /// Gets the previous.
        /// </summary>
        /// <value>The previous.</value>
        public PrevModel Prev { get; private set; }
    }

    /// <summary>
    /// Class NextModel.
    /// </summary>
    public class NextModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NextModel"/> class.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <param name="after">The type.</param>
        public NextModel(string link, string after)
        {
            this.Link = link;
            this.After = after;
        }

        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        public string Link { get; private set; }

        /// <summary>
        /// Gets the after.
        /// </summary>
        /// <value>The after.</value>
        public string After { get; private set; }
    }

    /// <summary>
    /// Class PrevModel.
    /// </summary>
    public class PrevModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrevModel"/> class.
        /// </summary>
        /// <param name="before">The before.</param>
        /// <param name="link">The link.</param>
        public PrevModel(string before, string link)
        {
            this.Before = before;
            this.Link = link;
        }

        /// <summary>
        /// Gets the before.
        /// </summary>
        /// <value>The before.</value>
        public string Before { get; private set; }

        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        public string Link { get; private set; }
    }
}
