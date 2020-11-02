// <copyright file="NextModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Class NextModel.
    /// </summary>
    public partial class NextModel : IModelViaCodeGen
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
}