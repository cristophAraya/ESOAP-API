using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza
{
    public class ConsultaPolizaResult
    {
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("policyName")]

        public long PolicyName { get; set; }

        [JsonProperty("policyNames")]
        public PolicyNames PolicyNames { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("staffId")]
        public long StaffId { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("clientId")]
        public long ClientId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("policyState")]
        public long PolicyState { get; set; }

        [JsonProperty("convertDate")]
        public DateTimeOffset ConvertDate { get; set; }

        [JsonProperty("productLob")]
        public string ProductLob { get; set; }

        [JsonProperty("durDimension")]
        public string DurDimension { get; set; }

        [JsonProperty("dateGiven")]
        public DateTimeOffset DateGiven { get; set; }

        [JsonProperty("conclusionDate")]
        public DateTimeOffset ConclusionDate { get; set; }

        [JsonProperty("dateCovered")]
        public string DateCovered { get; set; }

        [JsonProperty("tariffRule")]
        public string TariffRule { get; set; }

        [JsonProperty("renewableFlag")]

        public long RenewableFlag { get; set; }

        [JsonProperty("policyLot")]
        public string PolicyLot { get; set; }

        [JsonProperty("retroactDate")]
        public DateTimeOffset RetroactDate { get; set; }

        [JsonProperty("policyStateAux")]
        public long PolicyStateAux { get; set; }

        [JsonProperty("paymentWay")]

        public long PaymentWay { get; set; }

        [JsonProperty("insrEnd")]
        public DateTimeOffset InsrEnd { get; set; }

        [JsonProperty("numInstalments")]
        public long NumInstalments { get; set; }

        [JsonProperty("policyNo")]

        public long PolicyNo { get; set; }

        [JsonProperty("paymentType")]

        public long PaymentType { get; set; }

        [JsonProperty("insrBegin")]
        public DateTimeOffset InsrBegin { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("agentId")]
        public long AgentId { get; set; }

        [JsonProperty("officeId")]
        public long OfficeId { get; set; }

        [JsonProperty("attr4")]
        public string Attr4 { get; set; }

        [JsonProperty("policyYear")]
        public long PolicyYear { get; set; }

        [JsonProperty("insrDuration")]
        public long InsrDuration { get; set; }

        [JsonProperty("paymentDuration")]
        public long PaymentDuration { get; set; }

        [JsonProperty("paymentDurDim")]
        public string PaymentDurDim { get; set; }

        [JsonProperty("policyAnnexes")]
        public PolicyAnnex[] PolicyAnnexes { get; set; }

        [JsonProperty("pAgents")]
        public PAgents PAgents { get; set; }

        [JsonProperty("pClients")]
        public PClients PClients { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class PAgents
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("agentId")]
        public long AgentId { get; set; }

        [JsonProperty("agentNo")]
        public string AgentNo { get; set; }

        [JsonProperty("agentState")]

        public long AgentState { get; set; }

        [JsonProperty("agentType")]
        public long AgentType { get; set; }

        [JsonProperty("contractMonths")]
        public string ContractMonths { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("defaultAgent")]

        public long DefaultAgent { get; set; }

        [JsonProperty("fireDate")]
        public string FireDate { get; set; }

        [JsonProperty("hireDate")]
        public DateTimeOffset HireDate { get; set; }

        [JsonProperty("leavingReason")]
        public string LeavingReason { get; set; }

        [JsonProperty("mainAgent")]
        public long MainAgent { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("officeId")]
        public long OfficeId { get; set; }

        [JsonProperty("oldAgentNo")]
        public string OldAgentNo { get; set; }

        [JsonProperty("prevJobConfirmDate")]
        public string PrevJobConfirmDate { get; set; }

        [JsonProperty("qualifLevel")]

        public long QualifLevel { get; set; }

        [JsonProperty("pPeopleComplex")]
        public PPeopleComplex PPeopleComplex { get; set; }
    }

    public partial class PPeopleComplex
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("manComp")]
        public long ManComp { get; set; }

        [JsonProperty("birthDate")]
        public DateTimeOffset? BirthDate { get; set; }

        [JsonProperty("egn")]

        public long Egn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gname")]
        public string Gname { get; set; }

        [JsonProperty("sname")]
        public string Sname { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("sex")]
        public long Sex { get; set; }

        [JsonProperty("namePrefix")]
        public string NamePrefix { get; set; }

        [JsonProperty("nameSuffix")]
        public string NameSuffix { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("homeCountry")]
        public string HomeCountry { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("classCode")]
        public string ClassCode { get; set; }

        [JsonProperty("classSubCode")]
        public string ClassSubCode { get; set; }

        [JsonProperty("compType")]
        public string CompType { get; set; }

        [JsonProperty("dataSource")]
        public string DataSource { get; set; }

        [JsonProperty("fiscalPeriod")]
        public string FiscalPeriod { get; set; }

        [JsonProperty("industryCode")]
        public string IndustryCode { get; set; }

        [JsonProperty("subIndustryCode")]
        public string SubIndustryCode { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("attr1")]
        public string Attr1 { get; set; }

        [JsonProperty("attr2")]
        public string Attr2 { get; set; }

        [JsonProperty("attr3")]
        public string Attr3 { get; set; }

        [JsonProperty("attr4")]
        public string Attr4 { get; set; }

        [JsonProperty("attr5")]
        public string Attr5 { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("questions")]
        public Question[] Questions { get; set; }

        [JsonProperty("peopleGroups")]
        public string[] PeopleGroups { get; set; }

        [JsonProperty("contactPersons")]
        public string[] ContactPersons { get; set; }

        [JsonProperty("relations1")]
        public string[] Relations1 { get; set; }

        [JsonProperty("relations2")]
        public string[] Relations2 { get; set; }

        [JsonProperty("bankAccounts")]
        public BankAccount[] BankAccounts { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("addressId")]
        public long AddressId { get; set; }

        [JsonProperty("addressType")]
        public string AddressType { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("address")]
        public string AddressAddress { get; set; }

        [JsonProperty("apartmentNumber")]
        public string ApartmentNumber { get; set; }

        [JsonProperty("blockNumber")]
        public string BlockNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cityCode")]
        public string CityCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryState")]

        public string CountryState { get; set; }

        [JsonProperty("entranceNumber")]
        public string EntranceNumber { get; set; }

        [JsonProperty("floorNumber")]
        public string FloorNumber { get; set; }

        [JsonProperty("invoiceYn")]
        public string InvoiceYn { get; set; }

        [JsonProperty("mailYn")]
        public string MailYn { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }

    

        [JsonProperty("quarterId")]

        public string QuarterId { get; set; }

        [JsonProperty("quarterName")]
        public string QuarterName { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("stateRegion")]

        public string StateRegion { get; set; }

        [JsonProperty("streetId")]
        public string StreetId { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("streetNumber")]

        public string StreetNumber { get; set; }

        [JsonProperty("territoryClassification")]
        public string TerritoryClassification { get; set; }

        [JsonProperty("usageDateFrom")]
        public string UsageDateFrom { get; set; }

        [JsonProperty("usageDateTo")]
        public string UsageDateTo { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("personPid")]
        public Pid PersonPid { get; set; }
    }

    public partial class Pid
    {
        [JsonProperty("egn")]
        public string Egn { get; set; }

        [JsonProperty("manComp")]
        public long ManComp { get; set; }
    }

    public partial class BankAccount
    {
        [JsonProperty("accountCurrency")]
        public string AccountCurrency { get; set; }

        [JsonProperty("accountNum")]
        public string AccountNum { get; set; }

        [JsonProperty("accountState")]
        public long AccountState { get; set; }

        [JsonProperty("bankAccId")]
        public long BankAccId { get; set; }

        [JsonProperty("bankId")]
        public long BankId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }



        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("personPid")]
        public Pid PersonPid { get; set; }

        [JsonProperty("pBanks")]
        public PBanks PBanks { get; set; }
    }

    public partial class PBanks
    {
        [JsonProperty("bankCode")]

        public long BankCode { get; set; }

        [JsonProperty("bankId")]
        public long BankId { get; set; }

        [JsonProperty("mainBankId")]
        public string MainBankId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("swiftCode")]
        public string SwiftCode { get; set; }

        [JsonProperty("bankPid")]
        public Pid BankPid { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("contactId")]
        public long ContactId { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }



        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("personPid")]
        public Pid PersonPid { get; set; }
    }

    public partial class Document
    {
        [JsonProperty("annexId")]
        public string AnnexId { get; set; }

        [JsonProperty("certifyEvent")]
        public string CertifyEvent { get; set; }

        [JsonProperty("changeDate")]
        public DateTimeOffset ChangeDate { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("claimId")]
        public string ClaimId { get; set; }

        [JsonProperty("claimObjSeq")]
        public string ClaimObjSeq { get; set; }

        [JsonProperty("docDate")]
        public string DocDate { get; set; }

        [JsonProperty("docDays")]
        public string DocDays { get; set; }

        [JsonProperty("docDescription")]
        public string DocDescription { get; set; }

        [JsonProperty("docHolderAddr")]
        public string DocHolderAddr { get; set; }

        [JsonProperty("docHolderName")]
        public string DocHolderName { get; set; }

        [JsonProperty("docId")]
        public string DocId { get; set; }

        [JsonProperty("docName")]
        public string DocName { get; set; }

        [JsonProperty("docNum")]
        public string DocNum { get; set; }

        [JsonProperty("docSeq")]
        public double DocSeq { get; set; }

        [JsonProperty("docSerial")]
        public string DocSerial { get; set; }

        [JsonProperty("docState")]
        public long DocState { get; set; }

        [JsonProperty("docValidTo")]
        public string DocValidTo { get; set; }

        [JsonProperty("documentRef")]
        public string DocumentRef { get; set; }

        [JsonProperty("grcId")]
        public string GrcId { get; set; }

        [JsonProperty("insuredId")]
        public string InsuredId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("stringId")]
        public string stringId { get; set; }

        [JsonProperty("pholderId")]
        public string PholderId { get; set; }

        [JsonProperty("policyId")]
        public string PolicyId { get; set; }

        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        [JsonProperty("receiveDate")]
        public DateTimeOffset ReceiveDate { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("requiredFrom")]
        public string RequiredFrom { get; set; }

        [JsonProperty("requiredManId")]
        public string RequiredManId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        [JsonProperty("cfgDocName")]
        public string CfgDocName { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public partial class Question
    {
        [JsonProperty("annexId")]
        public string AnnexId { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("changeDate")]
        public DateTimeOffset ChangeDate { get; set; }

        [JsonProperty("claimId")]
        public string ClaimId { get; set; }

        [JsonProperty("claimObjSeq")]
        public string ClaimObjSeq { get; set; }

        [JsonProperty("grcId")]
        public string GrcId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("insuredId")]
        public string InsuredId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("stringId")]
        public string stringId { get; set; }

        [JsonProperty("pholderId")]
        public string PholderId { get; set; }

        [JsonProperty("policyId")]
        public string PolicyId { get; set; }

        [JsonProperty("questAnswer")]

        public long QuestAnswer { get; set; }

        [JsonProperty("questId")]
        public string QuestId { get; set; }

        [JsonProperty("questOrder")]
        public long QuestOrder { get; set; }

        [JsonProperty("questWeight")]
        public string QuestWeight { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class PClients
    {
        [JsonProperty("acceptMarketInfo")]
        public string AcceptMarketInfo { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("clientId")]
        public long ClientId { get; set; }

        [JsonProperty("corporateIcStatus")]
        public string CorporateIcStatus { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("employeeStatus")]
        public string EmployeeStatus { get; set; }

        [JsonProperty("icStatus")]
        public string IcStatus { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("officialStatus")]
        public string OfficialStatus { get; set; }

        [JsonProperty("profitability")]
        public string Profitability { get; set; }

        [JsonProperty("riskRating")]
        public string RiskRating { get; set; }

        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("pPeopleComplex")]
        public PPeopleComplex PPeopleComplex { get; set; }
    }

    public partial class PolicyAnnex
    {
        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("insuredObjects")]
        public InsuredObject[] InsuredObjects { get; set; }

        [JsonProperty("policyParticipants")]
        public PolicyParticipant[] PolicyParticipants { get; set; }

        [JsonProperty("policyConditions")]
        public string[] PolicyConditions { get; set; }

        [JsonProperty("policyContacts")]
        public PolicyContact[] PolicyContacts { get; set; }

        [JsonProperty("commissions")]
        public Commission[] Commissions { get; set; }

        [JsonProperty("policyAddresses")]
        public PolicyAddress[] PolicyAddresses { get; set; }

        [JsonProperty("policyBankAccounts")]
        public string[] PolicyBankAccounts { get; set; }

        [JsonProperty("policyEndorsements")]
        public string[] PolicyEndorsements { get; set; }

        [JsonProperty("policyEngBillings")]
        public PolicyEngBilling[] PolicyEngBillings { get; set; }

        [JsonProperty("policyAgents")]
        public PolicyAgent[] PolicyAgents { get; set; }

        [JsonProperty("discounts")]
        public string[] Discounts { get; set; }

        [JsonProperty("taxes")]
        public string[] Taxes { get; set; }

        [JsonProperty("limits")]
        public string[] Limits { get; set; }

        [JsonProperty("paymentPlan")]
        public PaymentPlan[] PaymentPlan { get; set; }

        [JsonProperty("installments")]
        public Installment[] Installments { get; set; }

        [JsonProperty("questions")]
        public string[] Questions { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }
    }

    public partial class Commission
    {
        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("commDimension")]
        public string CommDimension { get; set; }

        [JsonProperty("commType")]
        public string CommType { get; set; }

        [JsonProperty("commValue")]
        public long CommValue { get; set; }

        [JsonProperty("coverType")]
        public string CoverType { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("holdCommission")]
        public string HoldCommission { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("onInstall")]
        public string OnInstall { get; set; }

        [JsonProperty("policyCommissionId")]
        public long PolicyCommissionId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("policyYear")]
        public long PolicyYear { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public DateTimeOffset ValidTo { get; set; }

        [JsonProperty("insuredObjId")]
        public string InsuredObjId { get; set; }

        [JsonProperty("grcId")]
        public string GrcId { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("attrc1")]
        public string Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public string Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public string Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public string Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public string Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public string Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public string Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public string Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public string Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public string Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public string Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public string Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public string Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public string Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public string Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public string Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public string Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public string Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public string Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public string Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public string Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public string Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public string Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public string Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public string Attrn9 { get; set; }
    }

    public partial class Installment
    {
        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("amntLocal")]
        public long AmntLocal { get; set; }

        [JsonProperty("amntCurrency")]
        public long AmntCurrency { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("oldCovered")]
        public DateTimeOffset OldCovered { get; set; }

        [JsonProperty("dateCovered")]
        public string DateCovered { get; set; }

        [JsonProperty("dateTopay")]
        public DateTimeOffset DateTopay { get; set; }

        [JsonProperty("accountState")]
        public long AccountState { get; set; }

        [JsonProperty("accountType")]
        public long AccountType { get; set; }
    }

    public partial class InsuredObject
    {
        [JsonProperty("insuredObjId")]
        public long InsuredObjId { get; set; }

        [JsonProperty("groupSeqNum")]
        public string GroupSeqNum { get; set; }

        [JsonProperty("attachedToGroup")]
        public string AttachedToGroup { get; set; }

        [JsonProperty("stringId")]
        public long stringId { get; set; }

        [JsonProperty("stringType")]
        public long stringType { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("stringState")]
        public long stringState { get; set; }

        [JsonProperty("stringStateAux")]
        public long stringStateAux { get; set; }

        [JsonProperty("riskClass")]
        public string RiskClass { get; set; }

        [JsonProperty("stringNum")]
        public long stringNum { get; set; }

        [JsonProperty("stringAlive")]
        public long stringAlive { get; set; }

        [JsonProperty("actualValue")]
        public long ActualValue { get; set; }

        [JsonProperty("avCurrency")]
        public string AvCurrency { get; set; }

        [JsonProperty("avCurrencyRate")]
        public double AvCurrencyRate { get; set; }

        [JsonProperty("insuredValue")]
        public long InsuredValue { get; set; }

        [JsonProperty("ivType")]
        public string IvType { get; set; }

        [JsonProperty("ivBase")]

        public long IvBase { get; set; }

        [JsonProperty("ivCurrency")]
        public string IvCurrency { get; set; }

        [JsonProperty("ivCurrencyRate")]
        public double IvCurrencyRate { get; set; }

        [JsonProperty("activityType")]
        public string ActivityType { get; set; }

        [JsonProperty("totalInsuredValue")]
        public long TotalInsuredValue { get; set; }

        [JsonProperty("insrBegin")]
        public DateTimeOffset InsrBegin { get; set; }

        [JsonProperty("insrEnd")]
        public DateTimeOffset InsrEnd { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("durDimension")]
        public string DurDimension { get; set; }

        [JsonProperty("changeDate")]
        public DateTimeOffset ChangeDate { get; set; }

        [JsonProperty("iop1")]
        public string Iop1 { get; set; }

        [JsonProperty("iop2")]
        public string Iop2 { get; set; }

        [JsonProperty("iop3")]
        public string Iop3 { get; set; }

        [JsonProperty("riskLocationId")]
        public string RiskLocationId { get; set; }

        [JsonProperty("locationRiskClass")]
        public string LocationRiskClass { get; set; }

        [JsonProperty("locationValue")]
        public string LocationValue { get; set; }

        [JsonProperty("locvalDimension")]
        public string LocvalDimension { get; set; }

        [JsonProperty("billingId")]
        public string BillingId { get; set; }

        [JsonProperty("mainInsObjId")]
        public string MainInsObjId { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("subgroupId")]
        public string SubgroupId { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("attrc1")]
        public string Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public string Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public string Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public string Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public string Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public string Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public string Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public string Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public string Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public string Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public string Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public string Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public string Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public string Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public string Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public string Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public string Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public string Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public string Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public string Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public string Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public string Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public string Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public string Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public string Attrn9 { get; set; }

        [JsonProperty("covers")]
        public Cover[] Covers { get; set; }

        [JsonProperty("discounts")]
        public string[] Discounts { get; set; }

        [JsonProperty("limits")]
        public string[] Limits { get; set; }

        [JsonProperty("commissions")]
        public string[] Commissions { get; set; }

        [JsonProperty("policyParticipantsDtl")]
        public string[] PolicyParticipantsDtl { get; set; }

        [JsonProperty("policyEngBillingsDtl")]
        public string[] PolicyEngBillingsDtl { get; set; }

        [JsonProperty("insuredstringSuppl")]
        public string[] InsuredstringSuppl { get; set; }

        [JsonProperty("insuredEntity")]
        public InsuredEntity InsuredEntity { get; set; }

        [JsonProperty("questions")]
        public string[] Questions { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }
    }

    public partial class Cover
    {
        [JsonProperty("grcId")]
        public long GrcId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("insuredObjId")]
        public long InsuredObjId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("coverType")]
        public string CoverType { get; set; }

        [JsonProperty("coverDescription")]
        public string CoverDescription { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("insuredValue")]
        public long InsuredValue { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyRate")]
        public long CurrencyRate { get; set; }

        [JsonProperty("premium")]
        public long Premium { get; set; }

        [JsonProperty("manualPremDimension")]
        public string ManualPremDimension { get; set; }

        [JsonProperty("tariffPercent")]
        public long TariffPercent { get; set; }

        [JsonProperty("stringNum")]
        public long stringNum { get; set; }

        [JsonProperty("fullPremium")]
        public long FullPremium { get; set; }

        [JsonProperty("addPremium")]
        public long AddPremium { get; set; }

        [JsonProperty("discount")]
        public long Discount { get; set; }

        [JsonProperty("insrBegin")]
        public DateTimeOffset InsrBegin { get; set; }

        [JsonProperty("insrEnd")]
        public DateTimeOffset InsrEnd { get; set; }

        [JsonProperty("riskState")]
        public long RiskState { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("durDimension")]
        public string DurDimension { get; set; }

        [JsonProperty("coverOrder")]
        public long? CoverOrder { get; set; }

        [JsonProperty("dateCovered")]
        public string DateCovered { get; set; }

        [JsonProperty("annualPremium")]
        public long AnnualPremium { get; set; }

        [JsonProperty("riAmountSubject")]
        public string RiAmountSubject { get; set; }

        [JsonProperty("rateFullPremium")]
        public long RateFullPremium { get; set; }

        [JsonProperty("rateAnnualPremium")]
        public long RateAnnualPremium { get; set; }

        [JsonProperty("packageId")]
        public string PackageId { get; set; }

        [JsonProperty("locationValue")]
        public string LocationValue { get; set; }

        [JsonProperty("locvalDimension")]
        public string LocvalDimension { get; set; }

        [JsonProperty("selectedCover")]
        public string SelectedCover { get; set; }

        [JsonProperty("netPremium")]
        public long NetPremium { get; set; }

        [JsonProperty("anniversary")]
        public DateTimeOffset Anniversary { get; set; }

        [JsonProperty("claimstringType")]
        public long ClaimstringType { get; set; }

        [JsonProperty("ivType")]
        public string IvType { get; set; }

        [JsonProperty("riskClass")]
        public string RiskClass { get; set; }

        [JsonProperty("coverPaymentSource")]
        public string CoverPaymentSource { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("grcSrv1")]
        public string GrcSrv1 { get; set; }

        [JsonProperty("grcSrv2")]
        public string GrcSrv2 { get; set; }

        [JsonProperty("grcSrv3")]
        public string GrcSrv3 { get; set; }

        [JsonProperty("waiver")]
        public string Waiver { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("grcOrgId")]
        public long GrcOrgId { get; set; }

        [JsonProperty("grcRefId")]
        public string GrcRefId { get; set; }

        [JsonProperty("sliceType")]
        public string SliceType { get; set; }

        [JsonProperty("coverLob")]
        public string CoverLob { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("subgroupId")]
        public string SubgroupId { get; set; }

        [JsonProperty("tariffRule")]
        public string TariffRule { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("attrc1")]
        public string Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public string Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public string Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public string Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public string Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public string Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public string Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public string Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public string Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public string Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public string Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public string Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public string Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public string Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public string Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public string Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public string Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public string Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public string Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public string Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public string Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public string Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public string Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public string Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public string Attrn9 { get; set; }

        [JsonProperty("risks")]
        public string[] Risks { get; set; }

        [JsonProperty("invAccounts")]
        public string[] InvAccounts { get; set; }

        [JsonProperty("discounts")]
        public string[] Discounts { get; set; }

        [JsonProperty("taxes")]
        public string[] Taxes { get; set; }

        [JsonProperty("limits")]
        public string[] Limits { get; set; }

        [JsonProperty("commissions")]
        public string[] Commissions { get; set; }

        [JsonProperty("policyParticipantsDtl")]
        public string[] PolicyParticipantsDtl { get; set; }

        [JsonProperty("policyEngBillingsDtl")]
        public string[] PolicyEngBillingsDtl { get; set; }

        [JsonProperty("policyEndorsements")]
        public string[] PolicyEndorsements { get; set; }
    }

    public partial class InsuredEntity
    {
        [JsonProperty("stringId")]
        public long stringId { get; set; }

        [JsonProperty("stringType")]
        public long stringType { get; set; }

        [JsonProperty("oAccinsured")]
        public string OAccinsured { get; set; }

        [JsonProperty("oCar")]
        public OCar OCar { get; set; }

        [JsonProperty("oProperty")]
        public string OProperty { get; set; }

        [JsonProperty("oLoss")]
        public string OLoss { get; set; }

        [JsonProperty("oGroupIns")]
        public string OGroupIns { get; set; }

        [JsonProperty("oLiability")]
        public string OLiability { get; set; }
    }

    public partial class OCar
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("stringId")]
        public long stringId { get; set; }

        [JsonProperty("carType")]

        public long CarType { get; set; }

        [JsonProperty("carSubtype")]

        public long CarSubtype { get; set; }

        [JsonProperty("regNo")]
        public string RegNo { get; set; }

        [JsonProperty("chassis")]
        public string Chassis { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]

        public string Model { get; set; }

        [JsonProperty("modification")]
        public string Modification { get; set; }

        [JsonProperty("ccmTon")]
        public string CcmTon { get; set; }

        [JsonProperty("tonage")]
        public string Tonage { get; set; }

        [JsonProperty("carUsage")]
        public string CarUsage { get; set; }

        [JsonProperty("seatsNum")]
        public string SeatsNum { get; set; }

        [JsonProperty("doorNum")]
        public string DoorNum { get; set; }

        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("engineType")]
        public string EngineType { get; set; }

        [JsonProperty("fuelType")]
        public string FuelType { get; set; }

        [JsonProperty("paintType")]

        public long PaintType { get; set; }

        [JsonProperty("prodYear")]
        public long ProdYear { get; set; }

        [JsonProperty("carAge")]
        public string CarAge { get; set; }

        [JsonProperty("prodType")]

        public string ProdType { get; set; }

        [JsonProperty("carColour")]

        public string CarColour { get; set; }

        [JsonProperty("regType")]

        public string RegType { get; set; }

        [JsonProperty("enginePower")]
        public string EnginePower { get; set; }

        [JsonProperty("bonusMalus")]
        public long BonusMalus { get; set; }

        [JsonProperty("carbodyType")]

        public long CarbodyType { get; set; }

        [JsonProperty("driveType")]
        public string DriveType { get; set; }

        [JsonProperty("windowColor")]

        public string WindowColor { get; set; }

        [JsonProperty("modified")]

        public long Modified { get; set; }

        [JsonProperty("vehicleKey")]
        public string VehicleKey { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("ocp1")]
        public string Ocp1 { get; set; }

        [JsonProperty("ocp2")]
        public string Ocp2 { get; set; }

        [JsonProperty("ocp3")]
        public string Ocp3 { get; set; }

        [JsonProperty("ocp4")]
        public string Ocp4 { get; set; }

        [JsonProperty("ocp5")]
        public string Ocp5 { get; set; }

        [JsonProperty("ocp6")]
        public string Ocp6 { get; set; }

        [JsonProperty("ocp7")]
        public string Ocp7 { get; set; }

        [JsonProperty("ocp8")]
        public string Ocp8 { get; set; }

        [JsonProperty("ocp9")]
        public string Ocp9 { get; set; }

        [JsonProperty("ocp10")]
        public string Ocp10 { get; set; }

        [JsonProperty("ocp11")]
        public string Ocp11 { get; set; }

        [JsonProperty("ocp12")]
        public string Ocp12 { get; set; }

        [JsonProperty("ocp13")]
        public string Ocp13 { get; set; }

        [JsonProperty("ocp14")]
        public string Ocp14 { get; set; }

        [JsonProperty("ocp15")]
        public string Ocp15 { get; set; }

        [JsonProperty("ocp16")]
        public string Ocp16 { get; set; }

        [JsonProperty("ocp17")]
        public string Ocp17 { get; set; }

        [JsonProperty("ocp18")]
        public string Ocp18 { get; set; }

        [JsonProperty("ocp19")]
        public string Ocp19 { get; set; }

        [JsonProperty("ocp20")]
        public string Ocp20 { get; set; }
    }

    public partial class PaymentPlan
    {
        [JsonProperty("policyPplanId")]
        public long PolicyPplanId { get; set; }

        [JsonProperty("amntType")]
        public string AmntType { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("applDetail")]
        public string ApplDetail { get; set; }

        [JsonProperty("applStatus")]
        public string ApplStatus { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dueDate")]
        public DateTimeOffset DueDate { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("engagementName")]
        public string EngagementName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("freeInstalment")]
        public string FreeInstalment { get; set; }

        [JsonProperty("gwpDate")]
        public DateTimeOffset GwpDate { get; set; }

        [JsonProperty("instalmentPerYear")]
        public string InstalmentPerYear { get; set; }

        [JsonProperty("invoiceNo")]
        public string InvoiceNo { get; set; }

        [JsonProperty("nextPmntStatus")]
        public string NextPmntStatus { get; set; }

        [JsonProperty("paidOn")]
        public string PaidOn { get; set; }

        [JsonProperty("periodId")]
        public long? PeriodId { get; set; }

        [JsonProperty("planType")]
        public string PlanType { get; set; }

        [JsonProperty("pmntReason")]
        public string PmntReason { get; set; }

        [JsonProperty("pmntStatus")]
        public string PmntStatus { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("policyName")]

        public long PolicyName { get; set; }

        [JsonProperty("policyYear")]
        public long PolicyYear { get; set; }

        [JsonProperty("pplanLinkId")]
        public long? PplanLinkId { get; set; }

        [JsonProperty("prevPmntStatus")]
        public string PrevPmntStatus { get; set; }

        [JsonProperty("processed")]
        public string Processed { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("relatedApplId")]
        public string RelatedApplId { get; set; }

        [JsonProperty("reversedApplId")]
        public string ReversedApplId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("wrReason")]
        public string WrReason { get; set; }

        [JsonProperty("attr1")]
        public string Attr1 { get; set; }

        [JsonProperty("attr10")]
        public string Attr10 { get; set; }

        [JsonProperty("attr2")]
        public string Attr2 { get; set; }

        [JsonProperty("attr3")]
        public string Attr3 { get; set; }

        [JsonProperty("attr4")]
        public string Attr4 { get; set; }

        [JsonProperty("attr5")]
        public string Attr5 { get; set; }

        [JsonProperty("attr6")]
        public string Attr6 { get; set; }

        [JsonProperty("attr7")]
        public string Attr7 { get; set; }

        [JsonProperty("attr8")]
        public string Attr8 { get; set; }

        [JsonProperty("attr9")]
        public string Attr9 { get; set; }

        [JsonProperty("attrd1")]
        public string Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public string Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public string Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public string Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public string Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public string Attrn1 { get; set; }

        [JsonProperty("attrn2")]
        public string Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public string Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public string Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public string Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public string Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public string Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public string Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public string Attrn9 { get; set; }

        [JsonProperty("attrn10")]
        public string Attrn10 { get; set; }

        [JsonProperty("engBillingId")]
        public string EngBillingId { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }
    }

    public partial class PolicyAddress
    {
        [JsonProperty("addressId")]
        public long AddressId { get; set; }

        [JsonProperty("addressPurpose")]
        public string AddressPurpose { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("policyAddressId")]
        public string PolicyAddressId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("pAddress")]
        public Address PAddress { get; set; }
    }

    public partial class PolicyAgent
    {
        [JsonProperty("policyAgentId")]
        public long PolicyAgentId { get; set; }

        [JsonProperty("agentId")]
        public long AgentId { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("agentRole")]
        public string AgentRole { get; set; }

        [JsonProperty("commShare")]
        public long CommShare { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("attrc1")]
        public string Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public string Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public string Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public string Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public string Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public string Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public string Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public string Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public string Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public string Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public string Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public string Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public string Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public string Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public string Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public string Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public string Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public string Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public string Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public string Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public string Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public string Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public string Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public string Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public string Attrn9 { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }
    }

    public partial class PolicyContact
    {
        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("contactId")]
        public long ContactId { get; set; }

        [JsonProperty("contactPurpose")]
        public string ContactPurpose { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("policyContactId")]
        public long PolicyContactId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("pContacts")]
        public Contact PContacts { get; set; }
    }

    public partial class PolicyEngBilling
    {
        [JsonProperty("engBillingId")]
        public long EngBillingId { get; set; }

        [JsonProperty("engagementId")]
        public long EngagementId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("paymentWay")]

        public long PaymentWay { get; set; }

        [JsonProperty("numInstalments")]
        public long NumInstalments { get; set; }

        [JsonProperty("paymentDueDate")]
        public long PaymentDueDate { get; set; }

        [JsonProperty("numInstalmentsPeriod")]
        public string NumInstalmentsPeriod { get; set; }

        [JsonProperty("paymentDurDim")]
        public string PaymentDurDim { get; set; }

        [JsonProperty("paymentDuration")]
        public long PaymentDuration { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("recordDesignation")]
        public string RecordDesignation { get; set; }

        [JsonProperty("upToYears")]
        public string UpToYears { get; set; }

        [JsonProperty("nfo")]
        public string Nfo { get; set; }

        [JsonProperty("attr1")]
        public string Attr1 { get; set; }

        [JsonProperty("attr10")]
        public string Attr10 { get; set; }

        [JsonProperty("attr2")]
        public string Attr2 { get; set; }

        [JsonProperty("attr3")]
        public string Attr3 { get; set; }

        [JsonProperty("attr4")]
        public string Attr4 { get; set; }

        [JsonProperty("attr5")]
        public string Attr5 { get; set; }

        [JsonProperty("attr6")]
        public string Attr6 { get; set; }

        [JsonProperty("attr7")]
        public string Attr7 { get; set; }

        [JsonProperty("attr8")]
        public string Attr8 { get; set; }

        [JsonProperty("attr9")]
        public string Attr9 { get; set; }

        [JsonProperty("attrd1")]
        public string Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public string Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public string Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public string Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public string Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public string Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public string Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public string Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public string Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public string Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public string Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public string Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public string Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public string Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public string Attrn9 { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public DateTimeOffset ValidTo { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }
    }

    public partial class PolicyParticipant
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public string AuxAnnexId { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("particpantRole")]
        public string ParticpantRole { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("premiumShare")]
        public long PremiumShare { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public DateTimeOffset ValidTo { get; set; }

        [JsonProperty("irrevocable")]
        public string Irrevocable { get; set; }

        [JsonProperty("participantType")]
        public string ParticipantType { get; set; }

        [JsonProperty("nonamedType")]
        public string NonamedType { get; set; }

        [JsonProperty("recordDesignation")]
        public string RecordDesignation { get; set; }

        [JsonProperty("attrc1")]
        public string Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public string Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public string Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public string Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public string Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public string Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public string Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public string Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public string Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public string Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public string Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public string Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public string Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public string Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public string Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public string Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public string Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public string Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public string Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public string Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public string Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public string Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public string Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public string Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public string Attrn9 { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("policyParticipantsAdditions")]
        public string[] PolicyParticipantsAdditions { get; set; }

        [JsonProperty("policyParticipantsNames")]
        public PolicyParticipantsNames PolicyParticipantsNames { get; set; }

        [JsonProperty("pPeopleComplex")]
        public PPeopleComplex PPeopleComplex { get; set; }
    }

    public partial class PolicyParticipantsNames
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("manName")]
        public string ManName { get; set; }

        [JsonProperty("manPid")]

        public long ManPid { get; set; }
    }

    public partial class PolicyNames
    {
        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("agentId")]
        public long AgentId { get; set; }

        [JsonProperty("agentManId")]
        public long AgentManId { get; set; }

        [JsonProperty("agentName")]
        public string AgentName { get; set; }

        [JsonProperty("agentNo")]
        public string AgentNo { get; set; }

        [JsonProperty("agentPid")]

        public long AgentPid { get; set; }

        [JsonProperty("clientId")]
        public long ClientId { get; set; }

        [JsonProperty("clientManId")]
        public long ClientManId { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientPid")]

        public long ClientPid { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("insrTypeName")]
        public string InsrTypeName { get; set; }

        [JsonProperty("officeId")]
        public long OfficeId { get; set; }

        [JsonProperty("officeManId")]
        public long OfficeManId { get; set; }

        [JsonProperty("officeName")]
        public string OfficeName { get; set; }

        [JsonProperty("officeNo")]
        public string OfficeNo { get; set; }

        [JsonProperty("officePid")]
        public string OfficePid { get; set; }

        [JsonProperty("salesChannelId")]
        public string SalesChannelId { get; set; }

        [JsonProperty("salesChannelManId")]
        public string SalesChannelManId { get; set; }

        [JsonProperty("salesChannelName")]
        public string SalesChannelName { get; set; }

        [JsonProperty("salesChannelPid")]
        public string SalesChannelPid { get; set; }

        [JsonProperty("staffId")]
        public long StaffId { get; set; }

        [JsonProperty("staffManId")]
        public string StaffManId { get; set; }

        [JsonProperty("staffName")]
        public string StaffName { get; set; }

        [JsonProperty("staffPid")]
        public string StaffPid { get; set; }
    }


}

