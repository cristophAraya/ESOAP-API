using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Result.ConsultaSiniestro
{
    public class ConsultaSiniestroModel
    {
        [JsonProperty("clientId")]
        public long ClientId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("applicationClass")]
        public string ApplicationClass { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("officeId")]
        public long OfficeId { get; set; }

        [JsonProperty("claimComment")]
        public string ClaimComment { get; set; }

        [JsonProperty("eventCountry")]
        public string EventCountry { get; set; }

        [JsonProperty("eventDate")]
        public DateTimeOffset EventDate { get; set; }

        [JsonProperty("eventDescription")]
        public string EventDescription { get; set; }

        [JsonProperty("eventTime")]
        public DateTimeOffset EventTime { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("causeId")]
        public long CauseId { get; set; }

        [JsonProperty("claimCategory")]
        public string ClaimCategory { get; set; }

        [JsonProperty("claimRegid")]
        public string ClaimRegid { get; set; }

        [JsonProperty("claimStarted")]
        public DateTimeOffset ClaimStarted { get; set; }

        [JsonProperty("eventPlace")]
        public string EventPlace { get; set; }

        [JsonProperty("policyReg")]
        public long PolicyReg { get; set; }

        [JsonProperty("claimRequests")]
        public List<ClaimRequest> ClaimRequests { get; set; }

        [JsonProperty("staffId")]
        public long StaffId { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("eventType")]
        public long EventType { get; set; }
    }

    public partial class ClaimRequest
    {
        [JsonProperty("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("operation")]
        public object Operation { get; set; }

        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requestId")]
        public long RequestId { get; set; }

        [JsonProperty("claimReqSeq")]
        public long ClaimReqSeq { get; set; }

        [JsonProperty("accumulatedLr")]
        public string AccumulatedLr { get; set; }

        [JsonProperty("admissionDate")]
        public object AdmissionDate { get; set; }

        [JsonProperty("admissionTime")]
        public object AdmissionTime { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

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

        [JsonProperty("attrc1")]
        public object Attrc1 { get; set; }

        [JsonProperty("attrc2")]
        public object Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public object Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public object Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public object Attrc5 { get; set; }

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

        [JsonProperty("batchId")]
        public object BatchId { get; set; }

        [JsonProperty("claimantId")]
        public long ClaimantId { get; set; }

        [JsonProperty("claimantType")]
        public long ClaimantType { get; set; }

        [JsonProperty("claimState")]
        public long ClaimState { get; set; }

        [JsonProperty("claimStateAux")]
        public long ClaimStateAux { get; set; }

        [JsonProperty("claimType")]
        public object ClaimType { get; set; }

        [JsonProperty("convertDate")]
        public object ConvertDate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dischargeDate")]
        public object DischargeDate { get; set; }

        [JsonProperty("dischargeTime")]
        public object DischargeTime { get; set; }

        [JsonProperty("dueDate")]
        public object DueDate { get; set; }

        [JsonProperty("expectedAdmissionDate")]
        public object ExpectedAdmissionDate { get; set; }

        [JsonProperty("explanation")]
        public object Explanation { get; set; }

        [JsonProperty("invoiceAmount")]
        public object InvoiceAmount { get; set; }

        [JsonProperty("invoiceCurrency")]
        public object InvoiceCurrency { get; set; }

        [JsonProperty("invoiceDate")]
        public object InvoiceDate { get; set; }

        [JsonProperty("invoiceId")]
        public object InvoiceId { get; set; }

        [JsonProperty("operationDate")]
        public object OperationDate { get; set; }

        [JsonProperty("paymentType")]
        public long PaymentType { get; set; }

        [JsonProperty("primaryDiagnosisGroupId")]
        public object PrimaryDiagnosisGroupId { get; set; }

        [JsonProperty("primaryDiagnosisId")]
        public object PrimaryDiagnosisId { get; set; }

        [JsonProperty("providerContractId")]
        public object ProviderContractId { get; set; }

        [JsonProperty("providerId")]
        public object ProviderId { get; set; }

        [JsonProperty("providerNetworkId")]
        public object ProviderNetworkId { get; set; }

        [JsonProperty("recovery")]
        public object Recovery { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("reopenReason")]
        public object ReopenReason { get; set; }

        [JsonProperty("requestDate")]
        public DateTimeOffset RequestDate { get; set; }

        [JsonProperty("requestType")]
        
        public long? RequestType { get; set; }

        [JsonProperty("servicePlace")]
        public object ServicePlace { get; set; }

        [JsonProperty("solveWay")]
        public object SolveWay { get; set; }

        [JsonProperty("subrogation")]
        public object Subrogation { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("claimObjects")]
        public List<ClaimObject> ClaimObjects { get; set; }

        [JsonProperty("claimGuilties")]
        public List<object> ClaimGuilties { get; set; }

        [JsonProperty("claimParticipants")]
        public List<object> ClaimParticipants { get; set; }

        [JsonProperty("claimRefuses")]
        public List<object> ClaimRefuses { get; set; }

        [JsonProperty("claimDoclad")]
        public List<object> ClaimDoclad { get; set; }
    }

    public partial class ClaimObject
    {
        [JsonProperty("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("operation")]
        public object Operation { get; set; }

        [JsonProperty("claimObjSeq")]
        public long ClaimObjSeq { get; set; }

        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requestId")]
        public long RequestId { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }

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

        [JsonProperty("attrc1")]
        public object Attrc1 { get; set; }

        [JsonProperty("attrc2")]
        public object Attrc2 { get; set; }

        [JsonProperty("attrc3")]
        public object Attrc3 { get; set; }

        [JsonProperty("attrc4")]
        public object Attrc4 { get; set; }

        [JsonProperty("attrc5")]
        public object Attrc5 { get; set; }

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

        [JsonProperty("attrn6")]
        public object Attrn6 { get; set; }

        [JsonProperty("attrn7")]
        public object Attrn7 { get; set; }

        [JsonProperty("attrn8")]
        public object Attrn8 { get; set; }

        [JsonProperty("attrn9")]
        public object Attrn9 { get; set; }

        [JsonProperty("claimState")]
        public long ClaimState { get; set; }

        [JsonProperty("claimStateAux")]
        public long ClaimStateAux { get; set; }

        [JsonProperty("coverType")]
        public string CoverType { get; set; }

        [JsonProperty("death")]
        public string Death { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("exGratia")]
        public string ExGratia { get; set; }

        [JsonProperty("findDate")]
        public object FindDate { get; set; }

        [JsonProperty("grcId")]
        public long GrcId { get; set; }

        [JsonProperty("initialCscAmnt")]
        public object InitialCscAmnt { get; set; }

        [JsonProperty("initialCscCurrency")]
        public object InitialCscCurrency { get; set; }

        [JsonProperty("initialCscDim")]
        public object InitialCscDim { get; set; }

        [JsonProperty("initialReservAmnt")]
        public long InitialReservAmnt { get; set; }

        [JsonProperty("initialReservCurrency")]
        public string InitialReservCurrency { get; set; }

        [JsonProperty("injuredGuiltyType")]

        public long InjuredGuiltyType { get; set; }

        [JsonProperty("injuredObjectId")]
        public long InjuredObjectId { get; set; }

        [JsonProperty("injuredObjectType")]
        public long InjuredObjectType { get; set; }

        [JsonProperty("injuryCausedBy")]

        public long? InjuryCausedBy { get; set; }

        [JsonProperty("insrType")]
        public long InsrType { get; set; }

        [JsonProperty("insuredObjId")]
        public long InsuredObjId { get; set; }

        [JsonProperty("invOperState")]
        public object InvOperState { get; set; }

        [JsonProperty("itemDescription")]
        public string ItemDescription { get; set; }

        [JsonProperty("itemPurchaseDate")]
        public object ItemPurchaseDate { get; set; }

        [JsonProperty("itemType")]
        public object ItemType { get; set; }

        [JsonProperty("liability")]
        public string Liability { get; set; }

        [JsonProperty("lob")]
        public string Lob { get; set; }

        [JsonProperty("lossType")]
        
        public long LossType { get; set; }

        [JsonProperty("manId")]
        public object ManId { get; set; }

        [JsonProperty("objectId")]
        public long ObjectId { get; set; }

        [JsonProperty("objectType")]
        public long ObjectType { get; set; }

        [JsonProperty("parentInsrType")]
        public object ParentInsrType { get; set; }

        [JsonProperty("placeId")]
        public object PlaceId { get; set; }

        [JsonProperty("policyId")]
        public long PolicyId { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("resolveType")]
        public object ResolveType { get; set; }

        [JsonProperty("riskType")]
        public string RiskType { get; set; }

        [JsonProperty("skipCalculation")]
        public string SkipCalculation { get; set; }

        [JsonProperty("skipEvaluation")]
        public string SkipEvaluation { get; set; }

        [JsonProperty("supplObjectId")]
        public object SupplObjectId { get; set; }

        [JsonProperty("systemNotes")]
        public string SystemNotes { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTimeOffset UpdatedOn { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("waiver")]
        public object Waiver { get; set; }

        [JsonProperty("claimObjectsEligibility")]
        public List<object> ClaimObjectsEligibility { get; set; }

        [JsonProperty("claimObjectsDscr")]
        public List<object> ClaimObjectsDscr { get; set; }

        [JsonProperty("claimExpenses")]
        public List<object> ClaimExpenses { get; set; }

        [JsonProperty("claimInspections")]
        public List<object> ClaimInspections { get; set; }

        [JsonProperty("claimRefuses")]
        public List<object> ClaimRefuses { get; set; }
    }

}

