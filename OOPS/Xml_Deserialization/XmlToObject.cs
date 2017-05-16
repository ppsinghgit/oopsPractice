using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace XmlToObject
{
    [XmlRoot(ElementName = "Header")]
    public class Header
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RoleOfPersonReference")]
    public class RoleOfPersonReference
    {
        [XmlElement(ElementName = "ref")]
        public string Ref { get; set; }

        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplicantFinancialAssistanceIndicator")]
    public class InsuranceApplicantFinancialAssistanceIndicator
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IdentificationID")]
    public class IdentificationID
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IdentificationSourceText")]
    public class IdentificationSourceText
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExchangeAssignedInsuranceApplicantIdentification")]
    public class ExchangeAssignedInsuranceApplicantIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "ActivityDate")]
    public class ActivityDate
    {
        [XmlElement(ElementName = "Date")]
        public string Date { get; set; }
    }

    [XmlRoot(ElementName = "StartDate")]
    public class StartDate
    {
        [XmlElement(ElementName = "Date")]
        public string Date { get; set; }
    }

    [XmlRoot(ElementName = "EligibilityDateRange")]
    public class EligibilityDateRange
    {
        [XmlElement(ElementName = "StartDate")]
        public StartDate StartDate { get; set; }
        [XmlElement(ElementName = "EndDate")]
        public EndDate EndDate { get; set; }
    }

    [XmlRoot(ElementName = "EligibilityIndicator")]
    public class EligibilityIndicator
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExchangeEligibility")]
    public class ExchangeEligibility
    {
        [XmlElement(ElementName = "EligibilityDateRange")]
        public EligibilityDateRange EligibilityDateRange { get; set; }
        [XmlElement(ElementName = "EligibilityIndicator")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "ProgramEligibilityStatusCode")]
        public string ProgramEligibilityStatusCode { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePlanVariantCategoyNumericCode")]
    public class InsurancePlanVariantCategoyNumericCode
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CSREligibility")]
    public class CSREligibility
    {
        [XmlElement(ElementName = "EligibilityIndicator")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "ProgramEligibilityStatusCode")]
        public string ProgramEligibilityStatusCode { get; set; }
        [XmlElement(ElementName = "InsurancePlanVariantCategoyNumericCode")]
        public InsurancePlanVariantCategoyNumericCode InsurancePlanVariantCategoyNumericCode { get; set; }
    }

    [XmlRoot(ElementName = "CHIPEligibility")]
    public class CHIPEligibility
    {
        [XmlElement(ElementName = "EligibilityIndicator")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
    }

    [XmlRoot(ElementName = "APTCEligibility")]
    public class APTCEligibility
    {
        [XmlElement(ElementName = "EligibilityDateRange")]
        public EligibilityDateRange EligibilityDateRange { get; set; }
        [XmlElement(ElementName = "EligibilityIndicator")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "ProgramEligibilityStatusCode")]
        public string ProgramEligibilityStatusCode { get; set; }
        [XmlElement(ElementName = "MonthlyAPTCAmount")]
        public string MonthlyAPTCAmount { get; set; }
    }

    [XmlRoot(ElementName = "MedicaidEligibility")]
    public class MedicaidEligibility
    {
        [XmlElement(ElementName = "EligibilityIndicator")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "ProgramEligibilityStatusCode")]
        public string ProgramEligibilityStatusCode { get; set; }
    }

    [XmlRoot(ElementName = "ProgramEligibilitySnapshot")]
    public class ProgramEligibilitySnapshot
    {
        [XmlElement(ElementName = "ActivityDate")]
        public ActivityDate ActivityDate { get; set; }
        [XmlElement(ElementName = "ExchangeEligibility")]
        public ExchangeEligibility ExchangeEligibility { get; set; }
        [XmlElement(ElementName = "CSREligibility")]
        public CSREligibility CSREligibility { get; set; }
        [XmlElement(ElementName = "CHIPEligibility")]
        public CHIPEligibility CHIPEligibility { get; set; }
        [XmlElement(ElementName = "APTCEligibility")]
        public APTCEligibility APTCEligibility { get; set; }
        [XmlElement(ElementName = "MedicaidEligibility")]
        public MedicaidEligibility MedicaidEligibility { get; set; }
    }

    [XmlRoot(ElementName = "EndDate")]
    public class EndDate
    {
        [XmlElement(ElementName = "Date")]
        public string Date { get; set; }
    }

    [XmlRoot(ElementName = "Date")]
    public class Date
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }

    }

    [XmlRoot(ElementName = "EarliestQHPEffectiveDate")]
    public class EarliestQHPEffectiveDate
    {
        [XmlElement(ElementName = "Date")]
        public Date Date { get; set; }
    }

    [XmlRoot(ElementName = "LatestQHPEffectiveDate")]
    public class LatestQHPEffectiveDate
    {
        [XmlElement(ElementName = "Date")]
        public Date Date { get; set; }
    }

    [XmlRoot(ElementName = "InitialEnrollmentPeriodEligibility")]
    public class InitialEnrollmentPeriodEligibility
    {
        [XmlElement(ElementName = "EligibilityDateRange")]
        public EligibilityDateRange EligibilityDateRange { get; set; }
        [XmlElement(ElementName = "EligibilityIndicator")]
        public EligibilityIndicator EligibilityIndicator { get; set; }
        [XmlElement(ElementName = "EarliestQHPEffectiveDate")]
        public EarliestQHPEffectiveDate EarliestQHPEffectiveDate { get; set; }
        [XmlElement(ElementName = "LatestQHPEffectiveDate")]
        public LatestQHPEffectiveDate LatestQHPEffectiveDate { get; set; }
    }

    [XmlRoot(ElementName = "SpecialEnrollmentPeriodEligibility")]
    public class SpecialEnrollmentPeriodEligibility
    {
        [XmlElement(ElementName = "EligibilityIndicator")]
        public EligibilityIndicator EligibilityIndicator { get; set; }

        [XmlElement(ElementName = "EligibilityDateRange")]
        public EligibilityDateRange EligibilityDateRange { get; set; }

        [XmlElement(ElementName = "EarliestQHPEffectiveDate")]
        public EarliestQHPEffectiveDate EarliestQHPEffectiveDate { get; set; }

        [XmlElement(ElementName = "LatestQHPEffectiveDate")]
        public LatestQHPEffectiveDate LatestQHPEffectiveDate { get; set; }

        [XmlElement(ElementName = "SpecialEnrollmentPeriodEligibilityReasonCode")]
        public string SpecialEnrollmentPeriodEligibilityReasonCode { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplicant")]
    public class InsuranceApplicant
    {
        [XmlElement(ElementName = "id")]
        public string ID { get; set; }
        [XmlElement(ElementName = "RoleOfPersonReference")]
        public RoleOfPersonReference RoleOfPersonReference { get; set; }
        [XmlElement(ElementName = "InsuranceApplicantFinancialAssistanceIndicator")]
        public InsuranceApplicantFinancialAssistanceIndicator InsuranceApplicantFinancialAssistanceIndicator { get; set; }
        [XmlElement(ElementName = "ExchangeAssignedInsuranceApplicantIdentification")]
        public ExchangeAssignedInsuranceApplicantIdentification ExchangeAssignedInsuranceApplicantIdentification { get; set; }
        [XmlElement(ElementName = "ProgramEligibilitySnapshot")]
        public ProgramEligibilitySnapshot ProgramEligibilitySnapshot { get; set; }
        [XmlElement(ElementName = "InitialEnrollmentPeriodEligibility")]
        public InitialEnrollmentPeriodEligibility InitialEnrollmentPeriodEligibility { get; set; }
        [XmlElement(ElementName = "SpecialEnrollmentPeriodEligibility")]
        public SpecialEnrollmentPeriodEligibility SpecialEnrollmentPeriodEligibility { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplicationPrimaryContactReference")]
    public class InsuranceApplicationPrimaryContactReference
    {
        [XmlElement(ElementName = "ref")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "PrimaryTaxFilerPersonReference")]
    public class PrimaryTaxFilerPersonReference
    {
        [XmlElement(ElementName = "ref")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplication")]
    public class InsuranceApplication
    {
        [XmlElement(ElementName = "InsuranceApplicant")]
        public List<InsuranceApplicant> InsuranceApplicant { get; set; }
        [XmlElement(ElementName = "InsuranceApplicationPrimaryContactReference")]
        public InsuranceApplicationPrimaryContactReference InsuranceApplicationPrimaryContactReference { get; set; }
        [XmlElement(ElementName = "PrimaryTaxFilerPersonReference")]
        public PrimaryTaxFilerPersonReference PrimaryTaxFilerPersonReference { get; set; }
        [XmlElement(ElementName = "InsuranceApplicationMultipleTaxHouseholdIndicator")]
        public string InsuranceApplicationMultipleTaxHouseholdIndicator { get; set; }
    }

    [XmlRoot(ElementName = "ContactEmailID")]
    public class ContactEmailID
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ContactMainTelephoneNumber")]
    public class ContactMainTelephoneNumber
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ContactInformation")]
    public class ContactInformation
    {
        [XmlElement(ElementName = "id")]
        public string ID { get; set; }
        [XmlElement(ElementName = "ContactEmailID")]
        public ContactEmailID ContactEmailID { get; set; }
        [XmlElement(ElementName = "ContactMainTelephoneNumber")]
        public ContactMainTelephoneNumber ContactMainTelephoneNumber { get; set; }
        [XmlElement(ElementName = "ContactMobileTelephoneNumber")]
        public ContactMobileTelephoneNumber ContactMobileTelephoneNumber { get; set; }
        [XmlElement(ElementName = "ContactMailingAddress")]
        public ContactMailingAddress ContactMailingAddress { get; set; }
    }

    [XmlRoot(ElementName = "FullTelephoneNumber")]
    public class FullTelephoneNumber
    {
        [XmlElement(ElementName = "TelephoneNumberFullID")]
        public string TelephoneNumberFullID { get; set; }
    }

    [XmlRoot(ElementName = "ContactMobileTelephoneNumber")]
    public class ContactMobileTelephoneNumber
    {
        [XmlElement(ElementName = "FullTelephoneNumber")]
        public FullTelephoneNumber FullTelephoneNumber { get; set; }
    }

    [XmlRoot(ElementName = "LocationStreet")]
    public class LocationStreet
    {
        [XmlElement(ElementName = "StreetFullText")]
        public string StreetFullText { get; set; }
    }

    [XmlRoot(ElementName = "StructuredAddress")]
    public class StructuredAddress
    {
        [XmlElement(ElementName = "LocationStreet")]
        public LocationStreet LocationStreet { get; set; }
        [XmlElement(ElementName = "AddressSecondaryUnitText")]
        public string AddressSecondaryUnitText { get; set; }
        [XmlElement(ElementName = "LocationCityName")]
        public string LocationCityName { get; set; }
        [XmlElement(ElementName = "LocationCountyName")]
        public string LocationCountyName { get; set; }
        [XmlElement(ElementName = "LocationCountyCode")]
        public string LocationCountyCode { get; set; }
        [XmlElement(ElementName = "LocationStateUSPostalServiceCode")]
        public string LocationStateUSPostalServiceCode { get; set; }
        [XmlElement(ElementName = "LocationPostalCode")]
        public string LocationPostalCode { get; set; }
    }

    [XmlRoot(ElementName = "ContactMailingAddress")]
    public class ContactMailingAddress
    {
        [XmlElement(ElementName = "StructuredAddress")]
        public StructuredAddress StructuredAddress { get; set; }
    }

    [XmlRoot(ElementName = "PersonBirthDate")]
    public class PersonBirthDate
    {
        [XmlElement(ElementName = "Date")]
        public string Date { get; set; }
    }

    [XmlRoot(ElementName = "PersonName")]
    public class PersonName
    {
        [XmlElement(ElementName = "PersonGivenName")]
        public string PersonGivenName { get; set; }
        [XmlElement(ElementName = "PersonSurName")]
        public string PersonSurName { get; set; }
    }

    [XmlRoot(ElementName = "PersonSexCode")]
    public class PersonSexCode
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PersonSSNIdentification")]
    public class PersonSSNIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public string IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public string IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "PersonReference")]
    public class PersonReference
    {
        [XmlElement(ElementName = "ref")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "PersonAssociation")]
    public class PersonAssociation
    {
        [XmlElement(ElementName = "PersonReference")]
        public PersonReference PersonReference { get; set; }
        [XmlElement(ElementName = "FamilyRelationshipCode")]
        public string FamilyRelationshipCode { get; set; }
    }

    [XmlRoot(ElementName = "ContactInformationReference")]
    public class ContactInformationReference
    {
        [XmlElement(ElementName = "ref")]
        public string Ref { get; set; }
    }

    [XmlRoot(ElementName = "PersonContactInformationAssociation")]
    public class PersonContactInformationAssociation
    {
        [XmlElement(ElementName = "ContactInformationReference")]
        public ContactInformationReference ContactInformationReference { get; set; }
        [XmlElement(ElementName = "ContactInformationCategoryCode")]
        public string ContactInformationCategoryCode { get; set; }
        [XmlElement(ElementName = "AddressTypeCode")]
        public string AddressTypeCode { get; set; }
        [XmlElement(ElementName = "ContactInformationIsHomeIndicator")]
        public ContactInformationIsHomeIndicator ContactInformationIsHomeIndicator { get; set; }
    }

    [XmlRoot(ElementName = "ContactInformationIsHomeIndicator")]
    public class ContactInformationIsHomeIndicator
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LanguageName")]
    public class LanguageName
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PersonSpeaksLanguageIndicator")]
    public class PersonSpeaksLanguageIndicator
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PersonWritesLanguageIndicator")]
    public class PersonWritesLanguageIndicator
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PersonPreferredLanguage")]
    public class PersonPreferredLanguage
    {
        [XmlElement(ElementName = "LanguageName")]
        public LanguageName LanguageName { get; set; }
        [XmlElement(ElementName = "PersonSpeaksLanguageIndicator")]
        public PersonSpeaksLanguageIndicator PersonSpeaksLanguageIndicator { get; set; }
        [XmlElement(ElementName = "PersonWritesLanguageIndicator")]
        public PersonWritesLanguageIndicator PersonWritesLanguageIndicator { get; set; }
    }

    [XmlRoot(ElementName = "PersonAugmentation")]
    public class PersonAugmentation
    {
        [XmlElement(ElementName = "PersonAssociation")]
        public List<PersonAssociation> PersonAssociation { get; set; }
        [XmlElement(ElementName = "PersonContactInformationAssociation")]
        public List<PersonContactInformationAssociation> PersonContactInformationAssociation { get; set; }
        [XmlElement(ElementName = "PersonPreferredLanguage")]
        public List<PersonPreferredLanguage> PersonPreferredLanguage { get; set; }
    }

    [XmlRoot(ElementName = "Person")]
    public class Person
    {
        [XmlElement(ElementName = "id")]
        public string ID { get; set; }
        [XmlElement(ElementName = "PersonBirthDate")]
        public PersonBirthDate PersonBirthDate { get; set; }
        [XmlElement(ElementName = "PersonName")]
        public PersonName PersonName { get; set; }
        [XmlElement(ElementName = "PersonSexCode")]
        public PersonSexCode PersonSexCode { get; set; }
        [XmlElement(ElementName = "PersonSSNIdentification")]
        public PersonSSNIdentification PersonSSNIdentification { get; set; }
        [XmlElement(ElementName = "PersonAugmentation")]
        public PersonAugmentation PersonAugmentation { get; set; }
        [XmlElement(ElementName = "PersonMarriedIndicator")]
        public string PersonMarriedIndicator { get; set; }
    }

    [XmlRoot(ElementName = "InformationExchangeSystemStateCode")]
    public class InformationExchangeSystemStateCode
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InformationExchangeSystemIdentification")]
    public class InformationExchangeSystemIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "PartnerWebSiteInformationExchangeSystem")]
    public class PartnerWebSiteInformationExchangeSystem
    {
        [XmlElement(ElementName = "InformationExchangeSystemStateCode")]
        public InformationExchangeSystemStateCode InformationExchangeSystemStateCode { get; set; }
        [XmlElement(ElementName = "InformationExchangeSystemIdentification")]
        public InformationExchangeSystemIdentification InformationExchangeSystemIdentification { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContactElectronicNoticeIndicator")]
    public class SSFPrimaryContactElectronicNoticeIndicator
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContactElectronicNoticePreferenceCode")]
    public class SSFPrimaryContactElectronicNoticePreferenceCode
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContact")]
    public class SSFPrimaryContact
    {
        [XmlElement(ElementName = "RoleOfPersonReference")]
        public RoleOfPersonReference RoleOfPersonReference { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContactElectronicNoticeIndicator")]
        public SSFPrimaryContactElectronicNoticeIndicator SSFPrimaryContactElectronicNoticeIndicator { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContactElectronicNoticePreferenceCode")]
        public SSFPrimaryContactElectronicNoticePreferenceCode SSFPrimaryContactElectronicNoticePreferenceCode { get; set; }
        [XmlElement(ElementName = "ContactMobileTelephoneNumber")]
        public ContactMobileTelephoneNumber ContactMobileTelephoneNumber { get; set; }
        [XmlElement(ElementName = "ContactEmailID")]
        public ContactEmailID ContactEmailID { get; set; }
    }

    [XmlRoot(ElementName = "ApplicantEligibilityResponse")]
    public class ApplicantEligibilityResponse
    {
        [XmlElement(ElementName = "InsuranceApplication")]
        public InsuranceApplication InsuranceApplication { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public List<ContactInformation> ContactInformation { get; set; }
        [XmlElement(ElementName = "Person")]
        public List<Person> Person { get; set; }
        [XmlElement(ElementName = "PartnerWebSiteInformationExchangeSystem")]
        public PartnerWebSiteInformationExchangeSystem PartnerWebSiteInformationExchangeSystem { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContact")]
        public SSFPrimaryContact SSFPrimaryContact { get; set; }
    }

    [XmlRoot("ResponseDescriptionText")]
    public class ResponseDescriptionText
    {
        [XmlElement("Text")]
        public string Text { get; set; }
    }

    [XmlRoot("ResponseCode")]
    public class ResponseCode
    {
        [XmlElement("Text")]
        public string Text { get; set; }
    }

    [XmlRoot("TDSResponseDescriptionText")]
    public class TDSResponseDescriptionText
    {
        [XmlElement("Text")]
        public string Text { get; set; }
    }

    [XmlRoot("ResponseMetadata")]
    public class ResponseMetadata
    {
        [XmlElement("ResponseDescriptionText")]
        public ResponseDescriptionText ResponseDescriptionText { get; set; }

        [XmlElement("ResponseCode")]
        public ResponseCode ResponseCode { get; set; }

        [XmlElement("TDSResponseDescriptionText")]
        public TDSResponseDescriptionText TDSResponseDescriptionText { get; set; }
    }

    [XmlRoot(ElementName = "Response")]
    public class Response
    {
        [XmlElement(ElementName = "ApplicantEligibilityResponse")]
        public ApplicantEligibilityResponse ApplicantEligibilityResponse { get; set; }

        [XmlElement(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata { get; set; }
    }

    [XmlRoot(ElementName = "Body")]
    public class Body
    {
        [XmlElement(ElementName = "Response")]
        public Response Response { get; set; }
    }

    [XmlRoot(ElementName = "Envelope")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "Body")]
        public Body Body { get; set; }
    }

}

