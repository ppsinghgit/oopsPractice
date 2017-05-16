using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Decode_SAML
{
    [XmlRoot(ElementName = "Issuer")]
    public class Issuer
    {
        [XmlElement(ElementName = "Format")]
        public string Format { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CanonicalizationMethod")]
    public class CanonicalizationMethod
    {
        [XmlElement(ElementName = "Algorithm")]
        public string Algorithm { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SignatureMethod")]
    public class SignatureMethod
    {
        [XmlElement(ElementName = "Algorithm")]
        public string Algorithm { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Transform")]
    public class Transform
    {
        [XmlElement(ElementName = "Algorithm")]
        public string Algorithm { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Transforms")]
    public class Transforms
    {
        [XmlElement(ElementName = "Transform")]
        public List<Transform> Transform { get; set; }
    }

    [XmlRoot(ElementName = "DigestMethod")]
    public class DigestMethod
    {
        [XmlElement(ElementName = "Algorithm")]
        public string Algorithm { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Reference")]
    public class Reference
    {
        [XmlElement(ElementName = "URI")]
        public string URI { get; set; }
        [XmlElement(ElementName = "Transforms")]
        public Transforms Transforms { get; set; }
        [XmlElement(ElementName = "DigestMethod")]
        public DigestMethod DigestMethod { get; set; }
        [XmlElement(ElementName = "DigestValue")]
        public string DigestValue { get; set; }
    }

    [XmlRoot(ElementName = "SignedInfo")]
    public class SignedInfo
    {
        [XmlElement(ElementName = "CanonicalizationMethod")]
        public CanonicalizationMethod CanonicalizationMethod { get; set; }
        [XmlElement(ElementName = "SignatureMethod")]
        public SignatureMethod SignatureMethod { get; set; }
        [XmlElement(ElementName = "Reference")]
        public Reference Reference { get; set; }
    }

    [XmlRoot(ElementName = "X509Data")]
    public class X509Data
    {
        [XmlElement(ElementName = "X509Certificate")]
        public string X509Certificate { get; set; }
        [XmlElement(ElementName = "X509SubjectName")]
        public string X509SubjectName { get; set; }
    }

    [XmlRoot(ElementName = "KeyInfo")]
    public class KeyInfo
    {
        [XmlElement(ElementName = "X509Data")]
        public X509Data X509Data { get; set; }
        [XmlElement(ElementName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Signature")]
    public class Signature
    {
        [XmlElement(ElementName = "ds")]
        public string Ds { get; set; }
        [XmlElement(ElementName = "SignedInfo")]
        public SignedInfo SignedInfo { get; set; }
        [XmlElement(ElementName = "SignatureValue")]
        public string SignatureValue { get; set; }
        [XmlElement(ElementName = "KeyInfo")]
        public KeyInfo KeyInfo { get; set; }
    }

    [XmlRoot(ElementName = "StatusCode")]
    public class StatusCode
    {
        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Status")]
    public class Status
    {
        [XmlElement(ElementName = "StatusCode")]
        public StatusCode StatusCode { get; set; }
        [XmlElement(ElementName = "StatusMessage")]
        public string StatusMessage { get; set; }
    }

    [XmlRoot(ElementName = "NameID")]
    public class NameID
    {
        [XmlElement(ElementName = "NameQualifier")]
        public string NameQualifier { get; set; }
        [XmlElement(ElementName = "Format")]
        public string Format { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SubjectConfirmationData")]
    public class SubjectConfirmationData
    {
        [XmlElement(ElementName = "Recipient")]
        public string Recipient { get; set; }
        [XmlElement(ElementName = "NotOnOrAfter")]
        public string NotOnOrAfter { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SubjectConfirmation")]
    public class SubjectConfirmation
    {
        [XmlElement(ElementName = "Method")]
        public string Method { get; set; }
        [XmlElement(ElementName = "SubjectConfirmationData")]
        public SubjectConfirmationData SubjectConfirmationData { get; set; }
    }

    [XmlRoot(ElementName = "Subject")]
    public class Subject
    {
        [XmlElement(ElementName = "NameID")]
        public NameID NameID { get; set; }
        [XmlElement(ElementName = "SubjectConfirmation")]
        public SubjectConfirmation SubjectConfirmation { get; set; }
    }

    [XmlRoot(ElementName = "AudienceRestriction")]
    public class AudienceRestriction
    {
        [XmlElement(ElementName = "Audience")]
        public string Audience { get; set; }
    }

    [XmlRoot(ElementName = "Conditions")]
    public class Conditions
    {
        [XmlElement(ElementName = "NotOnOrAfter")]
        public string NotOnOrAfter { get; set; }
        [XmlElement(ElementName = "NotBefore")]
        public string NotBefore { get; set; }
        [XmlElement(ElementName = "AudienceRestriction")]
        public AudienceRestriction AudienceRestriction { get; set; }
    }

    [XmlRoot(ElementName = "Attribute")]
    public class Attribute
    {
        [XmlElement(ElementName = "NameFormat")]
        public string NameFormat { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "AttributeValue")]
        public string AttributeValue { get; set; }
    }

    [XmlRoot(ElementName = "AttributeStatement")]
    public class AttributeStatement
    {
        [XmlElement(ElementName = "Attribute")]
        public List<Attribute> Attribute { get; set; }
    }

    [XmlRoot(ElementName = "SubjectLocality")]
    public class SubjectLocality
    {
        [XmlElement(ElementName = "Address")]
        public string Address { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AuthnContext")]
    public class AuthnContext
    {
        [XmlElement(ElementName = "AuthnContextClassRef")]
        public string AuthnContextClassRef { get; set; }
    }

    [XmlRoot(ElementName = "AuthnStatement")]
    public class AuthnStatement
    {
        [XmlElement(ElementName = "AuthnInstant")]
        public string AuthnInstant { get; set; }
        [XmlElement(ElementName = "SubjectLocality")]
        public SubjectLocality SubjectLocality { get; set; }
        [XmlElement(ElementName = "AuthnContext")]
        public AuthnContext AuthnContext { get; set; }
    }

    [XmlRoot(ElementName = "Assertion")]
    public class Assertion
    {
        [XmlElement(ElementName = "saml2")]
        public string Saml2 { get; set; }
        [XmlElement(ElementName = "Version")]
        public string Version { get; set; }
        [XmlElement(ElementName = "IssueInstant")]
        public string IssueInstant { get; set; }
        [XmlElement(ElementName = "ID")]
        public string ID { get; set; }
        [XmlElement(ElementName = "Issuer")]
        public Issuer Issuer { get; set; }
        [XmlElement(ElementName = "Signature")]
        public Signature Signature { get; set; }
        [XmlElement(ElementName = "Subject")]
        public Subject Subject { get; set; }
        [XmlElement(ElementName = "Conditions")]
        public Conditions Conditions { get; set; }
        [XmlElement(ElementName = "AttributeStatement")]
        public AttributeStatement AttributeStatement { get; set; }
        [XmlElement(ElementName = "AuthnStatement")]
        public AuthnStatement AuthnStatement { get; set; }
    }

    [XmlRoot(ElementName = "Response")]
    public class Response
    {
        [XmlElement(ElementName = "samlp2")]
        public string Samlp2 { get; set; }
        [XmlElement(ElementName = "saml2")]
        public string Saml2 { get; set; }
        [XmlElement(ElementName = "Version")]
        public string Version { get; set; }
        [XmlElement(ElementName = "IssueInstant")]
        public string IssueInstant { get; set; }
        [XmlElement(ElementName = "ID")]
        public string ID { get; set; }
        [XmlElement(ElementName = "Destination")]
        public string Destination { get; set; }
        [XmlElement(ElementName = "Issuer")]
        public Issuer Issuer { get; set; }
        [XmlElement(ElementName = "Signature")]
        public Signature Signature { get; set; }
        [XmlElement(ElementName = "Status")]
        public Status Status { get; set; }
        [XmlElement(ElementName = "Assertion")]
        public Assertion Assertion { get; set; }
    }

}
