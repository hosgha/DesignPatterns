using Adapter.Models;
using System.Xml;

ILumiaXMLTarget lumiaXmladapter = new LumiaXMLAdapter();

XmlDocument lumiaXmlData = lumiaXmladapter.GetLumiaMobilesXMLSpecifications();

lumiaXmlData.Save(Console.Out);