using Newtonsoft.Json;

namespace CharlesApi.Models.Result.ReclamantePrincipal
{
    public class ReclamantePrincipalResult
    {
        [JsonProperty("Errores")]
        public List<string> Errores { get; set; } = new List<string>();
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("idPersona")]
        public string IdPersona { get; set; }

        [JsonProperty("numeroSolicitud")]
        public int NumeroSolicitud { get; set; }
    }
}
