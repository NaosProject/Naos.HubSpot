﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SyncContactsWithHubSpotOp.cs" company="Naos Project">
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
    public partial class SyncContactsWithHubSpotOp : ReturningOperationBase<SyncContactsWithHubSpotResult>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncContactsWithHubSpotOp"/> class.
        /// </summary>
        /// <param name="contacts">The contacts.</param>
        public SyncContactsWithHubSpotOp(IReadOnlyCollection<Contact> contacts)
        {
            contacts.MustForArg(nameof(contacts)).NotBeNull();
            throw new System.NotImplementedException();
        }
    }
}