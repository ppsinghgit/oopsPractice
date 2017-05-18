using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PaymentResponseXMLtoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("paymentResponse.xml", FileMode.Open, FileAccess.Read);
            XmlDocument doc = new XmlDocument();
            doc.Load(fs);
            string xml = ModifyXML(doc.InnerXml);
            //samldata = samldata.Replace(@"\", "");
            var stringReader = new System.IO.StringReader(xml);
            var serializer = new XmlSerializer(typeof(Response));
            Response result = (Response)serializer.Deserialize(stringReader);
        }

        public static string RemoveSpecialCharacters(string NodeName)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in NodeName)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string ModifyXML(string xmlString)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xmlString);
            xmlString = Beautify(xdoc);
            XElement xm = XElement.Parse(xmlString);
            Recursive(xm);
            XElement xmm = RemoveAllNamespaces(xm);
            return xmm.ToString();
        }

        public static string Decode64Bit(string rawSamlData)
        {
            byte[] samlData = Convert.FromBase64String(rawSamlData);

            // read back into a UTF string
            string samlAssertion = Encoding.UTF8.GetString(samlData);
            return samlAssertion;
        }

        public static string DecodeStringFromBase64(string stringToDecode)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(stringToDecode));
        }

        public static string Beautify(XmlDocument doc)
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };
            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                doc.Save(writer);
            }
            return sb.ToString();
        }

        #region Private Methods

        private static XElement RemoveAllNamespaces(XElement xmlDocument)
        {
            if (!xmlDocument.HasElements)
            {
                XElement xElement = new XElement(xmlDocument.Name.LocalName);
                xElement.Value = xmlDocument.Value;

                foreach (XAttribute attribute in xmlDocument.Attributes())
                {
                    xElement.Add(attribute);
                }

                return xElement;
            }
            return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
        }

        private static void Recursive(XElement element)
        {
            if (element.HasElements)
            {
                foreach (XAttribute att in element.Attributes())
                {
                    element.AddFirst(new XElement(att.Name.LocalName, att.Value));
                }
                element.Attributes().Remove();
                foreach (XElement item in element.Elements())
                {
                    if (item.HasAttributes)
                    {
                        if (!item.HasElements)
                            item.AddFirst(new XElement("Text", item.Value));

                        foreach (XAttribute att in item.Attributes())
                        {
                            item.AddFirst(new XElement(RemoveSpecialCharacters(att.Name.LocalName), att.Value));
                        }
                        item.Attributes().Remove();

                    }
                    if (item.HasElements)
                    {
                        Recursive(item);
                    }
                }
            }
            else
            {
                if (element.HasAttributes)
                {
                    element.AddFirst(new XElement("Text", element.Value));
                    foreach (XAttribute att in element.Attributes())
                    {
                        element.AddFirst(new XElement(att.Name.LocalName, att.Value));
                    }
                }
            }

        }

        #endregion
    }
}
