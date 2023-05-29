using Newtonsoft.Json;

namespace CharlesApi.Models.Result.ConfirmarLiquidacion
{
    public class ConfirmarLiquidacionResult
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("Errores")]
        public List<string> Errores { get; set; } = new List<string>();
    }
}
