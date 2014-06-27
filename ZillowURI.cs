
namespace Zillow.Services
{

    /// <summary>
    /// Constant URI's for each Zillow Web Service
    /// </summary>
    public static class ZillowURI
    {

        // Home Valuation

        public const string SearchResults = "http://www.zillow.com/webservice/GetSearchResults.htm";
        public const string ZEstimate = "http://www.zillow.com/webservice/GetZestimate.htm";
        public const string Chart = "http://www.zillow.com/webservice/GetChart.htm";
        public const string Comps = "http://www.zillow.com/webservice/GetComps.htm";

        // Neighboorhood Information

        public const string DemoGraphics = "http://www.zillow.com/webservice/GetDemographics.htm";
        public const string RegionChildren = "http://www.zillow.com/webservice/GetRegionChildren.htm";
        public const string RegionChart = "http://www.zillow.com/webservice/GetRegionChart.htm";

        // Property Details

        public const string DeepSearchResults = "http://www.zillow.com/webservice/GetDeepSearchResults.htm";
        public const string DeepComps = "http://www.zillow.com/webservice/GetDeepComps.htm";
        public const string UpdatedPropertyDetails = "http://www.zillow.com/webservice/GetUpdatedPropertyDetails.htm";

        // Mortgage

        public const string RateSummary = "http://www.zillow.com/webservice/GetRateSummary.htm";
        public const string MonthlyPayments = "http://www.zillow.com/webservice/GetMonthlyPayments.htm";

    }

}
