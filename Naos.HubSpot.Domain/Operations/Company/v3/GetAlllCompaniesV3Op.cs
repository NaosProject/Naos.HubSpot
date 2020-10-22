// <copyright file="GetAlllCompaniesV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetAllCompaniesV3Op.
    /// Implements the <see cref="ContactAndCompanyModelV3" />.
    /// </summary>
    /// <seealso cref="ContactAndCompanyModelV3" />
    public partial class GetAllCompaniesV3Op : ReturningOperationBase<IReadOnlyCollection<ContactAndCompanyModelV3>>, IModelViaCodeGen
    {
    }
}
