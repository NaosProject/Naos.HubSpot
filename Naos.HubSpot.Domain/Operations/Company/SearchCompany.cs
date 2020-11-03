// <copyright file="SearchCompany.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class SearchCompany.
    /// Implements the <see cref="CompanyModel" />.
    /// </summary>
    /// <seealso cref="CompanyModel" />
    public partial class SearchCompany : ReturningOperationBase<IReadOnlyCollection<CompanyModel>>, IModelViaCodeGen
    {
    }
}
