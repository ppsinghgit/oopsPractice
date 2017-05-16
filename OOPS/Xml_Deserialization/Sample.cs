using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml_Deserialization
{
    //    <?xml version="1.0" encoding="utf-8" ?>
    //<soap:Envelope xmlns:soap="http://www.w3.org/2003/05/soap-envelope">
    //  <s:Header xmlns:s="http://www.w3.org/2003/05/soap-envelope">
    //  <ok>Fine</ok>
    //  </s:Header>
    //  <soap:Body>
    //    <exch:Response xmlns:exch="http://applicant-eligibility.ee.ffe.cms.gov/exchange/1.0">
    //      your inside the response 

    //    </exch:Response>
    //  </soap:Body>
    //</soap:Envelope>



    [Serializable, XmlRoot(ElementName = "Envelope", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class ApplicantEligibilityResponse
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }

    [Serializable, XmlRoot(ElementName = "Envelope", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/exchange/1.0")]
    public class Response
    {
        [XmlElement(ElementName = "ApplicantEligibilityResponse", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public ApplicantEligibilityResponse ApplicantEligibilityResponse { get; set; }

        [XmlAttribute(Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/exchange/1.0", AttributeName = "ContactID")]
        public int ContactID { get; set; }

    }

    [XmlRoot(ElementName = "Body")]
    public class Body
    {
        [XmlElement(ElementName = "Response", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/exchange/1.0")]
        public Response Response { get; set; }


        //[XmlAttribute]
       
    }

    [XmlRoot(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Header
    {
        public string ok { get; set; }
    }

    [Serializable, XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Sample
    {
        [XmlElement(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "Body")]
        public Body Body { get; set; }
    }

}
