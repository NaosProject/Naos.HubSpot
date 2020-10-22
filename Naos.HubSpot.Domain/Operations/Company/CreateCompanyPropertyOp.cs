// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateCompanyPropertyOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// The operation to create a company property.
    /// </summary>
    public partial class CreateCompanyPropertyOp : ReturningOperationBase<GetAllCompanyPropertiesResponse>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyPropertyOp"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        public CreateCompanyPropertyOp(CreateCompanyPropertyRequest request)
        {
            this.Request = request;
        }

        /// <summary>
        /// Gets the request.
        /// </summary>
        /// <value>The request.</value>
        public CreateCompanyPropertyRequest Request { get; private set; }
    }
}
