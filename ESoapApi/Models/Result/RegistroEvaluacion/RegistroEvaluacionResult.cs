using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Result.RegistroEvaluacion
{
    public class RegistroEvaluacionResult
    {
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("inspectNum")]
        public long InspectNum { get; set; }
    }
}