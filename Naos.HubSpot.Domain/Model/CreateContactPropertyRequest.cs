// <copyright file="CreateContactPropertyRequest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Model
{
    using Naos.CodeAnalysis.Recipes;
    using Newtonsoft.Json;
    using OBeautifulCode.Type;

    /// <summary>
    /// Class CreateContactPropertyRequest.
    /// Implements the <see cref="OBeautifulCode.Type.IModelViaCodeGen" />.
    /// </summary>
    /// <seealso cref="OBeautifulCode.Type.IModelViaCodeGen" />
    public partial class CreateContactPropertyRequest : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactPropertyRequest"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="label">The label.</param>
        /// <param name="fieldType">Type of the field.</param>
        /// <param name="propertyType">Type of the property.</param>
        /// <param name="groupName">Name of the group.</param>
        public CreateContactPropertyRequest(string name, string label, string fieldType = "text", string propertyType = "string", string groupName = "companyinformation")
        {
            this.Name = name;
            this.Label = label;
            this.GroupName = groupName;
            this.PropertyType = propertyType;
            this.FieldType = fieldType;
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
        [JsonProperty("type")]
        public string PropertyType { get; private set; }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        public string FieldType { get; private set; }
    }
}
