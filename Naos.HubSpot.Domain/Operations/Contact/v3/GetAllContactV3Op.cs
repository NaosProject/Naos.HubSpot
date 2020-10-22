// <copyright file="GetAllContactV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetAllContactsV3Op.
    /// Implements the <see cref="ReturningOperationBase{ContactAndCompanyModelV3}" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{ContactAndCompanyModelV3}" />
    public partial class GetAllContactsV3Op : ReturningOperationBase<IReadOnlyCollection<ContactAndCompanyModelV3>>, IModelViaCodeGen
    {
    }
}
