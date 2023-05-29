using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Result.ConfirmarEvaluacion
{
    public class ConfirmarEvaluacionResult
    {
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; } 

        [JsonProperty("claimObjSeq")]
        public long ClaimObjSeq { get; set; }

        [JsonProperty("inspectNum")]
        public long InspectNum { get; set; }

        [JsonProperty("recordStatus")]
        public string RecordStatus { get; set; }
    }
}
