// <copyright file="GetSingleContactV3Op.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class GetSingleContactV3Op.
    /// Implements the <see cref="ContactAndCompanyModelV3" />.
    /// </summary>
    /// <seealso cref="ContactAndCompanyModelV3" />
    public partial class GetSingleContactV3Op : ReturningOperationBase<ContactAndCompanyModelV3>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSingleContactV3Op"/> class.
        /// </summary>
        /// <param name="contactId">The contact identifier.</param>
        public GetSingleContactV3Op(string contactId)
        {
            this.ContactId = contactId;
        }

        /// <summary>
        /// Gets the contact identifier.
        /// </summary>
        /// <value>The contact identifier.</value>
        public string ContactId { get; private set; }
    }
}
