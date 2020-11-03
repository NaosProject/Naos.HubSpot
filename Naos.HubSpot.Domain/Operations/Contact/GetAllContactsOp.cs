// <copyright file="GetAllContactsOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetAllContactsOp.
    /// Implements the <see cref="ReturningOperationBase{ContactModel}" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{ContactModel}" />
    public partial class GetAllContactsOp : ReturningOperationBase<IReadOnlyCollection<Contact>>, IModelViaCodeGen
    {
    }
}
