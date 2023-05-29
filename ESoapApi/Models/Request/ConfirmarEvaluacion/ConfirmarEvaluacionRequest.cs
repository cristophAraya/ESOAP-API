using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Request.ConfirmarEvaluacion
{
    public class ConfirmarEvaluacionRequest
    {
        [JsonProperty("claimObjectSeq")]
        public long ClaimObjectSeq { get; set; }

        [JsonProperty("inspectNum")]
        public long InspectNum { get; set; }
    }
}
