// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllCompaniesOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// The operation to get all companies.
    /// </summary>
    public partial class GetAllCompaniesOp : ReturningOperationBase<IReadOnlyCollection<Company>>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllCompaniesOp"/> class.
        /// </summary>
        /// <param name="propertyNamesToInclude">The names of the properties to be included in the response.</param>
        public GetAllCompaniesOp(IReadOnlyCollection<string> propertyNamesToInclude = null)
        {
            this.PropertyNamesToInclude = propertyNamesToInclude ?? typeof(StandardCompanyPropertyName)
                .GetDefinedEnumValues()
                .Select(_ => _.ToString())
                .ToList();
        }

        /// <summary>
        /// Gets the names of the properties to be included in the response.
        /// </summary>
        public IReadOnlyCollection<string> PropertyNamesToInclude { get; private set; }
    }
}
