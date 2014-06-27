using System;
using System.Reflection;
using System.Xml.Serialization;
using Zillow.Services.Schema;

namespace Zillow.Services
{
    public static class ZillowExtensions
    {

        public static string GetXmlName(SimpleChartDuration duration)
        {
            Type d = duration.GetType();
            FieldInfo info = d.GetField(duration.ToString("G"));

            if (!info.IsDefined(typeof(XmlEnumAttribute), false))
                return duration.ToString();

            var att = info.GetCustomAttribute<XmlEnumAttribute>(false);
            return att.Name;
        }


        internal static object GetXmlName(ChartVariant chartVariant)
        {
            throw new NotImplementedException();
        }
    }
}
