using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Request.RegistroCalculo
{
    public class RegistroCalculoRequest
    {
        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requestNo")]
        public long RequestNo { get; set; }

        [JsonProperty("claimObjSeq")]
        public long ClaimObjSeq { get; set; }

        [JsonProperty("inspectNum")]
        public long InspectNum { get; set; }

        [JsonProperty("requestedAmount")]
        public long RequestedAmount { get; set; }

        [JsonProperty("requestedCurrency")]
        public string RequestedCurrency { get; set; }

    }
}
