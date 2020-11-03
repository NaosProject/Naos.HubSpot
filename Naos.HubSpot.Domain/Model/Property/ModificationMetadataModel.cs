// <copyright file="ModificationMetadataModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Class ModificationMetadataModel.
    /// </summary>
    public partial class ModificationMetadataModel : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationMetadataModel"/> class.
        /// </summary>
        /// <param name="readOnlyOptions">if set to <c>true</c> [read only options].</param>
        /// <param name="readOnlyValue">if set to <c>true</c> [read only value].</param>
        /// <param name="readOnlyDefinition">if set to <c>true</c> [read only definition].</param>
        /// <param name="archivable">if set to <c>true</c> [can be archived].</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "archivable", Justification = "Naming controlled by external api")]
        public ModificationMetadataModel(bool readOnlyOptions, bool readOnlyValue, bool readOnlyDefinition, bool archivable)
        {
            this.ReadOnlyOptions = readOnlyOptions;
            this.ReadOnlyValue = readOnlyValue;
            this.ReadOnlyDefinition = readOnlyDefinition;
            this.Archivable = archivable;
        }

        /// <summary>
        /// Gets a value indicating whether [read only options].
        /// </summary>
        /// <value><c>true</c> if [read only options]; otherwise, <c>false</c>.</value>
        public bool ReadOnlyOptions { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [read only value].
        /// </summary>
        /// <value><c>true</c> if [read only value]; otherwise, <c>false</c>.</value>
        public bool ReadOnlyValue { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [read only definition].
        /// </summary>
        /// <value><c>true</c> if [read only definition]; otherwise, <c>false</c>.</value>
        public bool ReadOnlyDefinition { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance can be archived.
        /// </summary>
        /// <value><c>true</c> if this instance can be archived; otherwise, <c>false</c>.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Archivable", Justification = "Naming controlled by external api")]
        public bool Archivable { get; private set; }
    }
}