using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
    [XmlRoot(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Header
    {
        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S { get; set; }
    }

    [XmlRoot(ElementName = "RoleOfPersonReference", Namespace = "http://hix.cms.gov/0.1/hix-core")]
    public class RoleOfPersonReference
    {
        [XmlAttribute(AttributeName = "hix-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixcore { get; set; }
        [XmlAttribute(AttributeName = "ref", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplicantFinancialAssistanceIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
    public class InsuranceApplicantFinancialAssistanceIndicator
    {
        [XmlAttribute(AttributeName = "hix-ee", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixee { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IdentificationID", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class IdentificationID
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IdentificationSourceText", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class IdentificationSourceText
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "ExchangeAssignedInsuranceApplicantIdentification", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class ExchangeAssignedInsuranceApplicantIdentification
    {
        [XmlElement(ElementName = "IdentificationID", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "ActivityDate", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class ActivityDate
    {
        [XmlElement(ElementName = "Date", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "StartDate", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class StartDate
    {
        [XmlElement(ElementName = "Date", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "EligibilityDateRange", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
    public class EligibilityDateRange
    {
        [XmlElement(ElementName = "StartDate", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public StartDate StartDate { get; set; }
        [XmlAttribute(AttributeName = "hix-ee", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixee { get; set; }
        [XmlElement(ElementName = "EndDate", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public EndDate EndDate { get; set; }
    }

    [XmlRoot(ElementName = "EligibilityIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
    public class EligibilityIndicator
    {
        [XmlAttribute(AttributeName = "hix-ee", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixee { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExchangeEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class ExchangeEligibility
    {
        [XmlElement(ElementName = "EligibilityDateRange", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityDateRange EligibilityDateRange { get; set; }
        [XmlElement(ElementName = "EligibilityIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "ProgramEligibilityStatusCode", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public string ProgramEligibilityStatusCode { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePlanVariantCategoyNumericCode", Namespace = "http://hix.cms.gov/0.1/hix-pm")]
    public class InsurancePlanVariantCategoyNumericCode
    {
        [XmlAttribute(AttributeName = "hix-pm", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixpm { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CSREligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class CSREligibility
    {
        [XmlElement(ElementName = "EligibilityIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "ProgramEligibilityStatusCode", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public string ProgramEligibilityStatusCode { get; set; }
        [XmlElement(ElementName = "InsurancePlanVariantCategoyNumericCode", Namespace = "http://hix.cms.gov/0.1/hix-pm")]
        public InsurancePlanVariantCategoyNumericCode InsurancePlanVariantCategoyNumericCode { get; set; }
    }

    [XmlRoot(ElementName = "CHIPEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class CHIPEligibility
    {
        [XmlElement(ElementName = "EligibilityIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
    }

    [XmlRoot(ElementName = "APTCEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class APTCEligibility
    {
        [XmlElement(ElementName = "EligibilityDateRange", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityDateRange EligibilityDateRange { get; set; }
        [XmlElement(ElementName = "EligibilityIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "ProgramEligibilityStatusCode", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public string ProgramEligibilityStatusCode { get; set; }
        [XmlElement(ElementName = "MonthlyAPTCAmount", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public string MonthlyAPTCAmount { get; set; }
    }

    [XmlRoot(ElementName = "MedicaidEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class MedicaidEligibility
    {
        [XmlElement(ElementName = "EligibilityIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "ProgramEligibilityStatusCode", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public string ProgramEligibilityStatusCode { get; set; }
    }

    [XmlRoot(ElementName = "ProgramEligibilitySnapshot", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class ProgramEligibilitySnapshot
    {
        [XmlElement(ElementName = "ActivityDate", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public ActivityDate ActivityDate { get; set; }
        [XmlElement(ElementName = "ExchangeEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public ExchangeEligibility ExchangeEligibility { get; set; }
        [XmlElement(ElementName = "CSREligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public CSREligibility CSREligibility { get; set; }
        [XmlElement(ElementName = "CHIPEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public CHIPEligibility CHIPEligibility { get; set; }
        [XmlElement(ElementName = "APTCEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public APTCEligibility APTCEligibility { get; set; }
        [XmlElement(ElementName = "MedicaidEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public MedicaidEligibility MedicaidEligibility { get; set; }
    }

    [XmlRoot(ElementName = "EndDate", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class EndDate
    {
        [XmlElement(ElementName = "Date", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "Date", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class Date
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EarliestQHPEffectiveDate", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class EarliestQHPEffectiveDate
    {
        [XmlElement(ElementName = "Date", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public Date Date { get; set; }
    }

    [XmlRoot(ElementName = "LatestQHPEffectiveDate", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class LatestQHPEffectiveDate
    {
        [XmlElement(ElementName = "Date", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public Date Date { get; set; }
    }

    [XmlRoot(ElementName = "InitialEnrollmentPeriodEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class InitialEnrollmentPeriodEligibility
    {
        [XmlElement(ElementName = "EligibilityDateRange", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityDateRange EligibilityDateRange { get; set; }
        [XmlElement(ElementName = "EligibilityIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "EarliestQHPEffectiveDate", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public EarliestQHPEffectiveDate EarliestQHPEffectiveDate { get; set; }
        [XmlElement(ElementName = "LatestQHPEffectiveDate", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public LatestQHPEffectiveDate LatestQHPEffectiveDate { get; set; }
    }

    [XmlRoot(ElementName = "SpecialEnrollmentPeriodEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class SpecialEnrollmentPeriodEligibility
    {
        [XmlElement(ElementName = "EligibilityIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplicant", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class InsuranceApplicant
    {
        [XmlElement(ElementName = "RoleOfPersonReference", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public RoleOfPersonReference RoleOfPersonReference { get; set; }
        [XmlElement(ElementName = "InsuranceApplicantFinancialAssistanceIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public InsuranceApplicantFinancialAssistanceIndicator InsuranceApplicantFinancialAssistanceIndicator { get; set; }
        [XmlElement(ElementName = "ExchangeAssignedInsuranceApplicantIdentification", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public ExchangeAssignedInsuranceApplicantIdentification ExchangeAssignedInsuranceApplicantIdentification { get; set; }
        [XmlElement(ElementName = "ProgramEligibilitySnapshot", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public ProgramEligibilitySnapshot ProgramEligibilitySnapshot { get; set; }
        [XmlElement(ElementName = "InitialEnrollmentPeriodEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public InitialEnrollmentPeriodEligibility InitialEnrollmentPeriodEligibility { get; set; }
        [XmlElement(ElementName = "SpecialEnrollmentPeriodEligibility", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public SpecialEnrollmentPeriodEligibility SpecialEnrollmentPeriodEligibility { get; set; }
        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S { get; set; }
        [XmlAttribute(AttributeName = "id", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplicationPrimaryContactReference", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
    public class InsuranceApplicationPrimaryContactReference
    {
        [XmlAttribute(AttributeName = "hix-ee", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixee { get; set; }
        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S { get; set; }
        [XmlAttribute(AttributeName = "ref", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "PrimaryTaxFilerPersonReference", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class PrimaryTaxFilerPersonReference
    {
        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S { get; set; }
        [XmlAttribute(AttributeName = "ref", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplication", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class InsuranceApplication
    {
        [XmlElement(ElementName = "InsuranceApplicant", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public InsuranceApplicant InsuranceApplicant { get; set; }
        [XmlElement(ElementName = "InsuranceApplicationPrimaryContactReference", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public InsuranceApplicationPrimaryContactReference InsuranceApplicationPrimaryContactReference { get; set; }
        [XmlElement(ElementName = "PrimaryTaxFilerPersonReference", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public PrimaryTaxFilerPersonReference PrimaryTaxFilerPersonReference { get; set; }
        [XmlElement(ElementName = "InsuranceApplicationMultipleTaxHouseholdIndicator", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public string InsuranceApplicationMultipleTaxHouseholdIndicator { get; set; }
    }

    [XmlRoot(ElementName = "ContactEmailID", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class ContactEmailID
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ContactMainTelephoneNumber", Namespace = "http://hix.cms.gov/0.1/hix-core")]
    public class ContactMainTelephoneNumber
    {
        [XmlAttribute(AttributeName = "hix-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixcore { get; set; }
    }

    [XmlRoot(ElementName = "ContactInformation", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class ContactInformation
    {
        [XmlElement(ElementName = "ContactEmailID", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public ContactEmailID ContactEmailID { get; set; }
        [XmlElement(ElementName = "ContactMainTelephoneNumber", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public ContactMainTelephoneNumber ContactMainTelephoneNumber { get; set; }
        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S { get; set; }
        [XmlAttribute(AttributeName = "id", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Id { get; set; }
        [XmlElement(ElementName = "ContactMobileTelephoneNumber", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public ContactMobileTelephoneNumber ContactMobileTelephoneNumber { get; set; }
        [XmlElement(ElementName = "ContactMailingAddress", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public ContactMailingAddress ContactMailingAddress { get; set; }
    }

    [XmlRoot(ElementName = "FullTelephoneNumber", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class FullTelephoneNumber
    {
        [XmlElement(ElementName = "TelephoneNumberFullID", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string TelephoneNumberFullID { get; set; }
    }

    [XmlRoot(ElementName = "ContactMobileTelephoneNumber", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class ContactMobileTelephoneNumber
    {
        [XmlElement(ElementName = "FullTelephoneNumber", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public FullTelephoneNumber FullTelephoneNumber { get; set; }
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "LocationStreet", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class LocationStreet
    {
        [XmlElement(ElementName = "StreetFullText", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string StreetFullText { get; set; }
    }

    [XmlRoot(ElementName = "StructuredAddress", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class StructuredAddress
    {
        [XmlElement(ElementName = "LocationStreet", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public LocationStreet LocationStreet { get; set; }
        [XmlElement(ElementName = "AddressSecondaryUnitText", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string AddressSecondaryUnitText { get; set; }
        [XmlElement(ElementName = "LocationCityName", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string LocationCityName { get; set; }
        [XmlElement(ElementName = "LocationCountyName", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string LocationCountyName { get; set; }
        [XmlElement(ElementName = "LocationCountyCode", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string LocationCountyCode { get; set; }
        [XmlElement(ElementName = "LocationStateUSPostalServiceCode", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string LocationStateUSPostalServiceCode { get; set; }
        [XmlElement(ElementName = "LocationPostalCode", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string LocationPostalCode { get; set; }
    }

    [XmlRoot(ElementName = "ContactMailingAddress", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class ContactMailingAddress
    {
        [XmlElement(ElementName = "StructuredAddress", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public StructuredAddress StructuredAddress { get; set; }
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "PersonBirthDate", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class PersonBirthDate
    {
        [XmlElement(ElementName = "Date", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "PersonName", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class PersonName
    {
        [XmlElement(ElementName = "PersonGivenName", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string PersonGivenName { get; set; }
        [XmlElement(ElementName = "PersonSurName", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string PersonSurName { get; set; }
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "PersonSexCode", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class PersonSexCode
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PersonSSNIdentification", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class PersonSSNIdentification
    {
        [XmlElement(ElementName = "IdentificationID", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string IdentificationSourceText { get; set; }
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
    }

    [XmlRoot(ElementName = "PersonReference", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class PersonReference
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlAttribute(AttributeName = "ref", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "PersonAssociation", Namespace = "http://hix.cms.gov/0.1/hix-core")]
    public class PersonAssociation
    {
        [XmlElement(ElementName = "PersonReference", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public PersonReference PersonReference { get; set; }
        [XmlElement(ElementName = "FamilyRelationshipCode", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public string FamilyRelationshipCode { get; set; }
    }

    [XmlRoot(ElementName = "ContactInformationReference", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class ContactInformationReference
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlAttribute(AttributeName = "ref", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "PersonContactInformationAssociation", Namespace = "http://hix.cms.gov/0.1/hix-core")]
    public class PersonContactInformationAssociation
    {
        [XmlElement(ElementName = "ContactInformationReference", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public ContactInformationReference ContactInformationReference { get; set; }
        [XmlElement(ElementName = "ContactInformationCategoryCode", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public string ContactInformationCategoryCode { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Type { get; set; }
        [XmlElement(ElementName = "AddressTypeCode", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public string AddressTypeCode { get; set; }
        [XmlElement(ElementName = "ContactInformationIsHomeIndicator", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public ContactInformationIsHomeIndicator ContactInformationIsHomeIndicator { get; set; }
    }

    [XmlRoot(ElementName = "ContactInformationIsHomeIndicator", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class ContactInformationIsHomeIndicator
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LanguageName", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class LanguageName
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PersonSpeaksLanguageIndicator", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class PersonSpeaksLanguageIndicator
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PersonWritesLanguageIndicator", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class PersonWritesLanguageIndicator
    {
        [XmlAttribute(AttributeName = "niem-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Niemcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PersonPreferredLanguage", Namespace = "http://hix.cms.gov/0.1/hix-core")]
    public class PersonPreferredLanguage
    {
        [XmlElement(ElementName = "LanguageName", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public LanguageName LanguageName { get; set; }
        [XmlElement(ElementName = "PersonSpeaksLanguageIndicator", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public PersonSpeaksLanguageIndicator PersonSpeaksLanguageIndicator { get; set; }
        [XmlElement(ElementName = "PersonWritesLanguageIndicator", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public PersonWritesLanguageIndicator PersonWritesLanguageIndicator { get; set; }
    }

    [XmlRoot(ElementName = "PersonAugmentation", Namespace = "http://hix.cms.gov/0.1/hix-core")]
    public class PersonAugmentation
    {
        [XmlElement(ElementName = "PersonAssociation", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public PersonAssociation PersonAssociation { get; set; }
        [XmlElement(ElementName = "PersonContactInformationAssociation", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public List<PersonContactInformationAssociation> PersonContactInformationAssociation { get; set; }
        [XmlElement(ElementName = "PersonPreferredLanguage", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public List<PersonPreferredLanguage> PersonPreferredLanguage { get; set; }
        [XmlAttribute(AttributeName = "hix-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixcore { get; set; }
    }

    [XmlRoot(ElementName = "Person", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class Person
    {
        [XmlElement(ElementName = "PersonBirthDate", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public PersonBirthDate PersonBirthDate { get; set; }
        [XmlElement(ElementName = "PersonName", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public PersonName PersonName { get; set; }
        [XmlElement(ElementName = "PersonSexCode", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public PersonSexCode PersonSexCode { get; set; }
        [XmlElement(ElementName = "PersonSSNIdentification", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public PersonSSNIdentification PersonSSNIdentification { get; set; }
        [XmlElement(ElementName = "PersonAugmentation", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public PersonAugmentation PersonAugmentation { get; set; }
        [XmlElement(ElementName = "PersonMarriedIndicator", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public string PersonMarriedIndicator { get; set; }
        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S { get; set; }
        [XmlAttribute(AttributeName = "id", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "InformationExchangeSystemStateCode", Namespace = "http://hix.cms.gov/0.1/hix-core")]
    public class InformationExchangeSystemStateCode
    {
        [XmlAttribute(AttributeName = "hix-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixcore { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InformationExchangeSystemIdentification", Namespace = "http://hix.cms.gov/0.1/hix-core")]
    public class InformationExchangeSystemIdentification
    {
        [XmlElement(ElementName = "IdentificationID", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
        [XmlAttribute(AttributeName = "hix-core", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixcore { get; set; }
    }

    [XmlRoot(ElementName = "PartnerWebSiteInformationExchangeSystem", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class PartnerWebSiteInformationExchangeSystem
    {
        [XmlElement(ElementName = "InformationExchangeSystemStateCode", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public InformationExchangeSystemStateCode InformationExchangeSystemStateCode { get; set; }
        [XmlElement(ElementName = "InformationExchangeSystemIdentification", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public InformationExchangeSystemIdentification InformationExchangeSystemIdentification { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContactElectronicNoticeIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
    public class SSFPrimaryContactElectronicNoticeIndicator
    {
        [XmlAttribute(AttributeName = "hix-ee", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixee { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContactElectronicNoticePreferenceCode", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
    public class SSFPrimaryContactElectronicNoticePreferenceCode
    {
        [XmlAttribute(AttributeName = "hix-ee", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Hixee { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContact", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class SSFPrimaryContact
    {
        [XmlElement(ElementName = "RoleOfPersonReference", Namespace = "http://hix.cms.gov/0.1/hix-core")]
        public RoleOfPersonReference RoleOfPersonReference { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContactElectronicNoticeIndicator", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public SSFPrimaryContactElectronicNoticeIndicator SSFPrimaryContactElectronicNoticeIndicator { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContactElectronicNoticePreferenceCode", Namespace = "http://hix.cms.gov/0.1/hix-ee")]
        public SSFPrimaryContactElectronicNoticePreferenceCode SSFPrimaryContactElectronicNoticePreferenceCode { get; set; }
        [XmlElement(ElementName = "ContactMobileTelephoneNumber", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public ContactMobileTelephoneNumber ContactMobileTelephoneNumber { get; set; }
        [XmlElement(ElementName = "ContactEmailID", Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public ContactEmailID ContactEmailID { get; set; }
        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S { get; set; }
        [XmlAttribute(AttributeName = "id", Namespace = "http://niem.gov/niem/structures/2.0")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "ApplicantEligibilityResponse", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
    public class ApplicantEligibilityResponse
    {
        [XmlElement(ElementName = "InsuranceApplication", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public InsuranceApplication InsuranceApplication { get; set; }
        [XmlElement(ElementName = "ContactInformation", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public List<ContactInformation> ContactInformation { get; set; }
        [XmlElement(ElementName = "Person", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public Person Person { get; set; }
        [XmlElement(ElementName = "PartnerWebSiteInformationExchangeSystem", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public PartnerWebSiteInformationExchangeSystem PartnerWebSiteInformationExchangeSystem { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContact", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public SSFPrimaryContact SSFPrimaryContact { get; set; }
        [XmlAttribute(AttributeName = "ext", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ext { get; set; }
    }

    [XmlRoot(ElementName = "Response", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/exchange/1.0")]
    public class Response
    {
        [XmlElement(ElementName = "ApplicantEligibilityResponse", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/extension/1.0")]
        public ApplicantEligibilityResponse ApplicantEligibilityResponse { get; set; }
        [XmlAttribute(AttributeName = "exch", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Exch { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Body
    {
        [XmlElement(ElementName = "Response", Namespace = "http://applicant-eligibility.ee.ffe.cms.gov/exchange/1.0")]
        public Response Response { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soap { get; set; }
    }

}
