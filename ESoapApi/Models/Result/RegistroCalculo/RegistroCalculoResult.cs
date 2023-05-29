using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Result.RegistroCalculo
{
    public class RegistroCalculoResult
    {
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("claimDscrSeq")]
        public long ClaimDscrSeq { get; set; }

        [JsonProperty("confirmedAmount")]
        public long ConfirmedAmount { get; set; }

        [JsonProperty("confirmedCurrency")]
        public string ConfirmedCurrency { get; set; }
    }
}
