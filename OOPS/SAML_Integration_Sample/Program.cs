using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAML2;
using SAML2.Schema.Core;

namespace SAML_Integration_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Assertion _assertion = new Assertion();
            // Here we create some SAML assertion with ID and Issuer name. 
            Assertion assertion = new Assertion();
            assertion.Id = "AssertionID";
            assertion.Issuer.Value = "ISSUER";
            // Create some SAML subject. 
            Subject samlSubject = new Subject();
            samlSubject.Items = new object[] { "My Subject" };

            // 
            // Create one SAML attribute with few values. 
            List<SamlAttribute> attr = new List<SamlAttribute>();
            attr.Name = "http://daenet.eu/saml";
            attr.AttributeValue = new string[] { "Some Value 1" };
            //attr.AttributeValues.Add("Some Value 2");

            attr.Name = "My ATTR Value";

            // 
            // Now create the SAML statement containing one attribute and one subject. 
            AttributeStatement samlAttributeStatement = new AttributeStatement();
            samlAttributeStatement.Items = attr;
            samlAttributeStatement.SamlSubject = samlSubject;

            // Append the statement to the SAML assertion. 
            assertion.Statements.Add(samlAttributeStatement);

            //return assertion
            return assertion;

        }
    }
}
