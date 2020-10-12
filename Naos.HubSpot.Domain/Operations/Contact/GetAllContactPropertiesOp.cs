// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllContactPropertiesOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// The operation to get all contact properties.
    /// </summary>
    public partial class GetAllContactPropertiesOp : ReturningOperationBase<IReadOnlyCollection<ContactPropertyModel>>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllContactPropertiesOp"/> class.
        /// </summary>
        public GetAllContactPropertiesOp()
        {
        }
    }
}
