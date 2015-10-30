using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Mensageria.DANFE.Class.SchemaXML;
using Mensageria.DANFE.Class.SchemaXML.XML310;

namespace Mensageria.DANFE.Helpers
{
    public static class Helper
    {
        public static byte[] StringToUtf8ByteArray(string pXmlString)
        {
            var encoding = new UTF8Encoding();
            var byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }

        public static object LoadXmltoStr(string xml, VersaoNFe versao, string stTipo)
        {
            var xs = new XmlSerializer(Factory.GetXMLType(versao, stTipo));
            var memoryStream = new MemoryStream(StringToUtf8ByteArray(xml));
            return xs.Deserialize(memoryStream);
        }
    }
}
