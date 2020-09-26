// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllContactsOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// The operation to get all contacts.
    /// </summary>
    public partial class GetAllContactsOp : ReturningOperationBase<IReadOnlyCollection<Contact>>, IModelViaCodeGen
    {
    }
}
