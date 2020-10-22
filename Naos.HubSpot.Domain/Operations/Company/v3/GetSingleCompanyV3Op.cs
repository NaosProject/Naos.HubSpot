// <copyright file="GetSingleCompanyV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetSingleCompanyV3Op.
    /// Implements the <see cref="ReturningOperationBase{ContactAndCompanyModelV3}" />.
    /// </summary>
    /// <seealso cref="ReturningOperationBase{ContactAndCompanyModelV3}" />
    public partial class GetSingleCompanyV3Op : ReturningOperationBase<ContactAndCompanyModelV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Gets or sets the company identifier.
        /// </summary>
        /// <value>The company identifier.</value>
        public string CompanyId { get; set; }
    }
}
