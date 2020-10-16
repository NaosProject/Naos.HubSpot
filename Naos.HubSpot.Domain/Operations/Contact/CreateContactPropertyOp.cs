// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateContactPropertyOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using Naos.HubSpot.Domain.Model;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// The operation to get all contact properties.
    /// </summary>
    public partial class CreateContactPropertyOp : ReturningOperationBase<ContactPropertyModel>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactPropertyOp"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        public CreateContactPropertyOp(CreateContactPropertyRequest request)
        {
            this.Request = request;
        }

        /// <summary>
        /// Gets the request.
        /// </summary>
        /// <value>The request.</value>
        public CreateContactPropertyRequest Request { get; private set; }
    }
}
