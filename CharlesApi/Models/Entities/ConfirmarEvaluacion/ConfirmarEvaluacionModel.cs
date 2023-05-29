using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.ConfirmarEvaluacion
{
    public class ConfirmarEvaluacionModel
    {
        [JsonProperty("claimObjSeq")]
        public long ClaimObjSeq { get; set; }

        [JsonProperty("inspectNum")]
        public long InspectNum { get; set; }

        [JsonProperty("recordStatus")]
        public string RecordStatus { get; set; }
    }
}
