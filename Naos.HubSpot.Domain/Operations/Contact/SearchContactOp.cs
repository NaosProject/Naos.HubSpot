// <copyright file="SearchContactOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class SearchContactOp.
    /// Implements the <see cref="IReadOnlyCollection{Contact}" />.
    /// </summary>
    /// <seealso cref="ContactModel" />
    public partial class SearchContactOp : ReturningOperationBase<IReadOnlyCollection<Contact>>, IModelViaCodeGen
    {
    }
}
