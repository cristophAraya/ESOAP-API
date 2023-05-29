
using CharlesApi.Models.Request.LiquidarSiniestro;
using Newtonsoft.Json;

namespace CharlesApi.Models.Request.RegistroReclamante
{
    public class RegistroReclamanteRequest
    {
        [JsonProperty("claimNo")]
        public string ClaimNo { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }
    }

    public partial class Request
    {
        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        [JsonProperty("claimantId")]
        public long ClaimantId { get; set; }

        [JsonProperty("claimantType")]
        public long ClaimantType { get; set; }

        [JsonProperty("injuredObjects")]
        public InjuredObjects InjuredObjects { get; set; }

        [JsonProperty("participants")]
        public Participants Participants { get; set; }
    }

    public partial class Participants
    {
        [JsonProperty("participant")]
        public List<Participant> Participant { get; set; }
    }

    public partial class Participant
    {
        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("participantRole")]
        public string ParticipantRole { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }
    }

    public partial class InjuredObjects
    {
        [JsonProperty("injuredObject")]
        public List<InjuredObject> InjuredObject { get; set; }
    }

    public partial class InjuredObject
    {
        [JsonProperty("insuredData")]
        public InsuredData InsuredData { get; set; }

        [JsonProperty("documents")]
        public Documents Documents { get; set; }

        [JsonProperty("injuryCausedBy")]

        public string InjuryCausedBy { get; set; }

        [JsonProperty("initialReserve")]
        public long InitialReserve { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public partial class Documents
    {
        [JsonProperty("document")]
        public List<Document> Document { get; set; }
    }

    public partial class Document
    {
        [JsonProperty("docId")]
        public string DocId { get; set; }

        [JsonProperty("docState")]
        public long DocState { get; set; }
    }

    public partial class InsuredData
    {
        [JsonProperty("insuredObjectId")]
        public long InsuredObjectId { get; set; }

        [JsonProperty("grcId")]
        public long GrcId { get; set; }

        [JsonProperty("coverCode")]
        public string CoverCode { get; set; }

        [JsonProperty("riskType")]
        public string RiskType { get; set; }

        [JsonProperty("annexId")]
        public long AnnexId { get; set; }
    }
}
