using Newtonsoft.Json;

namespace CharlesApi.Models.Request.Confirmar
{
    public class ConfirmarRequest
    {
        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requestNo")]
        public long RequestNo { get; set; }

        [JsonProperty("claimNo")]
        public string ClaimNo { get; set; }
    }
}
