// <copyright file="GetAllPropertiesV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetAllPropertiesV3Op.
    /// </summary>
    public partial class GetAllPropertiesV3Op : ReturningOperationBase<IReadOnlyCollection<PropertyModel>>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllPropertiesV3Op"/> class.
        /// </summary>
        public GetAllPropertiesV3Op()
        {
        }
    }
}
