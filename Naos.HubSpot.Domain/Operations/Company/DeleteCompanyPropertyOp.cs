// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteCompanyPropertyOp.cs" company="Naos Project">
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
    /// The operation to create a company property.
    /// </summary>
    public partial class DeleteCompanyPropertyOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCompanyPropertyOp"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public DeleteCompanyPropertyOp(string propertyName)
        {
            this.PropertyName = propertyName;
        }

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        public string PropertyName { get; private set; }
    }
}
