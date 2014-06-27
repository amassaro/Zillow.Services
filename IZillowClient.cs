using System.Threading.Tasks;
using Zillow.Services.Schema;

namespace Zillow.Services
{
    public interface IZillowClient
    {

        // Sync Methods

        searchresults GetSearchResults(string address, string citystatezip);
        zestimateResultType GetZestimate(string zpid);
        chart GetChart(string zpid, string unittype, string width, string height);
        comps GetComps(string zpid, string count);
        regionchart GetRegionChart(string city, string state, string neighborhood, string zip, string unittype, string width, string height, SimpleChartDuration chartDuration, ChartVariant chartVariant);
        demographicsResultType GetDemographics(string rid, string state, string city, string neighborhood);
        regionchildrenResultType GetRegionChildren(string regionid, string country, string state, string county, string city, string childtype);
        rateSummaryResultType GetRateSummary(string state, string output, string callback);
        paymentsSummaryResultType GetMonthlyPayments(int price, int down, int dollarsdown, int zip, string output, string callback);
        searchresults GetDeepSearchResults(string address, string citystatezip);
        comps GetDeepComps(string zpid, string count);
        updatedPropertyDetails GetUpdatedPropertyDetails(uint zpid);

        // Async Methods

        Task<searchresults> GetSearchResultsAsync(string address, string citystatezip);
        Task<zestimateResultType> GetZestimateAsync(string zpid);
        Task<chart> GetChartAsync(string zpid, string unittype, string width, string height);
        Task<comps> GetCompsAsync(string zpid, string count);
        Task<regionchart> GetRegionChartAsync(string city, string state, string neighborhood, string zip, string unittype, string width, string height, SimpleChartDuration chartDuration, ChartVariant chartVariant);
        Task<demographicsResultType> GetDemographicsAsync(string rid, string state, string city, string neighborhood);
        Task<regionchildrenResultType> GetRegionChildrenAsync(string regionid, string country, string state, string county, string city, string childtype);
        Task<rateSummaryResultType> GetRateSummaryAsync(string state, string output, string callback);
        Task<paymentsSummaryResultType> GetMonthlyPaymentsAsync(int price, int down, int dollarsdown, int zip, string output, string callback);
        Task<searchresults> GetDeepSearchResultsAsync(string address, string citystatezip);
        Task<comps> GetDeepCompsAsync(string zpid, string count);
        Task<updatedPropertyDetails> GetUpdatedPropertyDetailsAsync(uint zpid);

    }
}
