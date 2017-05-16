using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Enrollment_XMlToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("MemberNotOnApplication_Error.xml", FileMode.Open, FileAccess.Read);
            XmlDocument doc = new XmlDocument();
            doc.Load(fs);
            string xml = AttributeToElement(doc.InnerXml);
            //samldata = samldata.Replace(@"\", "");
            var stringReader = new System.IO.StringReader(xml);

            var serializer = new XmlSerializer(typeof(Envelope));
            Envelope result = (Envelope)serializer.Deserialize(stringReader);

            BackgroundWorker _worker=new BackgroundWorker();
            _worker.DoWork += _worker_DoWork;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _worker.WorkerSupportsCancellation = true;
            _worker.RunWorkerAsync();
            if (_worker.IsBusy) 
            {
                _worker.CancelAsync();
            }

        }

        static void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Cancelled) 
            {

            }
        }

        static void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static string RemoveAllNamespaces(string xmlDocument)
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
            return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
        }

        private static string AttributeToElement(string xmlString)
        {
            XElement xm = XElement.Parse(xmlString);
            Recursive(xm);
            XElement xmm = RemoveAllNamespaces(xm);
            return xmm.ToString();
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
    }


}
