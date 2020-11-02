// <copyright file="PrevModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Class PrevModel.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Prev", Justification = "Naming controlled by external ")]
    public partial class PrevModel : IModelViaCodeGen
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