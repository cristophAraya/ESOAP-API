using Newtonsoft.Json;

namespace CharlesApi.Models.Result.DeclararSiniestro
{
    public class DeclararSiniestroResult
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();
    }
}
