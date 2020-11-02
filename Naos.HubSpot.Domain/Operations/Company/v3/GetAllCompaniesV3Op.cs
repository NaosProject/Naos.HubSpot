// <copyright file="GetAllCompaniesV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Gets all companies from HubSpot.
    /// Implements the <see cref="IModelViaCodeGen" />.
    /// </summary>
    public partial class GetAllCompaniesV3Op : ReturningOperationBase<IReadOnlyCollection<CompanyV3>>, IModelViaCodeGen
    {
    }
}
