using Newtonsoft.Json;

namespace CharlesApi.ConfirmarEvaluacion
{
    public class ConfirmarEvaluacionRequest
    {
        [JsonProperty("claimObjectSeq")]
        public long ClaimObjectSeq { get; set; }

        [JsonProperty("inspectNum")]
        public long InspectNum { get; set; }
    }
}
