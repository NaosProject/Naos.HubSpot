// <copyright file="PagingModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Class PagingModel.
    /// </summary>
    public partial class PagingModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagingModel"/> class.
        /// </summary>
        /// <param name="prev">The previous.</param>
        /// <param name="next">The next.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "prev", Justification = "Naming controlled by external api")]
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Prev", Justification = "Naming controlled by external api")]
        public PrevModel Prev { get; private set; }
    }
}