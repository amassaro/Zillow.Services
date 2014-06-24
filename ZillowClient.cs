namespace Zillow.Services
{
    #region Namespaces

    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web;
    using System.Xml.Serialization;
    using Zillow.Services.Schema;

    #endregion

    /// <summary>
    /// Client for accessing and creating zillow web service objects
    /// </summary>
    public class ZillowClient
    {
        #region Private Members

        private string _zwsid = string.Empty;

        #endregion

        #region Public Members

        /// <summary>
        /// Zillow Web Service ID
        /// </summary>
        public string Zwsid
        {
            get
            {
                if (_zwsid == string.Empty)
                    throw new Exception("Zillow Web Service Identifier Not Set!");
                return _zwsid;
            }
            private set { _zwsid = value; }
        }

        #endregion

        #region Contructors

        /// <summary>
        /// Overloaded Contructor passing Zillow Web Service ID
        /// </summary>
        /// <param name="zwsid">Zillow Web Service ID</param>
        public ZillowClient(string zwsid)
        {

            if (string.IsNullOrEmpty(zwsid))
                throw new ArgumentException("Zillow ID API access key is required", "zwsid");

            Zwsid = zwsid;
        }

        #endregion

        #region Private Methods

        private object CallAPI(string uri, Hashtable parameters, Type t)
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
                    var xml = httpClient.GetStringAsync(u.Uri).Result;

                    XmlSerializer ser = new XmlSerializer(t);
                    return ser.Deserialize(new StringReader(xml));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex);
            }

            return null;
        }

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
            }

            return default(T);
        }

        #endregion

        #region Public Sync Methods

        /// <summary>
        /// Method for searching a property with a given address location
        /// </summary>
        /// <param name="address">Address of property</param>
        /// <param name="citystatezip">City State Zipcode of property</param>
        /// <returns>Returns a searchresults Zillow Object</returns>
        public searchresults GetSearchResults(string address, string citystatezip)
        {
            try
            {
                Hashtable p = new Hashtable();
                XmlSerializer ser = new XmlSerializer(typeof(searchresults));

                p.Add("zws-id", Zwsid);
                p.Add("address", address);
                p.Add("citystatezip", citystatezip);

                searchresults search = (searchresults)CallAPI(ZillowURI.SEARCHRESULTS, p, typeof(searchresults));

                if (search == null)
                    throw new NullReferenceException("searchresults API value is null");

                if (int.Parse(search.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", search.message.code, search.message.text));

                return search;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// Method for getting a zestimateResultType a known zpid property
        /// </summary>
        /// <param name="zpid">Zillow zpid number</param>
        /// <returns>Returns a zestimateResultType Zillow Object</returns>
        public zestimateResultType GetZestimate(uint zpid)
        {
            try
            {
                Hashtable p = new Hashtable();
                XmlSerializer ser = new XmlSerializer(typeof(zestimateResultType));

                p.Add("zws-id", Zwsid);
                p.Add("zpid", zpid.ToString());

                zestimateResultType zestimate = (zestimateResultType)CallAPI(ZillowURI.ZESTIMATE, p, typeof(zestimateResultType));

                if (zestimate == null)
                    throw new NullReferenceException("zestimateResultType API value is null");

                if (int.Parse(zestimate.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", zestimate.message.code, zestimate.message.text));

                return zestimate;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// Method for getting a chart from the given parameters
        /// </summary>
        /// <param name="zpid">Zillow zpid number</param>
        /// <param name="unittype">unit type "dollars" or "percent"</param>
        /// <param name="width">width of the graph 200 to 600 range</param>
        /// <param name="height">height of the graph 100 to 300 range</param>
        /// <param name="duration">duration of the graph "1year" 5"years" or "10years"</param>
        /// <returns>Returns a chart Zillow Object</returns>
        public chart GetChart(uint zpid, string unittype, int width, int height, string duration)
        {
            try
            {
                Hashtable p = new Hashtable();
                XmlSerializer ser = new XmlSerializer(typeof(chart));

                p.Add("zws-id", Zwsid);
                p.Add("zpid", zpid.ToString());
                p.Add("unit-type", unittype);
                p.Add("width", width.ToString());
                p.Add("height", height.ToString());
                p.Add("Chartduration", duration);

                chart c = (chart)CallAPI(ZillowURI.CHART, p, typeof(chart));

                if (c == null)
                    throw new NullReferenceException("chart API value is null");

                if (int.Parse(c.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", c.message.code, c.message.text));

                return c;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// Methods for getting a list of comparible properties near a given zpid property
        /// </summary>
        /// <param name="zpid">Zillow zpid number</param>
        /// <param name="count"></param>
        /// <returns>Returns a comps Zillow Object</returns>
        public comps GetComps(uint zpid, int count)
        {
            try
            {
                Hashtable p = new Hashtable();
                XmlSerializer ser = new XmlSerializer(typeof(comps));

                p.Add("zws-id", Zwsid);
                p.Add("zpid", zpid.ToString());
                p.Add("count", count.ToString());

                comps c = (comps)CallAPI(ZillowURI.COMPS, p, typeof(comps));

                if (c == null)
                    throw new NullReferenceException("comps API value is null");

                if (int.Parse(c.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", c.message.code, c.message.text));

                return c;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// Method for getting a regional chart with the given parameters
        /// </summary>
        /// <param name="city">City to search</param>
        /// <param name="state">State to search</param>
        /// <param name="zip">Zipcode to search</param>
        /// <param name="unittype">unit type "dollars" or "percent"</param>
        /// <param name="width">width of the graph 200 to 600 range</param>
        /// <param name="height">height of the graph 100 to 300 range</param>
        /// <param name="duration">duration of the graph "1year" 5"years" or "10years"</param>
        /// <returns>Returns a regionchart Zillow Object</returns>
        public regionchart GetRegionChart(string city, string state, string zip, string unittype, int width, int height, string duration)
        {
            try
            {
                Hashtable p = new Hashtable();
                XmlSerializer ser = new XmlSerializer(typeof(regionchart));

                p.Add("zws-id", Zwsid);
                p.Add("city", city);
                p.Add("state", state);
                p.Add("ZIP", zip);
                p.Add("unit-type", unittype);
                p.Add("width", width.ToString());
                p.Add("height", height.ToString());
                p.Add("Chartduration", duration);

                regionchart c = (regionchart)CallAPI(ZillowURI.REGIONCHART, p, typeof(regionchart));

                if (c == null)
                    throw new NullReferenceException("regionchart API value is null");

                if (int.Parse(c.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", c.message.code, c.message.text));

                return c;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

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

                var results = await CallAPIAsync<searchresults>(ZillowURI.SEARCHRESULTS, p);

                if (results == null)
                    throw new NullReferenceException("searchresults API value is null");

                if (int.Parse(results.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", results.message.code, results.message.text));

                return results;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<zestimateResultType> GetZestimateAsync(uint zpid)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"zpid", zpid.ToString()}
                };

                var zestimate = await CallAPIAsync<zestimateResultType>(ZillowURI.ZESTIMATE, p);

                if (zestimate == null)
                    throw new NullReferenceException("zestimate API value is null");

                if (int.Parse(zestimate.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", zestimate.message.code, zestimate.message.text));

                return zestimate;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<chart> GetChartAsync(uint zpid, string unittype, int width, int height, string duration)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"zpid", zpid.ToString()},
                    {"unit-type", unittype},
                    {"width", width.ToString()},
                    {"height", height.ToString()},
                    {"Chartduration", duration}
                };

                var chart = await CallAPIAsync<chart>(ZillowURI.CHART, p);

                if (chart == null)
                    throw new NullReferenceException("chart API value is null");

                if (int.Parse(chart.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", chart.message.code, chart.message.text));

                return chart;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<comps> GetCompsAsync(uint zpid, int count)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"zpid", zpid.ToString()},
                    {"count", count.ToString()}
                };

                var comps = await CallAPIAsync<comps>(ZillowURI.COMPS, p);

                if (comps == null)
                    throw new NullReferenceException("comps API value is null");

                if (int.Parse(comps.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", comps.message.code, comps.message.text));

                return comps;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<regionchart> GetRegionChartAsync(string city, string state, string zip, string unittype, int width, int height, string duration)
        {
            try
            {
                Hashtable p = new Hashtable
                {
                    {"zws-id", Zwsid},
                    {"city", city},
                    {"state", state},
                    {"ZIP", zip},
                    {"unit-type", unittype},
                    {"width", width.ToString()},
                    {"height", height.ToString()},
                    {"Chartduration", duration}
                };

                var regionchart = await CallAPIAsync<regionchart>(ZillowURI.REGIONCHART, p);

                if (regionchart == null)
                    throw new NullReferenceException("regionchart API value is null");

                if (int.Parse(regionchart.message.code) != 0)
                    throw new Exception(string.Format("Zillow Error #{0}: {1}", regionchart.message.code, regionchart.message.text));

                return regionchart;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion
    }
}
