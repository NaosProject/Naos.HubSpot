// <copyright file="OptionModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Class OptionModel.
    /// </summary>
    public partial class OptionModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionModel"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="description">The description.</param>
        /// <param name="value">The value.</param>
        /// <param name="displayOrder">The display order.</param>
        /// <param name="hidden">if set to <c>true</c> [hidden].</param>
        public OptionModel(string label, string description, string value, long displayOrder, bool hidden)
        {
            this.Label = label;
            this.Description = description;
            this.Value = value;
            this.DisplayOrder = displayOrder;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; private set; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; private set; }

        /// <summary>
        /// Gets the display order.
        /// </summary>
        /// <value>The display order.</value>
        public long DisplayOrder { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="OptionModel"/> is hidden.
        /// </summary>
        /// <value><c>true</c> if hidden; otherwise, <c>false</c>.</value>
        public bool Hidden { get; private set; }
    }
}