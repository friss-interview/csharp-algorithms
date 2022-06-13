namespace Friss.Interviews.HistoryCacheApp;

/*
At FRISS we have an application where users can search for entities (e.g. person, companies, vehicles)
The users now want to know the last 5 *distinct* terms they searched, *ordered* from the most recent to the last

Example 1:

terms: "FRISS B.V.", "Hermes", "Tesla", "Netherlands", "Germany"

result: ["Germany", "Netherlands", "Tesla", "Hermes", "FRISS B.V"]

Example 2:

terms: ["FRISS B.V", "Hermes", "FRISS B.V"]
*/
public class HistoryCacheCalculator
{
    public void Add(string term)
    {
        // Implement your logic
    }

    public string[] GetHistoryCache()
    {
        // Implement your logic

        return Array.Empty<string>();
    }
}