// <copyright file="DeleteContactResponse.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Model
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the return of a delete contact request to HubSpot.
    /// </summary>
    public partial class DeleteContactResponse : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteContactResponse"/> class.
        /// </summary>
        /// <param name="vid">The HubSpot ID of the contact that was supposed to be deleted.</param>
        /// <param name="deleted">Was contact was delete.</param>
        /// <param name="reason">The reason for the deleted status.  OK means the contact was deleted.</param>
        public DeleteContactResponse(int vid, bool deleted, string reason)
        {
            this.Vid = vid;
            this.Deleted = deleted;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets the HubSpot ID of the contact that was supposed to be deleted.
        /// </summary>
        public int Vid { get; private set; }

        /// <summary>
        /// Gets a value indicating whether whether or not the contact was deleted.
        /// </summary>
        public bool Deleted { get; private set; }

        /// <summary>
        /// Gets the reason that the contact was or was not deleted.
        /// </summary>
        public string Reason { get; private set; }
    }
}
