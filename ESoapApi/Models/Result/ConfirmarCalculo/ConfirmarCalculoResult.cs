using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Result.ConfirmarCalculo
{
    public class ConfirmarCalculoResult
    {
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("claimDscrSeq")]
        public long ClaimDscrSeq { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
