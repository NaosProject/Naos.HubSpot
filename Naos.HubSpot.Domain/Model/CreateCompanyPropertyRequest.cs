// <copyright file="CreateCompanyPropertyRequest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class CreateCompanyPropertyRequest.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class CreateCompanyPropertyRequest : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyPropertyRequest"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="label">The label.</param>
        /// <param name="fieldType">Type of the field.</param>
        /// <param name="type">The type.</param>
        /// <param name="groupName">Name of the group.</param>
        public CreateCompanyPropertyRequest(string name, string label, string fieldType = "text", string type = "string", string groupName = "companyinformation")
        {
            this.Name = name;
            this.Label = label;
            this.FieldType = fieldType;
            this.Type = type;
            this.GroupName = groupName;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the name of the group.
        /// </summary>
        /// <value>The name of the group.</value>
        public string GroupName { get; private set; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Justification = NaosSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        public string FieldType { get; private set; }
    }
}
