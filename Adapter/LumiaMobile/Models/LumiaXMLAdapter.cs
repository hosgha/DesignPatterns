using Newtonsoft.Json;
using System.Xml;

namespace Adapter.Models
{
    public class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public XmlDocument GetLumiaMobilesXMLSpecifications()
        {
            LumiaJSONAdaptee lumiaJsonAdaptee = new LumiaJSONAdaptee();
            string jsonLumia = lumiaJsonAdaptee.GetLumiaMobilesJSONSpecifications();
            var doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMoblies", true);
            return doc ?? new XmlDocument();
        }
    }
}
