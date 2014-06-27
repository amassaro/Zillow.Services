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
                    var u = new UriBuilder(uri);
                    var query = HttpUtility.ParseQueryString(string.Empty);

                    foreach (string k in parameters.Keys)
                        query[k] = parameters[k].ToString();

                    u.Query = query.ToString();
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

                var results = await CallAPIAsync<searchresults>(ZillowURI.SearchResults, p);

                if (results == null)
                    throw new NullReferenceException("searchresults API value is null");

                if (int.Parse(results.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", results.message.code, results.message.text));

                return results;
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

                var zestimate = await CallAPIAsync<zestimateResultType>(ZillowURI.ZEstimate, p);

                if (zestimate == null)
                    throw new NullReferenceException("zestimate API value is null");

                if (int.Parse(zestimate.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", zestimate.message.code, zestimate.message.text));

                return zestimate;
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

                var chart = await CallAPIAsync<chart>(ZillowURI.Chart, p);

                if (chart == null)
                    throw new NullReferenceException("chart API value is null");

                if (int.Parse(chart.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", chart.message.code, chart.message.text));

                return chart;
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

                var comps = await CallAPIAsync<comps>(ZillowURI.Comps, p);

                if (comps == null)
                    throw new NullReferenceException("comps API value is null");

                if (int.Parse(comps.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", comps.message.code, comps.message.text));

                return comps;
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

                var regionchart = await CallAPIAsync<regionchart>(ZillowURI.RegionChart, p);

                if (regionchart == null)
                    throw new NullReferenceException("regionchart API value is null");

                if (int.Parse(regionchart.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", regionchart.message.code, regionchart.message.text));

                return regionchart;
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

                demographicsResultType demo = await CallAPIAsync<demographicsResultType>(ZillowURI.DemoGraphics, p);

                if (demo == null)
                    throw new NullReferenceException("demographicsResultType API value is null");

                if (int.Parse(demo.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", demo.message.code, demo.message.text));

                return demo;
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

                regionchildrenResultType rc = await CallAPIAsync<regionchildrenResultType>(ZillowURI.RegionChildren, p);

                if (rc == null)
                    throw new NullReferenceException("regionchildrenResultType API value is null");

                if (int.Parse(rc.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", rc.message.code, rc.message.text));

                return rc;
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

                rateSummaryResultType rs = await CallAPIAsync<rateSummaryResultType>(ZillowURI.RateSummary, p);

                if (rs == null)
                    throw new NullReferenceException("rateSummaryResultType API value is null");

                if (int.Parse(rs.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", rs.message.code, rs.message.text));

                return rs;
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

                paymentsSummaryResultType ps = await CallAPIAsync<paymentsSummaryResultType>(ZillowURI.RegionChildren, p);

                if (ps == null)
                    throw new NullReferenceException("paymentsSummaryResultType API value is null");

                if (int.Parse(ps.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", ps.message.code, ps.message.text));

                return ps;
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

                searchresults search = await CallAPIAsync<searchresults>(ZillowURI.DeepSearchResults, p);

                if (search == null)
                    throw new NullReferenceException("searchresults API value is null");

                if (int.Parse(search.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", search.message.code, search.message.text));

                return search;
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

                comps comps = await CallAPIAsync<comps>(ZillowURI.DeepComps, p);

                if (comps == null)
                    throw new NullReferenceException("comps API value is null");

                if (int.Parse(comps.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", comps.message.code, comps.message.text));

                return comps;
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

                updatedPropertyDetails upd = await CallAPIAsync<updatedPropertyDetails>(ZillowURI.UpdatedPropertyDetails, p);

                if (upd == null)
                    throw new NullReferenceException("updatedPropertyDetails API value is null");

                if (int.Parse(upd.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", upd.message.code, upd.message.text));

                return upd;
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
