using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.RegistroEvaluacion
{
    public class RegistroEvaluacionModel
    {
        [JsonProperty("inspectNum")]
        public long InspectNum { get; set; }
    }
}