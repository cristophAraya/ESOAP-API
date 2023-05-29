using Newtonsoft.Json;

namespace CharlesApi.Models.Request.ConfirmarLiquidacion
{
    public class ConfirmarLiquidacionRequest
    {
        [JsonProperty("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }
        [JsonProperty("numeroInforme")]
        public string NumeroInforme { get; set; }
    }
}
