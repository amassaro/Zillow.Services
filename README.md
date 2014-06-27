# Zillow.Services
###### A C# wrapper for Zillow's various web services

![alt text](http://www.zillow.com/widgets/GetVersionedResource.htm?path=/static/logos/Zillowlogo_200x50.gif "Zillow Real Estate Search")

* Supported APIs
  * [Home Valuation API](http://www.zillow.com/howto/api/HomeValuationAPIOverview.htm)
  * [Neighborhood Information](http://www.zillow.com/webtools/neighborhood-data/)
  * [Mortgage API](http://www.zillow.com/howto/api/MortgageAPIOverview.htm)
  * [Property Details API](http://www.zillow.com/howto/api/PropertyDetailsAPIOverview.htm)

For helping finding an Zillow logo image see the [Branding Requirements Page](http://www.zillow.com/howto/api/BrandingRequirements.htm)

### Code Examples

###### Synchronous
```csharp
ZillowClient client = new ZillowClient("YOUR_ZILLOW_ZWSID");
searchresults result = client.GetSearchResults("12345 Somewhere Ave.", "Anywhere MN 54321");

foreach (SimpleProperty prop in result.response.results)
{
    zestimateResultType zest = client.GetZestimate(prop.zpid.ToString());

    chart c = client.GetChart(prop.zpid.ToString(), "dollar", "600", "300");

    regionchart rc = client.GetRegionChart("", "", "", prop.address.zipcode, "dollar", "600", "300", SimpleChartDuration.Item1year, ChartVariant.detailed);

    Console.WriteLine(string.Format("Regional : {0}", rc.response.url));

    comps comp = client.GetComps(prop.zpid.ToString(), "10");

    Console.WriteLine(string.Format("{0}, {1} - {2} {3}", prop.address.latitude, prop.address.longitude, zest.response.zestimate.amount.Value, c.response.url));

    foreach (SimpleProperty p in comp.response.properties.comparables)
    {
        Console.WriteLine(string.Format("{0}, {1} - {2}", p.address.latitude, p.address.longitude, p.zestimate.amount.Value));
    }
}
```

###### Asynchronous
```csharp
ZillowClient client = new ZillowClient("YOUR_ZILLOW_ZWSID");
Task<searchresults> search = client.GetSearchResultsAsync("12345 Somewhere Ave.", "Anywhere MN 54321");
foreach (SimpleProperty prop in search.Result.response.results)
{

    var zest = client.GetZestimateAsync(prop.zpid.ToString());

    var c = client.GetChartAsync(prop.zpid.ToString(), "dollar", "600", "300");

    var rc = client.GetRegionChartAsync("", "", "", prop.address.zipcode, "dollar", "600", "300", SimpleChartDuration.Item1year, ChartVariant.detailed);

    var comp = client.GetCompsAsync(prop.zpid.ToString(), "10");

    Task.WaitAll(zest, c, rc, comp);

    Console.WriteLine(string.Format("Regional : {0}", rc.Result.response.url));

    Console.WriteLine(string.Format("{0}, {1} - {2} {3}", prop.address.latitude, prop.address.longitude, zest.Result.response.zestimate.amount.Value, c.Result.response.url));

    foreach (SimpleProperty p in comp.Result.response.properties.comparables)
    {
        Console.WriteLine(string.Format("{0}, {1} - {2}", p.address.latitude, p.address.longitude, p.zestimate.amount.Value));
    }
}
```