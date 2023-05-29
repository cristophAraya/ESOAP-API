using Newtonsoft.Json;

namespace Charles.Models.Result.Confirmar
{
    public class ConfirmarResult
    {
        public int StatusCode { get; set; }
        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requests")]
        public Requests Requests { get; set; }
    }

    public partial class Requests
    {
        [JsonProperty("requests")]
        public List<Request> RequestsRequests { get; set; }
    }

    public partial class Request
    {
        [JsonProperty("requestNo")]
        public long RequestNo { get; set; }

        [JsonProperty("claimState")]
        public long ClaimState { get; set; }

        [JsonProperty("claimStateAux")]
        public long ClaimStateAux { get; set; }
    }
}
