// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteContactPropertyOp.cs" company="Naos Project">
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
    public partial class DeleteContactPropertyOp : VoidOperationBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteContactPropertyOp"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public DeleteContactPropertyOp(string propertyName)
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
