// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllContactsOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// The operation to get all contacts.
    /// </summary>
    public partial class GetAllContactsOp : ReturningOperationBase<IReadOnlyCollection<Contact>>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllContactsOp"/> class.
        /// </summary>
        /// <param name="propertyNamesToInclude">The HubSpot-readable property names to include in the response.</param>
        public GetAllContactsOp(IReadOnlyCollection<string> propertyNamesToInclude = null)
        {
            this.PropertyNamesToInclude = propertyNamesToInclude ?? typeof(StandardContactPropertyName)
                .GetDefinedEnumValues()
                .Select(_ => _.ToString())
                .ToList();
        }

        /// <summary>
        /// Gets the HubSpot-readable property names to include in the response.
        /// </summary>
        public IReadOnlyCollection<string> PropertyNamesToInclude { get; private set; }
    }
}
