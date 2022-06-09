using System.Collections.Generic;
using Xunit;

namespace Friss.Interviews.HistoryCacheApp.Tests;

public class HistoryCacheTests
{
    // Feel free to add your test cases
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]
            {
                new[] { "FRISS B.V.", "Hermes", "Tesla", "Netherlands", "Germany" },
                new[] { "Germany", "Netherlands", "Tesla", "Hermes", "FRISS B.V" }
            },
            new object[]
            {
                new[] { "Hermes", "FRISS B.V.", "FRISS B.V.", "FRISS B.V." },
                new[] { "FRISS B.V.", "Hermes" }
            }
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void GivenTermSearchHistoryReturnExpectedResult(string[] terms, string[] expectedResult)
    {
        var calculator = new HistoryCacheCalculator();

        foreach (var term in terms)
        {
            calculator.Add(term);
        }

        var result = calculator.GetHistoryCache();
        
        Assert.Equal(expectedResult, result);
    }
}