// <copyright file="LinqExtensions.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Protocol.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Linq extensions for use in protocols.
    /// </summary>
    public static class LinqExtensions
    {
        /// <summary>
        /// Breaks a list of objects into a jagged list of objects where the maximum length of each element is the chunk size.
        /// </summary>
        /// <param name="source">The source list of objects to be split.</param>
        /// <param name="chunkSize">The maximum length of each element in the new list.</param>
        /// <typeparam name="T">The object type contained in the source list.</typeparam>
        /// <returns>A jagged list of elements where each element is a list with a maximum length.</returns>
        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunkSize)
        {
            if (chunkSize < 1)
            {
                throw new InvalidOperationException("Chunk size must be greater than 0: " + chunkSize);
            }

            var sourceList = source.ToList();
            while (sourceList.Any())
            {
                yield return sourceList.Take(chunkSize);
                sourceList = sourceList.Skip(chunkSize).ToList();
            }
        }
    }
}
