using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using Zillow.Services.Schema;

namespace Zillow.Services
{
    public partial class ZillowClient : IZillowClient
    {

        private async Task<T> CallAPIAsync<T>(string uri, Hashtable parameters)
        {
            try
            {
                // Build HttpClient request
                using (var httpClient = new HttpClient())
                {
                    // Read XML and Deserialize Object
                    var u = new UriBuilder(uri)
                    {
                        Query = PrepareQuery(parameters)
                    };
                    var xml = await httpClient.GetStringAsync(u.Uri);

                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    return (T)ser.Deserialize(new StringReader(xml));
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex);
                throw ex;
            }

        }

        #region Public Async Methods

        public async Task<searchresults> GetSearchResultsAsync(string address, string citystatezip)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"address", address},
                    {"citystatezip", citystatezip}
                };

                return await CallAPIAsync<searchresults>(ZillowURI.SearchResults, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<zestimateResultType> GetZestimateAsync(string zpid)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"zpid", zpid}
                };

                return await CallAPIAsync<zestimateResultType>(ZillowURI.ZEstimate, p);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<chart> GetChartAsync(string zpid, string unittype, string width, string height)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"zpid", zpid},
                    {"unit-type", unittype},
                    {"width", width},
                    {"height", height}
                };

                return await CallAPIAsync<chart>(ZillowURI.Chart, p);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<comps> GetCompsAsync(string zpid, string count)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"zpid", zpid},
                    {"count", count}
                };

                return await CallAPIAsync<comps>(ZillowURI.Comps, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<regionchart> GetRegionChartAsync(string city, string state, string neighborhood, string zip, string unittype, string width, string height, SimpleChartDuration chartDuration, ChartVariant chartVariant)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"city", city},
                    {"state", state},
                    {"neighborhood", neighborhood},
                    {"zip", zip},
                    {"unit-type", unittype},
                    {"width", width},
                    {"height", height},
                    {"chartDuration", ZillowExtensions.GetXmlName(chartDuration)},
                    {"chartVariant", chartVariant}
                };

                return await CallAPIAsync<regionchart>(ZillowURI.RegionChart, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<demographicsResultType> GetDemographicsAsync(string rid, string state, string city, string neighborhood)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"rid", rid},
                    {"state", state},
                    {"city", city},
                    {"neighborhood", neighborhood}
                };

                return await CallAPIAsync<demographicsResultType>(ZillowURI.DemoGraphics, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<regionchildrenResultType> GetRegionChildrenAsync(string regionid, string country, string state, string county, string city, string childtype)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"regionid", regionid},
                    {"country", country},
                    {"state", state},
                    {"childtype", childtype}
                };

                return await CallAPIAsync<regionchildrenResultType>(ZillowURI.RegionChildren, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<rateSummaryResultType> GetRateSummaryAsync(string state, string output, string callback)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"state", state},
                    {"output", output},
                    {"callback", callback}
                };

                return await CallAPIAsync<rateSummaryResultType>(ZillowURI.RateSummary, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<paymentsSummaryResultType> GetMonthlyPaymentsAsync(int price, int down, int dollarsdown, int zip, string output, string callback)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"price", price},
                    {"down", down},
                    {"dollarsdown", dollarsdown},
                    {"zip", zip},
                    {"output", output},
                    {"callback", callback}
                };

                return await CallAPIAsync<paymentsSummaryResultType>(ZillowURI.RegionChildren, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<searchresults> GetDeepSearchResultsAsync(string address, string citystatezip)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"address", address},
                    {"citystatezip", citystatezip}
                };

                return await CallAPIAsync<searchresults>(ZillowURI.DeepSearchResults, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<comps> GetDeepCompsAsync(string zpid, string count)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"zpid", zpid},
                    {"count", count}
                };

                return await CallAPIAsync<comps>(ZillowURI.DeepComps, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public async Task<updatedPropertyDetails> GetUpdatedPropertyDetailsAsync(uint zpid)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"zpid", zpid}
                };

                return await CallAPIAsync<updatedPropertyDetails>(ZillowURI.UpdatedPropertyDetails, p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        #endregion

    }
}
