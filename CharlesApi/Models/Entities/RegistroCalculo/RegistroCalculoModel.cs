using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.RegistroCalculo
{
    public class RegistroCalculoModel
    {
        [JsonProperty("claimDscrSeq")]
        public long ClaimDscrSeq { get; set; }

        [JsonProperty("confirmedAmount")]
        public long ConfirmedAmount { get; set; }

        [JsonProperty("confirmedCurrency")]
        public string ConfirmedCurrency { get; set; }
    }
}
