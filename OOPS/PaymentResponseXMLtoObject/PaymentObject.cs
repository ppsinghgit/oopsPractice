using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PaymentResponseXMLtoObject
{
    [XmlRoot(ElementName = "Attribute")]
    public class Attribute
    {
        #region Private Fields
        string _name = "";
        #endregion
        [XmlElement(ElementName = "Name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) { _name = value.Replace(" ", "").ToUpper(); }
            }
        }
        [XmlElement(ElementName = "AttributeValue")]
        public string AttributeValue { get; set; }
    }

    [XmlRoot(ElementName = "AttributeStatement")]
    public class AttributeStatement
    {
        [XmlElement(ElementName = "Attribute")]
        public List<Attribute> Attribute { get; set; }
    }

    [XmlRoot(ElementName = "Assertion")]
    public class Assertion
    {
        [XmlElement(ElementName = "AttributeStatement")]
        public AttributeStatement AttributeStatement { get; set; }
    }

    [XmlRoot(ElementName = "Response")]
    public class Response
    {
        [XmlElement(ElementName = "Assertion")]
        public Assertion Assertion { get; set; }
    }

}
