// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllContactsOnlyInHubSpotOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    ///     The operation to get all contacts.
    /// </summary>
    public class GetAllContactsOnlyInHubSpotOp : ReturningOperationBase<IReadOnlyCollection<Contact>>, IModelViaCodeGen
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetAllContactsOnlyInHubSpotOp" /> class.
        /// </summary>
        /// <param name="knownContacts">Contacts that are already known to the application.</param>
        public GetAllContactsOnlyInHubSpotOp(IReadOnlyCollection<Contact> knownContacts)
        {
            this.KnownContacts = knownContacts;
        }

        /// <summary>
        ///     Gets the contacts known to the application.
        /// </summary>
        public IReadOnlyCollection<Contact> KnownContacts { get; }
    }
}