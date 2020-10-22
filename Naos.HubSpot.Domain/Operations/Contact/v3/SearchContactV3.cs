// <copyright file="SearchContactV3.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class SearchContactV3.
    /// Implements the <see cref="IReadOnlyCollection{ContactAndCompanyModelV3}" />.
    /// </summary>
    /// <seealso cref="ContactAndCompanyModelV3" />
    public partial class SearchContactV3 : ReturningOperationBase<IReadOnlyCollection<ContactAndCompanyModelV3>>, IModelViaCodeGen
    {
    }
}
