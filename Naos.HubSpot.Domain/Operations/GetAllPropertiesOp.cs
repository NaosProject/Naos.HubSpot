// <copyright file="GetAllPropertiesOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetAllPropertiesOp.
    /// </summary>
    public partial class GetAllPropertiesOp : ReturningOperationBase<IReadOnlyCollection<PropertyModel>>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllPropertiesOp"/> class.
        /// </summary>
        public GetAllPropertiesOp()
        {
        }
    }
}
