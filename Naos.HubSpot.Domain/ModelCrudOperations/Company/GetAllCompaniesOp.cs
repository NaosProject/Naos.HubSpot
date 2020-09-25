// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllCompaniesOp.cs" company="Naos Project">
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
    /// The operation to get all companies.
    /// </summary>
    public partial class GetAllCompaniesOp : ReturningOperationBase<IReadOnlyCollection<Company>>, IModelViaCodeGen
    {
    }
}
