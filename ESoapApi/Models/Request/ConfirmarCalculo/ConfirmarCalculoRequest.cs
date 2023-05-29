using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Request.ConfirmarCalculo
{
    public class ConfirmarCalculoRequest
    {
        [JsonProperty("claimDscrSeq")]
        public long ClaimDscrSeq { get; set; }
    }
}