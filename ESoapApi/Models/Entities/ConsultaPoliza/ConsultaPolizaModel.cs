using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Cl.Sura.ESoapApi.Models.Entities.ConsultaPoliza
{
    public class ConsultaPolizaModel
    {
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
        public DateTimeOffset DateCovered { get; set; }

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
        public object AccountId { get; set; }

        [JsonProperty("accountNumber")]
        public object AccountNumber { get; set; }

        [JsonProperty("agentId")]
        public long AgentId { get; set; }

        [JsonProperty("agentNo")]
        public string AgentNo { get; set; }

        [JsonProperty("agentState")]
        
        public long AgentState { get; set; }

        [JsonProperty("agentType")]
        public long AgentType { get; set; }

        [JsonProperty("contractMonths")]
        public object ContractMonths { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("defaultAgent")]
        
        public long DefaultAgent { get; set; }

        [JsonProperty("fireDate")]
        public object FireDate { get; set; }

        [JsonProperty("hireDate")]
        public DateTimeOffset HireDate { get; set; }

        [JsonProperty("leavingReason")]
        public object LeavingReason { get; set; }

        [JsonProperty("mainAgent")]
        public long MainAgent { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("officeId")]
        public long OfficeId { get; set; }

        [JsonProperty("oldAgentNo")]
        public object OldAgentNo { get; set; }

        [JsonProperty("prevJobConfirmDate")]
        public object PrevJobConfirmDate { get; set; }

        [JsonProperty("qualifLevel")]
        
        public long QualifLevel { get; set; }

        [JsonProperty("pPeopleComplex")]
        public PPeopleComplex PPeopleComplex { get; set; }
    }

    public partial class PPeopleComplex
    {
        [JsonProperty("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("operation")]
        public object Operation { get; set; }

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
        public object Fname { get; set; }

        [JsonProperty("sex")]
        public long Sex { get; set; }

        [JsonProperty("namePrefix")]
        public object NamePrefix { get; set; }

        [JsonProperty("nameSuffix")]
        public object NameSuffix { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("homeCountry")]
        public string HomeCountry { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("classCode")]
        public object ClassCode { get; set; }

        [JsonProperty("classSubCode")]
        public object ClassSubCode { get; set; }

        [JsonProperty("compType")]
        public object CompType { get; set; }

        [JsonProperty("dataSource")]
        public object DataSource { get; set; }

        [JsonProperty("fiscalPeriod")]
        public object FiscalPeriod { get; set; }

        [JsonProperty("industryCode")]
        public object IndustryCode { get; set; }

        [JsonProperty("subIndustryCode")]
        public object SubIndustryCode { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("attr1")]
        public object Attr1 { get; set; }

        [JsonProperty("attr2")]
        public object Attr2 { get; set; }

        [JsonProperty("attr3")]
        public object Attr3 { get; set; }

        [JsonProperty("attr4")]
        public object Attr4 { get; set; }

        [JsonProperty("attr5")]
        public object Attr5 { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("questions")]
        public Question[] Questions { get; set; }

        [JsonProperty("peopleGroups")]
        public object[] PeopleGroups { get; set; }

        [JsonProperty("contactPersons")]
        public object[] ContactPersons { get; set; }

        [JsonProperty("relations1")]
        public object[] Relations1 { get; set; }

        [JsonProperty("relations2")]
        public object[] Relations2 { get; set; }

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
        public object ApartmentNumber { get; set; }

        [JsonProperty("blockNumber")]
        public object BlockNumber { get; set; }

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
        public object EntranceNumber { get; set; }

        [JsonProperty("floorNumber")]     
        public string FloorNumber { get; set; }

        [JsonProperty("invoiceYn")]
        public string InvoiceYn { get; set; }

        [JsonProperty("mailYn")]
        public string MailYn { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }

        [JsonProperty("primaryFlag")]
        public string? PrimaryFlag { get; set; }

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
        public object StreetId { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("streetNumber")]
        
        public string StreetNumber { get; set; }

        [JsonProperty("territoryClassification")]
        public object TerritoryClassification { get; set; }

        [JsonProperty("usageDateFrom")]
        public object UsageDateFrom { get; set; }

        [JsonProperty("usageDateTo")]
        public object UsageDateTo { get; set; }

        [JsonProperty("validFrom")]
        public object ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

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

        [JsonProperty("primaryFlag")]
        public string PrimaryFlag { get; set; }

        [JsonProperty("validFrom")]
        public object ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

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
        public object MainBankId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("swiftCode")]
        public object SwiftCode { get; set; }

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
        public object Language { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("primaryFlag")]
        public string PrimaryFlag { get; set; }

        [JsonProperty("validFrom")]
        public object ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

        [JsonProperty("personPid")]
        public Pid PersonPid { get; set; }
    }

    public partial class Document
    {
        [JsonProperty("annexId")]
        public object AnnexId { get; set; }

        [JsonProperty("certifyEvent")]
        public object CertifyEvent { get; set; }

        [JsonProperty("changeDate")]
        public DateTimeOffset ChangeDate { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("claimId")]
        public object ClaimId { get; set; }

        [JsonProperty("claimObjSeq")]
        public object ClaimObjSeq { get; set; }

        [JsonProperty("docDate")]
        public object DocDate { get; set; }

        [JsonProperty("docDays")]
        public object DocDays { get; set; }

        [JsonProperty("docDescription")]
        public object DocDescription { get; set; }

        [JsonProperty("docHolderAddr")]
        public object DocHolderAddr { get; set; }

        [JsonProperty("docHolderName")]
        public object DocHolderName { get; set; }

        [JsonProperty("docId")]
        public string DocId { get; set; }

        [JsonProperty("docName")]
        public object DocName { get; set; }

        [JsonProperty("docNum")]
        public object DocNum { get; set; }

        [JsonProperty("docSeq")]
        public double DocSeq { get; set; }

        [JsonProperty("docSerial")]
        public object DocSerial { get; set; }

        [JsonProperty("docState")]
        public long DocState { get; set; }

        [JsonProperty("docValidTo")]
        public object DocValidTo { get; set; }

        [JsonProperty("documentRef")]
        public object DocumentRef { get; set; }

        [JsonProperty("grcId")]
        public object GrcId { get; set; }

        [JsonProperty("insuredId")]
        public object InsuredId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("objectId")]
        public object ObjectId { get; set; }

        [JsonProperty("pholderId")]
        public object PholderId { get; set; }

        [JsonProperty("policyId")]
        public object PolicyId { get; set; }

        [JsonProperty("providerId")]
        public object ProviderId { get; set; }

        [JsonProperty("receiveDate")]
        public DateTimeOffset ReceiveDate { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("requestId")]
        public object RequestId { get; set; }

        [JsonProperty("requiredFrom")]
        public object RequiredFrom { get; set; }

        [JsonProperty("requiredManId")]
        public object RequiredManId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("attributes")]
        public object[] Attributes { get; set; }

        [JsonProperty("cfgDocName")]
        public object CfgDocName { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public partial class Question
    {
        [JsonProperty("annexId")]
        public object AnnexId { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("changeDate")]
        public DateTimeOffset ChangeDate { get; set; }

        [JsonProperty("claimId")]
        public object ClaimId { get; set; }

        [JsonProperty("claimObjSeq")]
        public object ClaimObjSeq { get; set; }

        [JsonProperty("grcId")]
        public object GrcId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("insuredId")]
        public object InsuredId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("objectId")]
        public object ObjectId { get; set; }

        [JsonProperty("pholderId")]
        public object PholderId { get; set; }

        [JsonProperty("policyId")]
        public object PolicyId { get; set; }

        [JsonProperty("questAnswer")]
        
        public long QuestAnswer { get; set; }

        [JsonProperty("questId")]
        public string QuestId { get; set; }

        [JsonProperty("questOrder")]
        public long QuestOrder { get; set; }

        [JsonProperty("questWeight")]
        public object QuestWeight { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("requestId")]
        public object RequestId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class PClients
    {
        [JsonProperty("acceptMarketInfo")]
        public object AcceptMarketInfo { get; set; }

        [JsonProperty("accountId")]
        public object AccountId { get; set; }

        [JsonProperty("clientId")]
        public long ClientId { get; set; }

        [JsonProperty("corporateIcStatus")]
        public object CorporateIcStatus { get; set; }

        [JsonProperty("customerType")]
        public object CustomerType { get; set; }

        [JsonProperty("employeeStatus")]
        public object EmployeeStatus { get; set; }

        [JsonProperty("icStatus")]
        public object IcStatus { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("officialStatus")]
        public object OfficialStatus { get; set; }

        [JsonProperty("profitability")]
        public object Profitability { get; set; }

        [JsonProperty("riskRating")]
        public object RiskRating { get; set; }

        [JsonProperty("segment")]
        public object Segment { get; set; }

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
        public object[] PolicyConditions { get; set; }

        [JsonProperty("policyContacts")]
        public PolicyContact[] PolicyContacts { get; set; }

        [JsonProperty("commissions")]
        public Commission[] Commissions { get; set; }

        [JsonProperty("policyAddresses")]
        public PolicyAddress[] PolicyAddresses { get; set; }

        [JsonProperty("policyBankAccounts")]
        public object[] PolicyBankAccounts { get; set; }

        [JsonProperty("policyEndorsements")]
        public object[] PolicyEndorsements { get; set; }

        [JsonProperty("policyEngBillings")]
        public PolicyEngBilling[] PolicyEngBillings { get; set; }

        [JsonProperty("policyAgents")]
        public PolicyAgent[] PolicyAgents { get; set; }

        [JsonProperty("discounts")]
        public object[] Discounts { get; set; }

        [JsonProperty("taxes")]
        public object[] Taxes { get; set; }

        [JsonProperty("limits")]
        public object[] Limits { get; set; }

        [JsonProperty("paymentPlan")]
        public PaymentPlan[] PaymentPlan { get; set; }

        [JsonProperty("installments")]
        public Installment[] Installments { get; set; }

        [JsonProperty("questions")]
        public object[] Questions { get; set; }

        [JsonProperty("documents")]
        public object[] Documents { get; set; }
    }

    public partial class Commission
    {
        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public object AuxAnnexId { get; set; }

        [JsonProperty("commDimension")]
        public string CommDimension { get; set; }

        [JsonProperty("commType")]
        public string CommType { get; set; }

        [JsonProperty("commValue")]
        public long CommValue { get; set; }

        [JsonProperty("coverType")]
        public object CoverType { get; set; }

        [JsonProperty("currency")]
        public object Currency { get; set; }

        [JsonProperty("engagementId")]
        public object EngagementId { get; set; }

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
        public object InsuredObjId { get; set; }

        [JsonProperty("grcId")]
        public object GrcId { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("attrc1")]
        public object Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public object Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public object Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public object Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public object Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public object Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public object Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public object Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public object Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public object Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public object Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public object Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public object Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public object Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public object Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public object Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public object Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public object Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public object Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public object Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public object Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public object Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public object Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public object Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public object Attrn9 { get; set; }
    }

    public partial class Installment
    {
        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public object AuxAnnexId { get; set; }

        [JsonProperty("amntLocal")]
        public long AmntLocal { get; set; }

        [JsonProperty("amntCurrency")]
        public long AmntCurrency { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("oldCovered")]
        public DateTimeOffset OldCovered { get; set; }

        [JsonProperty("dateCovered")]
        public DateTimeOffset DateCovered { get; set; }

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
        public object GroupSeqNum { get; set; }

        [JsonProperty("attachedToGroup")]
        public object AttachedToGroup { get; set; }

        [JsonProperty("objectId")]
        public long ObjectId { get; set; }

        [JsonProperty("objectType")]
        public long ObjectType { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("auxAnnexId")]
        public object AuxAnnexId { get; set; }

        [JsonProperty("objectState")]
        public long ObjectState { get; set; }

        [JsonProperty("objectStateAux")]
        public long ObjectStateAux { get; set; }

        [JsonProperty("riskClass")]
        public object RiskClass { get; set; }

        [JsonProperty("objectNum")]
        public long ObjectNum { get; set; }

        [JsonProperty("objectAlive")]
        public long ObjectAlive { get; set; }

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
        public object ActivityType { get; set; }

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
        public object Iop1 { get; set; }

        [JsonProperty("iop2")]
        public object Iop2 { get; set; }

        [JsonProperty("iop3")]
        public object Iop3 { get; set; }

        [JsonProperty("riskLocationId")]
        public object RiskLocationId { get; set; }

        [JsonProperty("locationRiskClass")]
        public object LocationRiskClass { get; set; }

        [JsonProperty("locationValue")]
        public object LocationValue { get; set; }

        [JsonProperty("locvalDimension")]
        public object LocvalDimension { get; set; }

        [JsonProperty("billingId")]
        public object BillingId { get; set; }

        [JsonProperty("mainInsObjId")]
        public object MainInsObjId { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("groupId")]
        public object GroupId { get; set; }

        [JsonProperty("subgroupId")]
        public object SubgroupId { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("attrc1")]
        public object Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public object Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public object Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public object Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public object Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public object Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public object Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public object Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public object Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public object Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public object Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public object Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public object Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public object Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public object Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public object Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public object Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public object Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public object Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public object Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public object Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public object Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public object Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public object Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public object Attrn9 { get; set; }

        [JsonProperty("covers")]
        public Cover[] Covers { get; set; }

        [JsonProperty("discounts")]
        public object[] Discounts { get; set; }

        [JsonProperty("limits")]
        public object[] Limits { get; set; }

        [JsonProperty("commissions")]
        public object[] Commissions { get; set; }

        [JsonProperty("policyParticipantsDtl")]
        public object[] PolicyParticipantsDtl { get; set; }

        [JsonProperty("policyEngBillingsDtl")]
        public object[] PolicyEngBillingsDtl { get; set; }

        [JsonProperty("insuredObjectSuppl")]
        public object[] InsuredObjectSuppl { get; set; }

        [JsonProperty("insuredEntity")]
        public InsuredEntity InsuredEntity { get; set; }

        [JsonProperty("questions")]
        public object[] Questions { get; set; }

        [JsonProperty("documents")]
        public object[] Documents { get; set; }
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
        public object AuxAnnexId { get; set; }

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

        [JsonProperty("objectNum")]
        public long ObjectNum { get; set; }

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
        public long CoverOrder { get; set; }

        [JsonProperty("dateCovered")]
        public DateTimeOffset DateCovered { get; set; }

        [JsonProperty("annualPremium")]
        public long AnnualPremium { get; set; }

        [JsonProperty("riAmountSubject")]
        public object RiAmountSubject { get; set; }

        [JsonProperty("rateFullPremium")]
        public long RateFullPremium { get; set; }

        [JsonProperty("rateAnnualPremium")]
        public long RateAnnualPremium { get; set; }

        [JsonProperty("packageId")]
        public object PackageId { get; set; }

        [JsonProperty("locationValue")]
        public object LocationValue { get; set; }

        [JsonProperty("locvalDimension")]
        public object LocvalDimension { get; set; }

        [JsonProperty("selectedCover")]
        public object SelectedCover { get; set; }

        [JsonProperty("netPremium")]
        public long NetPremium { get; set; }

        [JsonProperty("anniversary")]
        public DateTimeOffset Anniversary { get; set; }

        [JsonProperty("claimObjectType")]
        public long ClaimObjectType { get; set; }

        [JsonProperty("ivType")]
        public string IvType { get; set; }

        [JsonProperty("riskClass")]
        public object RiskClass { get; set; }

        [JsonProperty("coverPaymentSource")]
        public string CoverPaymentSource { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("grcSrv1")]
        public object GrcSrv1 { get; set; }

        [JsonProperty("grcSrv2")]
        public object GrcSrv2 { get; set; }

        [JsonProperty("grcSrv3")]
        public object GrcSrv3 { get; set; }

        [JsonProperty("waiver")]
        public object Waiver { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("grcOrgId")]
        public long GrcOrgId { get; set; }

        [JsonProperty("grcRefId")]
        public object GrcRefId { get; set; }

        [JsonProperty("sliceType")]
        public object SliceType { get; set; }

        [JsonProperty("coverLob")]
        public string CoverLob { get; set; }

        [JsonProperty("groupId")]
        public object GroupId { get; set; }

        [JsonProperty("subgroupId")]
        public object SubgroupId { get; set; }

        [JsonProperty("tariffRule")]
        public string TariffRule { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("attrc1")]
        public object Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public object Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public object Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public object Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public object Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public object Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public object Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public object Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public object Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public object Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public object Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public object Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public object Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public object Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public object Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public object Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public object Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public object Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public object Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public object Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public object Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public object Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public object Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public object Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public object Attrn9 { get; set; }

        [JsonProperty("risks")]
        public object[] Risks { get; set; }

        [JsonProperty("invAccounts")]
        public object[] InvAccounts { get; set; }

        [JsonProperty("discounts")]
        public object[] Discounts { get; set; }

        [JsonProperty("taxes")]
        public object[] Taxes { get; set; }

        [JsonProperty("limits")]
        public object[] Limits { get; set; }

        [JsonProperty("commissions")]
        public object[] Commissions { get; set; }

        [JsonProperty("policyParticipantsDtl")]
        public object[] PolicyParticipantsDtl { get; set; }

        [JsonProperty("policyEngBillingsDtl")]
        public object[] PolicyEngBillingsDtl { get; set; }

        [JsonProperty("policyEndorsements")]
        public object[] PolicyEndorsements { get; set; }
    }

    public partial class InsuredEntity
    {
        [JsonProperty("objectId")]
        public long ObjectId { get; set; }

        [JsonProperty("objectType")]
        public long ObjectType { get; set; }

        [JsonProperty("oAccinsured")]
        public object OAccinsured { get; set; }

        [JsonProperty("oCar")]
        public OCar OCar { get; set; }

        [JsonProperty("oProperty")]
        public object OProperty { get; set; }

        [JsonProperty("oLoss")]
        public object OLoss { get; set; }

        [JsonProperty("oGroupIns")]
        public object OGroupIns { get; set; }

        [JsonProperty("oLiability")]
        public object OLiability { get; set; }
    }

    public partial class OCar
    {
        [JsonProperty("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("operation")]
        public object Operation { get; set; }

        [JsonProperty("objectId")]
        public long ObjectId { get; set; }

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
        
        public long Model { get; set; }

        [JsonProperty("modification")]
        public object Modification { get; set; }

        [JsonProperty("ccmTon")]
        public object CcmTon { get; set; }

        [JsonProperty("tonage")]
        public long Tonage { get; set; }

        [JsonProperty("carUsage")]
        public object CarUsage { get; set; }

        [JsonProperty("seatsNum")]
        public long SeatsNum { get; set; }

        [JsonProperty("doorNum")]
        public long DoorNum { get; set; }

        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("engineType")]
        public object EngineType { get; set; }

        [JsonProperty("fuelType")]
        public object FuelType { get; set; }

        [JsonProperty("paintType")]
        
        public long PaintType { get; set; }

        [JsonProperty("prodYear")]
        public long ProdYear { get; set; }

        [JsonProperty("carAge")]
        public long CarAge { get; set; }

        [JsonProperty("prodType")]
        
        public long ProdType { get; set; }

        [JsonProperty("carColour")]
        
        public long CarColour { get; set; }

        [JsonProperty("regType")]
        
        public long RegType { get; set; }

        [JsonProperty("enginePower")]
        public long EnginePower { get; set; }

        [JsonProperty("bonusMalus")]
        public long BonusMalus { get; set; }

        [JsonProperty("carbodyType")]
        
        public long CarbodyType { get; set; }

        [JsonProperty("driveType")]
        public object DriveType { get; set; }

        [JsonProperty("windowColor")]
        
        public long WindowColor { get; set; }

        [JsonProperty("modified")]
        
        public long Modified { get; set; }

        [JsonProperty("vehicleKey")]
        public object VehicleKey { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("ocp1")]
        public object Ocp1 { get; set; }

        [JsonProperty("ocp2")]
        public object Ocp2 { get; set; }

        [JsonProperty("ocp3")]
        public object Ocp3 { get; set; }

        [JsonProperty("ocp4")]
        public object Ocp4 { get; set; }

        [JsonProperty("ocp5")]
        public object Ocp5 { get; set; }

        [JsonProperty("ocp6")]
        public object Ocp6 { get; set; }

        [JsonProperty("ocp7")]
        public object Ocp7 { get; set; }

        [JsonProperty("ocp8")]
        public object Ocp8 { get; set; }

        [JsonProperty("ocp9")]
        public object Ocp9 { get; set; }

        [JsonProperty("ocp10")]
        public object Ocp10 { get; set; }

        [JsonProperty("ocp11")]
        public object Ocp11 { get; set; }

        [JsonProperty("ocp12")]
        public object Ocp12 { get; set; }

        [JsonProperty("ocp13")]
        public object Ocp13 { get; set; }

        [JsonProperty("ocp14")]
        public object Ocp14 { get; set; }

        [JsonProperty("ocp15")]
        public object Ocp15 { get; set; }

        [JsonProperty("ocp16")]
        public object Ocp16 { get; set; }

        [JsonProperty("ocp17")]
        public object Ocp17 { get; set; }

        [JsonProperty("ocp18")]
        public object Ocp18 { get; set; }

        [JsonProperty("ocp19")]
        public object Ocp19 { get; set; }

        [JsonProperty("ocp20")]
        public object Ocp20 { get; set; }
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
        public object ApplDetail { get; set; }

        [JsonProperty("applStatus")]
        public object ApplStatus { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dueDate")]
        public DateTimeOffset? DueDate { get; set; }

        [JsonProperty("engagementId")]
        public object EngagementId { get; set; }

        [JsonProperty("engagementName")]
        public object EngagementName { get; set; }

        [JsonProperty("externalId")]
        public object ExternalId { get; set; }

        [JsonProperty("freeInstalment")]
        public string FreeInstalment { get; set; }

        [JsonProperty("gwpDate")]
        public DateTimeOffset? GwpDate { get; set; }

        [JsonProperty("instalmentPerYear")]
        public string InstalmentPerYear { get; set; }

        [JsonProperty("invoiceNo")]
        public object InvoiceNo { get; set; }

        [JsonProperty("nextPmntStatus")]
        public object NextPmntStatus { get; set; }

        [JsonProperty("paidOn")]
        public object PaidOn { get; set; }

        [JsonProperty("periodId")]
        public long? PeriodId { get; set; }

        [JsonProperty("planType")]
        public string PlanType { get; set; }

        [JsonProperty("pmntReason")]
        public object PmntReason { get; set; }

        [JsonProperty("pmntStatus")]
        public object PmntStatus { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("policyName")]

        public long PolicyName { get; set; }

        [JsonProperty("policyYear")]
        public long PolicyYear { get; set; }

        [JsonProperty("pplanLinkId")]
        public long? PplanLinkId { get; set; }

        [JsonProperty("prevPmntStatus")]
        public object PrevPmntStatus { get; set; }

        [JsonProperty("processed")]
        public string Processed { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("relatedApplId")]
        public object RelatedApplId { get; set; }

        [JsonProperty("reversedApplId")]
        public object ReversedApplId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("wrReason")]
        public object WrReason { get; set; }

        [JsonProperty("attr1")]
        public object Attr1 { get; set; }

        [JsonProperty("attr10")]
        public object Attr10 { get; set; }

        [JsonProperty("attr2")]
        public object Attr2 { get; set; }

        [JsonProperty("attr3")]
        public object Attr3 { get; set; }

        [JsonProperty("attr4")]
        public object Attr4 { get; set; }

        [JsonProperty("attr5")]
        public object Attr5 { get; set; }

        [JsonProperty("attr6")]
        public object Attr6 { get; set; }

        [JsonProperty("attr7")]
        public object Attr7 { get; set; }

        [JsonProperty("attr8")]
        public object Attr8 { get; set; }

        [JsonProperty("attr9")]
        public object Attr9 { get; set; }

        [JsonProperty("attrd1")]
        public object Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public object Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public object Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public object Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public object Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public object Attrn1 { get; set; }

        [JsonProperty("attrn2")]
        public object Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public object Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public object Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public object Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public object Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public object Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public object Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public object Attrn9 { get; set; }

        [JsonProperty("attrn10")]
        public object Attrn10 { get; set; }

        [JsonProperty("engBillingId")]
        public object EngBillingId { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset? UpdatedOn { get; set; }
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
        public object AuxAnnexId { get; set; }

        [JsonProperty("engagementId")]
        public object EngagementId { get; set; }

        [JsonProperty("policyAddressId")]
        public long PolicyAddressId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

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
        public object EngagementId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

        [JsonProperty("auxAnnexId")]
        public object AuxAnnexId { get; set; }

        [JsonProperty("agentRole")]
        public string AgentRole { get; set; }

        [JsonProperty("commShare")]
        public long CommShare { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

        [JsonProperty("attrc1")]
        public object Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public object Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public object Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public object Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public object Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public object Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public object Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public object Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public object Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public object Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public object Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public object Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public object Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public object Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public object Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public object Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public object Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public object Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public object Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public object Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public object Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public object Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public object Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public object Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public object Attrn9 { get; set; }

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
        public object AuxAnnexId { get; set; }

        [JsonProperty("contactId")]
        public long ContactId { get; set; }

        [JsonProperty("contactPurpose")]
        public string ContactPurpose { get; set; }

        [JsonProperty("engagementId")]
        public object EngagementId { get; set; }

        [JsonProperty("policyContactId")]
        public long PolicyContactId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

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
        public object AuxAnnexId { get; set; }

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
        public object UpToYears { get; set; }

        [JsonProperty("nfo")]
        public object Nfo { get; set; }

        [JsonProperty("attr1")]
        public object Attr1 { get; set; }

        [JsonProperty("attr10")]
        public object Attr10 { get; set; }

        [JsonProperty("attr2")]
        public object Attr2 { get; set; }

        [JsonProperty("attr3")]
        public object Attr3 { get; set; }

        [JsonProperty("attr4")]
        public object Attr4 { get; set; }

        [JsonProperty("attr5")]
        public object Attr5 { get; set; }

        [JsonProperty("attr6")]
        public object Attr6 { get; set; }

        [JsonProperty("attr7")]
        public object Attr7 { get; set; }

        [JsonProperty("attr8")]
        public object Attr8 { get; set; }

        [JsonProperty("attr9")]
        public object Attr9 { get; set; }

        [JsonProperty("attrd1")]
        public object Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public object Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public object Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public object Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public object Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public object Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public object Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public object Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public object Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public object Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public object Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public object Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public object Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public object Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public object Attrn9 { get; set; }

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
        public object AuxAnnexId { get; set; }

        [JsonProperty("engagementId")]
        public object EngagementId { get; set; }

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
        public object NonamedType { get; set; }

        [JsonProperty("recordDesignation")]
        public string RecordDesignation { get; set; }

        [JsonProperty("attrc1")]
        public object Attrc1 { get; set; }

        [JsonProperty("attrc10")]
        public object Attrc10 { get; set; }

        [JsonProperty("attrc2")]
        public object Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public object Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public object Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public object Attrc5 { get; set; }

        [JsonProperty("attrc6")]
        public object Attrc6 { get; set; }

        [JsonProperty("attrc7")]
        public object Attrc7 { get; set; }

        [JsonProperty("attrc8")]
        public object Attrc8 { get; set; }

        [JsonProperty("attrc9")]
        public object Attrc9 { get; set; }

        [JsonProperty("attrd1")]
        public object Attrd1 { get; set; }

        [JsonProperty("attrd2")]
        public object Attrd2 { get; set; }

        [JsonProperty("attrd3")]
        public object Attrd3 { get; set; }

        [JsonProperty("attrd4")]
        public object Attrd4 { get; set; }

        [JsonProperty("attrd5")]
        public object Attrd5 { get; set; }

        [JsonProperty("attrn1")]
        public object Attrn1 { get; set; }

        [JsonProperty("attrn10")]
        public object Attrn10 { get; set; }

        [JsonProperty("attrn2")]
        public object Attrn2 { get; set; }

        [JsonProperty("attrn3")]
        public object Attrn3 { get; set; }

        [JsonProperty("attrn4")]
        public object Attrn4 { get; set; }

        [JsonProperty("attrn5")]
        public object Attrn5 { get; set; }

        [JsonProperty("attrn6")]
        public object Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public object Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public object Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public object Attrn9 { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("policyParticipantsAdditions")]
        public object[] PolicyParticipantsAdditions { get; set; }

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
        public object SalesChannelId { get; set; }

        [JsonProperty("salesChannelManId")]
        public object SalesChannelManId { get; set; }

        [JsonProperty("salesChannelName")]
        public object SalesChannelName { get; set; }

        [JsonProperty("salesChannelPid")]
        public object SalesChannelPid { get; set; }

        [JsonProperty("staffId")]
        public long StaffId { get; set; }

        [JsonProperty("staffManId")]
        public object StaffManId { get; set; }

        [JsonProperty("staffName")]
        public object StaffName { get; set; }

        [JsonProperty("staffPid")]
        public object StaffPid { get; set; }
    }

}

