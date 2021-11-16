using System.Xml;

namespace Adapter.Models
{
    public class MyLumiaClient
    {
        private ILumiaXMLTarget _lumiaXmlTarget;

        public MyLumiaClient(ILumiaXMLTarget lumiaXmlTarget)
        {
            _lumiaXmlTarget = lumiaXmlTarget;
        }

        public XmlDocument GetLumiaData()
        {
            return _lumiaXmlTarget.GetLumiaMobilesXMLSpecifications();
        }
    }
}
