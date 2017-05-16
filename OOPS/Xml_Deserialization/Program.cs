using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using XmlToObject;

namespace Xml_Deserialization
{
    class Program
    {        
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("SpecialPriodEligibilityResponse.xml", FileMode.Open, FileAccess.Read);
            XmlDocument doc = new XmlDocument();
            doc.Load(fs);
            string str = Beautify(doc);
            str = Common.ModifyXML(str);
            var stringReader = new System.IO.StringReader(str);
            var serializer = new XmlSerializer(typeof(Envelope));
            Envelope result = (Envelope)serializer.Deserialize(stringReader);
            Type _type = result.GetType();            
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

        class Common
        {
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
                XElement xm = XElement.Parse(xmlString);
                Recursive(xm);
                XElement xmm = RemoveAllNamespaces(xm);
                return xmm.ToString();
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
}
