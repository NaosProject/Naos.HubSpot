// <copyright file="RemoveContactV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class RemoveContactV3Op.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class RemoveContactV3Op : ReturningOperationBase<ContactAndCompanyModelV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveContactV3Op"/> class.
        /// </summary>
        /// <param name="contactIdToRemove">The Contact to remove.</param>
        public RemoveContactV3Op(string contactIdToRemove)
        {
            this.ContactIdToRemove = contactIdToRemove;
        }

        /// <summary>
        /// Gets the Contact to remove.
        /// </summary>
        /// <value>The Contact to remove.</value>
        public string ContactIdToRemove { get; private set; }
    }
}
