
namespace Zillow.Services
{

    /// <summary>
    /// Constant URI's for each Zillow Web Service
    /// </summary>
    public static class ZillowURI
    {

        // Home Valuation

        public const string SEARCHRESULTS = "http://www.zillow.com/webservice/GetSearchResults.htm";
        public const string ZESTIMATE = "http://www.zillow.com/webservice/GetZestimate.htm";
        public const string CHART = "http://www.zillow.com/webservice/GetChart.htm";
        public const string COMPS = "http://www.zillow.com/webservice/GetComps.htm";

        // Neighboorhood Information

        public const string DEMOGRAPHICS = "http://www.zillow.com/webservice/GetDemographics.htm";
        public const string REGIONCHILDREN = "http://www.zillow.com/webservice/GetRegionChildren.htm";
        public const string REGIONCHART = "http://www.zillow.com/webservice/GetRegionChart.htm";

        // Property Details

        public const string DEEPSEARCHRESULTS = "http://www.zillow.com/webservice/GetDeepSearchResults.htm";
        public const string DEEPCOMPS = "http://www.zillow.com/webservice/GetDeepComps.htm";
        public const string UPDATEDPROPERTYDETAILS = "http://www.zillow.com/webservice/GetUpdatedPropertyDetails.htm";

        // Mortgage

        public const string RATESUMMARY = "http://www.zillow.com/webservice/GetRateSummary.htm";
        public const string MONTHLYPAYMENTS = "http://www.zillow.com/webservice/GetMonthlyPayments.htm";

    }

}
