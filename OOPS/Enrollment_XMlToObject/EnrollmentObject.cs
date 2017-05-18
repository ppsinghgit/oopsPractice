using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Enrollment_XMlToObject
{
    [XmlRoot(ElementName = "Header")]
    public class Header
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InformationExchangeSystemStateCode")]
    public class InformationExchangeSystemStateCode
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

    [XmlRoot(ElementName = "ExchangeInformationExchangeSystem")]
    public class ExchangeInformationExchangeSystem
    {
        [XmlElement(ElementName = "InformationExchangeSystemStateCode")]
        public InformationExchangeSystemStateCode InformationExchangeSystemStateCode { get; set; }
        [XmlElement(ElementName = "InformationExchangeSystemIdentification")]
        public InformationExchangeSystemIdentification InformationExchangeSystemIdentification { get; set; }
    }

    [XmlRoot(ElementName = "PersonBirthDate")]
    public class PersonBirthDate
    {
        [XmlElement(ElementName = "Date")]
        public string Date { get; set; }
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

    [XmlRoot(ElementName = "Person")]
    public class Person
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "PersonBirthDate")]
        public PersonBirthDate PersonBirthDate { get; set; }
        [XmlElement(ElementName = "PersonSexCode")]
        public PersonSexCode PersonSexCode { get; set; }
        [XmlElement(ElementName = "PersonSSNIdentification")]
        public PersonSSNIdentification PersonSSNIdentification { get; set; }
    }

    [XmlRoot(ElementName = "RoleOfPersonReference")]
    public class RoleOfPersonReference
    {
        [XmlElement(ElementName = "ref")]
        public string Ref { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContactExchangeAssignedIdentification")]
    public class SSFPrimaryContactExchangeAssignedIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContactPartnerAssignedIdentification")]
    public class SSFPrimaryContactPartnerAssignedIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "AttestationMetadata")]
    public class AttestationMetadata
    {
        [XmlElement(ElementName = "APTCAttestationProvidedIndicator")]
        public string APTCAttestationProvidedIndicator { get; set; }
    }

    [XmlRoot(ElementName = "SSFPrimaryContact")]
    public class SSFPrimaryContact
    {
        [XmlElement(ElementName = "RoleOfPersonReference")]
        public RoleOfPersonReference RoleOfPersonReference { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContactExchangeAssignedIdentification")]
        public SSFPrimaryContactExchangeAssignedIdentification SSFPrimaryContactExchangeAssignedIdentification { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContactPartnerAssignedIdentification")]
        public SSFPrimaryContactPartnerAssignedIdentification SSFPrimaryContactPartnerAssignedIdentification { get; set; }
        [XmlElement(ElementName = "AttestationMetadata")]
        public AttestationMetadata AttestationMetadata { get; set; }
    }

    [XmlRoot(ElementName = "Date")]
    public class Date
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ActionEffectiveDate")]
    public class ActionEffectiveDate
    {
        [XmlElement(ElementName = "Date")]
        public Date Date { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePremiumAmount")]
    public class InsurancePremiumAmount
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RateAreaIdentification")]
    public class RateAreaIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
    }

    [XmlRoot(ElementName = "RateArea")]
    public class RateArea
    {
        [XmlElement(ElementName = "RateAreaIdentification")]
        public RateAreaIdentification RateAreaIdentification { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePlanVariantCategoryNumericCode")]
    public class InsurancePlanVariantCategoryNumericCode
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AffectedInsurancePremium")]
    public class AffectedInsurancePremium
    {
        [XmlElement(ElementName = "InsurancePremiumAmount")]
        public InsurancePremiumAmount InsurancePremiumAmount { get; set; }
        [XmlElement(ElementName = "InsurancePremiumElectedAPTCAmount")]
        public string InsurancePremiumElectedAPTCAmount { get; set; }
        [XmlElement(ElementName = "RateArea")]
        public RateArea RateArea { get; set; }
        [XmlElement(ElementName = "InsurancePlanVariantCategoryNumericCode")]
        public InsurancePlanVariantCategoryNumericCode InsurancePlanVariantCategoryNumericCode { get; set; }
        [XmlElement(ElementName = "InsurancePremiumIndividualResponsibilityTotalAmount")]
        public string InsurancePremiumIndividualResponsibilityTotalAmount { get; set; }
    }

    [XmlRoot(ElementName = "ExchangeAssignedInsuranceApplicantIdentification")]
    public class ExchangeAssignedInsuranceApplicantIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceApplicant")]
    public class InsuranceApplicant
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "RoleOfPersonReference")]
        public RoleOfPersonReference RoleOfPersonReference { get; set; }
        [XmlElement(ElementName = "ExchangeAssignedInsuranceApplicantIdentification")]
        public ExchangeAssignedInsuranceApplicantIdentification ExchangeAssignedInsuranceApplicantIdentification { get; set; }
        [XmlElement(ElementName = "TobaccoUseIndicator")]
        public string TobaccoUseIndicator { get; set; }
        [XmlElement(ElementName = "ProposedSubscriberIndicator")]
        public string ProposedSubscriberIndicator { get; set; }
        [XmlElement(ElementName = "EnrollmentPeriodCode")]
        public string EnrollmentPeriodCode { get; set; }
        [XmlElement(ElementName = "RelationshipToSubscriberCode")]
        public string RelationshipToSubscriberCode { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePlanStandardComponentIdentification")]
    public class InsurancePlanStandardComponentIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePlanVariantIdentification")]
    public class InsurancePlanVariantIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePlanVariant")]
    public class InsurancePlanVariant
    {
        [XmlElement(ElementName = "InsurancePlanVariantIdentification")]
        public InsurancePlanVariantIdentification InsurancePlanVariantIdentification { get; set; }
    }

    [XmlRoot(ElementName = "IssuerIdentification")]
    public class IssuerIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
        [XmlElement(ElementName = "IdentificationSourceText")]
        public IdentificationSourceText IdentificationSourceText { get; set; }
    }

    [XmlRoot(ElementName = "Issuer")]
    public class Issuer
    {
        [XmlElement(ElementName = "IssuerIdentification")]
        public IssuerIdentification IssuerIdentification { get; set; }
    }

    [XmlRoot(ElementName = "SelectedInsurancePlan")]
    public class SelectedInsurancePlan
    {
        [XmlElement(ElementName = "InsurancePlanStandardComponentIdentification")]
        public InsurancePlanStandardComponentIdentification InsurancePlanStandardComponentIdentification { get; set; }
        [XmlElement(ElementName = "InsurancePlanVariant")]
        public InsurancePlanVariant InsurancePlanVariant { get; set; }
        [XmlElement(ElementName = "Issuer")]
        public Issuer Issuer { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePolicyEffectiveDate")]
    public class InsurancePolicyEffectiveDate
    {
        [XmlElement(ElementName = "Date")]
        public Date Date { get; set; }
    }

    [XmlRoot(ElementName = "EnrollmentGroup")]
    public class EnrollmentGroup
    {
        [XmlElement(ElementName = "InsuranceApplicant")]
        public InsuranceApplicant InsuranceApplicant { get; set; }
        [XmlElement(ElementName = "SelectedInsurancePlan")]
        public SelectedInsurancePlan SelectedInsurancePlan { get; set; }
        [XmlElement(ElementName = "InsurancePolicyEffectiveDate")]
        public InsurancePolicyEffectiveDate InsurancePolicyEffectiveDate { get; set; }
    }

    [XmlRoot(ElementName = "PolicyCreationActivity")]
    public class PolicyCreationActivity
    {
        [XmlElement(ElementName = "metadata")]
        public string Metadata { get; set; }
        [XmlElement(ElementName = "ActionEffectiveDate")]
        public ActionEffectiveDate ActionEffectiveDate { get; set; }
        [XmlElement(ElementName = "AffectedInsurancePremium")]
        public AffectedInsurancePremium AffectedInsurancePremium { get; set; }
        [XmlElement(ElementName = "EnrollmentGroup")]
        public EnrollmentGroup EnrollmentGroup { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePolicyExpirationDate")]
    public class InsurancePolicyExpirationDate
    {
        [XmlElement(ElementName = "Date")]
        public Date Date { get; set; }
    }

    [XmlRoot(ElementName = "ExchangeAssignedInsuranceMemberIdentification")]
    public class ExchangeAssignedInsuranceMemberIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
    }

    [XmlRoot(ElementName = "OriginatingInsuranceApplicantReference")]
    public class OriginatingInsuranceApplicantReference
    {
        [XmlElement(ElementName = "ref")]
        public string Ref { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceMember")]
    public class InsuranceMember
    {
        [XmlElement(ElementName = "ExchangeAssignedInsuranceMemberIdentification")]
        public ExchangeAssignedInsuranceMemberIdentification ExchangeAssignedInsuranceMemberIdentification { get; set; }
        [XmlElement(ElementName = "RoleOfPersonReference")]
        public RoleOfPersonReference RoleOfPersonReference { get; set; }
        [XmlElement(ElementName = "OriginatingInsuranceApplicantReference")]
        public OriginatingInsuranceApplicantReference OriginatingInsuranceApplicantReference { get; set; }
        [XmlElement(ElementName = "TobaccoUseIndicator")]
        public string TobaccoUseIndicator { get; set; }
        [XmlElement(ElementName = "RelationshipToSubscriberCode")]
        public string RelationshipToSubscriberCode { get; set; }
    }

    [XmlRoot(ElementName = "ExchangeAssignedInsurancePolicyIdentification")]
    public class ExchangeAssignedInsurancePolicyIdentification
    {
        [XmlElement(ElementName = "IdentificationID")]
        public IdentificationID IdentificationID { get; set; }
    }

    [XmlRoot(ElementName = "InsurancePlan")]
    public class InsurancePlan
    {
        [XmlElement(ElementName = "InsurancePlanStandardComponentIdentification")]
        public InsurancePlanStandardComponentIdentification InsurancePlanStandardComponentIdentification { get; set; }
        [XmlElement(ElementName = "InsurancePlanVariant")]
        public InsurancePlanVariant InsurancePlanVariant { get; set; }
        [XmlElement(ElementName = "Issuer")]
        public Issuer Issuer { get; set; }
    }

    [XmlRoot(ElementName = "CreatedInsurancePolicy")]
    public class CreatedInsurancePolicy
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "InsurancePolicyEffectiveDate")]
        public InsurancePolicyEffectiveDate InsurancePolicyEffectiveDate { get; set; }
        [XmlElement(ElementName = "InsurancePolicyExpirationDate")]
        public InsurancePolicyExpirationDate InsurancePolicyExpirationDate { get; set; }
        [XmlElement(ElementName = "InsuranceMember")]
        public InsuranceMember InsuranceMember { get; set; }
        [XmlElement(ElementName = "ExchangeAssignedInsurancePolicyIdentification")]
        public ExchangeAssignedInsurancePolicyIdentification ExchangeAssignedInsurancePolicyIdentification { get; set; }
        [XmlElement(ElementName = "InsurancePlan")]
        public InsurancePlan InsurancePlan { get; set; }
    }

    [XmlRoot(ElementName = "CorrectedInsurancePremium")]
    public class CorrectedInsurancePremium
    {
        [XmlElement(ElementName = "InsurancePremiumAmount")]
        public InsurancePremiumAmount InsurancePremiumAmount { get; set; }

        [XmlElement(ElementName = "InsurancePremiumAppliedAPTCAmount")]
        public string InsurancePremiumAppliedAPTCAmount { get; set; }

        [XmlElement(ElementName = "RateArea")]
        public RateArea RateArea { get; set; }
    }

    [XmlRoot(ElementName = "PolicyActivityMetadata")]
    public class PolicyActivityMetadata
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "CreatedInsurancePolicy")]
        public CreatedInsurancePolicy CreatedInsurancePolicy { get; set; }
        [XmlElement(ElementName = "PolicyActivityResponseCode")]
        public string PolicyActivityResponseCode { get; set; }
        [XmlElement(ElementName = "PaymentTransactionID")]
        public string PaymentTransactionID { get; set; }
        [XmlElement(ElementName = "CorrectedInsurancePremium")]
        public CorrectedInsurancePremium CorrectedInsurancePremium { get; set; }
    }

    [XmlRoot(ElementName = "ApplicantEnrollmentResponse")]
    public class ApplicantEnrollmentResponse
    {
        [XmlElement(ElementName = "PartnerWebSiteInformationExchangeSystem")]
        public PartnerWebSiteInformationExchangeSystem PartnerWebSiteInformationExchangeSystem { get; set; }
        [XmlElement(ElementName = "ExchangeInformationExchangeSystem")]
        public ExchangeInformationExchangeSystem ExchangeInformationExchangeSystem { get; set; }
        [XmlElement(ElementName = "Person")]
        public List<Person> Person { get; set; }
        [XmlElement(ElementName = "SSFPrimaryContact")]
        public SSFPrimaryContact SSFPrimaryContact { get; set; }
        [XmlElement(ElementName = "PolicyCreationActivity")]
        public PolicyCreationActivity PolicyCreationActivity { get; set; }
        [XmlElement(ElementName = "PolicyActivityMetadata")]
        public PolicyActivityMetadata PolicyActivityMetadata { get; set; }
        [XmlElement(ElementName = "InsuranceMemberActivityMetadata")]
        public InsuranceMemberActivityMetadata InsuranceMemberActivityMetadata { get; set; }
    }

    [XmlRoot(ElementName = "InsuranceMemberActivityMetadata")]
    public class InsuranceMemberActivityMetadata
    {
        [XmlElement(ElementName = "InsuranceMemberActivityResponseCode")]
        public string InsuranceMemberActivityResponseCode { get; set; }
    }

    [XmlRoot(ElementName = "Response")]
    public class Response
    {
        [XmlElement(ElementName = "ApplicantEnrollmentResponse")]
        public ApplicantEnrollmentResponse ApplicantEnrollmentResponse { get; set; }
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
        [XmlElement(ElementName = "soap")]
        public string Soap { get; set; }
        [XmlElement(ElementName = "Header")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "Body")]
        public Body Body { get; set; }
    }
}
