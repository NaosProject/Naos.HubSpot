﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyHelper.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Reflection.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Reflection.Recipes
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.IO;
    using global::System.IO.Compression;
    using global::System.Linq;
    using global::System.Reflection;
    using global::System.Runtime.CompilerServices;

    using OBeautifulCode.Collection.Recipes;

    using static global::System.FormattableString;

    /// <summary>
    /// Provides useful methods for extracting information from and
    /// interacting with assemblies using reflection.
    /// </summary>
#if !OBeautifulCodeReflectionSolution
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Reflection.Recipes", "See package version number")]
    internal
#else
    public
#endif
    static class AssemblyHelper
    {
        /// <summary>
        /// Gets the <see cref="Assembly.CodeBase" /> as a real file path instead of a <see cref="Uri" /> so it can be used with common <see cref="System.IO" /> operations.
        /// </summary>
        /// <param name="assembly">Assembly to extend functionality of.</param>
        /// <returns>CodeBase as real path.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Justification = "Correct return type.")]
        public static string GetCodeBaseAsPathInsteadOfUri(
            this Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            var nonUriCodeBase = assembly.CodeBase.Replace(@"file:///", string.Empty).Replace('/', '\\');
            return nonUriCodeBase;
        }

        /// <summary>
        /// Retrieves an embedded resource's stream.
        /// </summary>
        /// <param name="assembly">Calling assembly.</param>
        /// <param name="resourceName">Property of the resource in the calling assembly.</param>
        /// <param name="decompressionMethod">
        /// The compression algorithm and/or archive file format that was used to compress the resource.
        /// This is used to open a decompressed stream.
        /// </param>
        /// <returns>Returns the specified manifest resource as a stream.</returns>
        /// <exception cref="ArgumentNullException">assembly is null.</exception>
        /// <exception cref="ArgumentNullException">resourceName is null.</exception>
        /// <exception cref="ArgumentException">resourceName is whitspace.</exception>
        /// <exception cref="InvalidOperationException">Resource was not found in the calling assembly.</exception>
        /// <exception cref="InvalidOperationException">The resource was not an embedded resource (that is, non-linked).</exception>
        /// <exception cref="NotImplementedException">Resource length is greater than Int64.MaxValue.</exception>
        /// <exception cref="InvalidDataException">When compression method is Gzip, but the resource was not compressed using Gzip.</exception>
        public static Stream OpenEmbeddedResourceStream(
            this Assembly assembly,
            string resourceName,
            CompressionMethod decompressionMethod = CompressionMethod.None)
        {
            // here's a good article about .net resources
            // http://www.grimes.demon.co.uk/workshops/fusWSNine.htm
            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            if (string.IsNullOrWhiteSpace(resourceName))
            {
                throw new ArgumentException("resource name cannot be whitespace", nameof(resourceName));
            }

            ManifestResourceInfo info = assembly.GetManifestResourceInfo(resourceName);
            if (info == null)
            {
                throw new InvalidOperationException("Resource was not found in the calling assembly: " + resourceName);
            }

            if (!info.ResourceLocation.HasFlag(ResourceLocation.Embedded))
            {
                throw new InvalidOperationException("The resource was not an embedded resource (that is, non-linked).");
            }

            // now that we're guaranteeing an embedded resource, we *should* be able to avoid these
            // execeptions from GetManifestResourceStream: FileLoadException, FileNotFoundException, BadImageFormatException
            var embeddedResourceStream = assembly.GetManifestResourceStream(resourceName);

            if (decompressionMethod == CompressionMethod.None)
            {
                return embeddedResourceStream;
            }

            if (decompressionMethod == CompressionMethod.Gzip)
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                var decompressionStream = new GZipStream(embeddedResourceStream, CompressionMode.Decompress);
                return decompressionStream;
            }

            throw new NotSupportedException("This compression method is not supported: " + decompressionMethod);
        }

        /// <summary>
        /// Retrieves a stream for an embedded resource.
        /// </summary>
        /// <param name="resourceName">Property of the resource in the calling assembly.</param>
        /// <param name="addCallerNamespace">
        /// Determines whether to add the namespace of the calling method to the resource name.
        /// If false, then the resource name is used as-is.
        /// If true, then the resource name is prepended with the fully qualified namespace of the calling method, followed by a period
        /// (e.g. if resource name = "MyFile.txt" then it changed to something like "MyNamespace.MySubNamespace.MyFile.txt").
        /// </param>
        /// <param name="decompressionMethod">
        /// The compression algorithm and/or archive file format that was used to compress the resource.
        /// This is used to open a decompressed stream.
        /// </param>
        /// <returns>Returns the specified manifest resource as a stream.</returns>
        /// <exception cref="ArgumentNullException">resourceName is null.</exception>
        /// <exception cref="ArgumentException">resourceName is whitspace.</exception>
        /// <exception cref="InvalidOperationException">Resource was not found in the calling assembly.</exception>
        /// <exception cref="InvalidOperationException">The resource was not an embedded resource (that is, non-linked).</exception>
        /// <exception cref="NotImplementedException">Resource length is greater than Int64.MaxValue.</exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static Stream OpenEmbeddedResourceStream(
            string resourceName,
            bool addCallerNamespace = true,
            CompressionMethod decompressionMethod = CompressionMethod.None)
        {
            resourceName = ResolveResourceName(resourceName, addCallerNamespace);
            var embeddedResourceStream = OpenEmbeddedResourceStream(Assembly.GetCallingAssembly(), resourceName, decompressionMethod);
            return embeddedResourceStream;
        }

        /// <summary>
        /// Reads an embedded resource from the calling assembly and returns as string.
        /// </summary>
        /// <param name="resourceName">Property of the resource in the calling assembly.</param>
        /// <param name="addCallerNamespace">
        /// Determines whether to add the namespace of the calling method to the resource name.
        /// If false, then the resource name is used as-is.
        /// If true, then the resource name is prepended with the fully qualified namespace of the calling method, followed by a period
        /// (e.g. if resource name = "MyFile.txt" then it changed to something like "MyNamespace.MySubNamespace.MyFile.txt").
        /// </param>
        /// <param name="decompressionMethod">
        /// The compression algorithm and/or archive file format that was used to compress the resource.
        /// This is used to determine how the resource should be decompressed.
        /// </param>
        /// <remarks>
        /// Adapted from article "Create String Variables from Embedded Resources Files" on The Code Project
        /// <a href="http://www.codeproject.com/KB/cs/embeddedresourcestrings.aspx"/>
        /// Resource information is returned only if the resource is visible to the caller, or the caller has ReflectionPermission.
        /// This method returns null if a private resource in another assembly is accessed and the caller does not have ReflectionPermission with the ReflectionPermissionFlag.MemberAccess flag.
        /// </remarks>
        /// <returns>Returns the specified manifest resource as a string.</returns>
        /// <exception cref="ArgumentNullException">resourceName is null.</exception>
        /// <exception cref="ArgumentException">resourceName is whitspace.</exception>
        /// <exception cref="InvalidOperationException">Resource was not found in the calling assembly.</exception>
        /// <exception cref="InvalidOperationException">The resource was not an embedded resource (that is, non-linked).</exception>
        /// <exception cref="NotImplementedException">Resource length is greater than Int64.MaxValue.</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "Objects are not being disposed multiple times.")]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string ReadEmbeddedResourceAsString(
            string resourceName,
            bool addCallerNamespace = true,
            CompressionMethod decompressionMethod = CompressionMethod.None)
        {
            resourceName = ResolveResourceName(resourceName, addCallerNamespace);
            using (var embeddedResourceStream = OpenEmbeddedResourceStream(Assembly.GetCallingAssembly(), resourceName, decompressionMethod))
            {
                using (var reader = new StreamReader(embeddedResourceStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Gets all types defined within a set of assemblies.
        /// </summary>
        /// <remarks>
        /// If you want to get all loaded types, then pass-in the result of AssemblyLoader.GetLoadedAssemblies().
        /// </remarks>
        /// <param name="assemblies">The assemblies.</param>
        /// <returns>
        /// The types defined within the specified assemblies.
        /// </returns>
        public static IReadOnlyCollection<Type> GetTypesFromAssemblies(
            this IReadOnlyCollection<Assembly> assemblies)
        {
            if (assemblies == null)
            {
                throw new ArgumentNullException(nameof(assemblies));
            }

            if (assemblies.Any(_ => _ == null))
            {
                throw new ArgumentException(Invariant($"'{nameof(assemblies)}' contains an element that is null"));
            }

            try
            {
                var result = assemblies.SelectMany(_ => _.GetTypes()).Where(_ => _ != null).ToList();

                return result;
            }
            catch (ReflectionTypeLoadException reflectionTypeLoadException)
            {
                var loaderExceptions = reflectionTypeLoadException.LoaderExceptions?.Select(_ => _?.ToString() ?? "<null>").ToCsv();
                var typesLoaded = reflectionTypeLoadException.Types?.Select(_ => _?.ToString() ?? "<null>").ToCsv();
                var message = Invariant($"{nameof(ReflectionTypeLoadException)} was thrown when getting types from assemblies.{Environment.NewLine}The assemblies pased-in were: {assemblies.Select(_ => _.ToString()).ToCsv()}{Environment.NewLine}{Environment.NewLine}The loader exceptions are: {loaderExceptions ?? "<null>"}.{Environment.NewLine}{Environment.NewLine}The types loaded are: {typesLoaded ?? "<null>"}.{Environment.NewLine}{Environment.NewLine}See inner exception for the original exception.");
                throw new TypeLoadException(message, reflectionTypeLoadException);
            }
        }

        /// <summary>
        /// Resolves a resource name.
        /// </summary>
        /// <param name="resourceName">The supplied resource name.</param>
        /// <param name="addCallerNamespace">
        /// Determines whether to add the namespace of the calling method to the resource name.
        /// If false, then the resource name is used as-is.
        /// If true, then the resource name is prepended with the fully qualified namespace of the calling method, followed by a period
        /// (e.g. if resource name = "MyFile.txt" then it changed to something like "MyNamespace.MySubNamespace.MyFile.txt").
        /// </param>
        /// <returns>
        /// The resolved resource name.
        /// </returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static string ResolveResourceName(
            string resourceName,
            bool addCallerNamespace)
        {
            if (addCallerNamespace)
            {
                var frame = new StackFrame(2);
                var method = frame.GetMethod();
                var type = method.DeclaringType;
                if (type != null)
                {
                    resourceName = type.Namespace + "." + resourceName;
                }
            }

            return resourceName;
        }
    }
}
