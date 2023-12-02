using System.Xml;

namespace Adapter.Models
{
    public interface ILumiaXMLTarget
    {
        XmlDocument GetLumiaMobilesXMLSpecifications();
    }
}
