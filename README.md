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


### License

(The MIT License)

Copyright (c) 2014 Anthony Massaro amassaro78@gmail.com

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.