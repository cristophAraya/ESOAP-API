using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.ConfirmarCalculo
{
    public class ConfirmarCalculoModel
    {
        [JsonProperty("claimDscrSeq")]
        public long ClaimDscrSeq { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
