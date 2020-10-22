// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HubSpotContactCanonicalizationTest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Protocol.Client.Test
{
    using System.Linq;
    using Naos.HubSpot.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using Xunit;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public static partial class HubSpotProtocolTest
    {
        [Fact]
        public static void StandardContactPropertyNameStringToHubSpotPropertyNameMap___For_each_standard_property_name___Contains_valid_entry()
        {
            // Arrange
            var mapUnderTest = HubSpotProtocol.StandardContactPropertyNameStringToHubSpotPropertyNameMap;
            var allStandardNames = typeof(StandardContactPropertyName).GetDefinedEnumValues().Select(_ => _.ToString()).ToList();

            // Assert
            allStandardNames.Count().MustForTest()
                .BeEqualTo(mapUnderTest.Count());
            foreach (var propertName in allStandardNames)
            {
                var val = mapUnderTest[propertName];
                val.MustForTest().NotBeNullNorWhiteSpace();
            }
        }
    }
}
