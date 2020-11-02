// <copyright file="GetAllContactsV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetAllContactsV3Op.
    /// Implements the <see cref="ReturningOperationBase{ContactModelV3}" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{ContactModelV3}" />
    public partial class GetAllContactsV3Op : ReturningOperationBase<IReadOnlyCollection<ContactV3>>, IModelViaCodeGen
    {
    }
}
