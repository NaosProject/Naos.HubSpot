// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllCompanyProperties.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// The operation to get all companies.
    /// </summary>
    public partial class GetAllCompanyPropertiesOp : ReturningOperationBase<IReadOnlyCollection<GetAllCompanyPropertiesResponse>>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllCompanyPropertiesOp"/> class.
        /// </summary>
        public GetAllCompanyPropertiesOp()
        {
        }
    }
}
