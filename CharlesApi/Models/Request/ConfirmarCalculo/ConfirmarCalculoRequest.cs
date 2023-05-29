using Newtonsoft.Json;

namespace CharlesApi.Models.Request.ConfirmarCalculo
{
    public class ConfirmarCalculoRequest
    {
        [JsonProperty("claimDscrSeq")]
        public long ClaimDscrSeq { get; set; }
    }
}