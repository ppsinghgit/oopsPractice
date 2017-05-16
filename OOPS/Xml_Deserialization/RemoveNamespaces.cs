﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Xml_Deserialization
{
    public class RemoveNamespaces
    {
        public static string RemoveAllNamespaces(string xmlDocument)
        {
            XElement xmlDocumentWithoutNs = RemoveAllNamespaces(XElement.Parse(xmlDocument));

            return xmlDocumentWithoutNs.ToString();
        }

        //Core recursion function
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
            if (xmlDocument.Name.LocalName.ToUpper() == "PERSON")
            {
                object value = "";
                foreach (XAttribute attribute in xmlDocument.Attributes())
                {
                    if (attribute.Name.LocalName.ToUpper() == "ID")
                        value = attribute.Value;
                }
                XElement data = new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
                data.Add(new XElement("ID", value));
                return data;
            }

            if (xmlDocument.Name.LocalName.ToUpper() == "CONTACTINFORMATION")
            {
                object value = "";
                foreach (XAttribute attribute in xmlDocument.Attributes())
                {
                    if (attribute.Name.LocalName.ToUpper() == "ID")
                        value = attribute.Value;
                }
                XElement data = new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
                data.Add(new XElement("ID", value));
                return data;
            }
            return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
        }
    }
}
