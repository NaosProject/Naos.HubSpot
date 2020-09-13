// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SyncContactsWithHubspotOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System;
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;
    // TODO: GET GHOSTDOC

    /// <summary>
    /// The parameter object for the OP.
    /// </summary>
    public partial class SyncContactsWithHubspotOp : ReturningOperationBase<SyncContactsWithHubspotResult>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncContactsWithHubspotOp"/> class.
        /// </summary>
        /// <param name="contacts"></param>
        /// <exception cref="NotImplementedException"></exception>
        public SyncContactsWithHubspotOp(IReadOnlyCollection<Contact> contacts)
        {
            throw new System.NotImplementedException();
        }
    }
}
