using Newtonsoft.Json;

namespace CharlesApi.Models.Result.ConfirmarPago
{
    public class ConfirmarPagoResult
    {

        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("docladId")]
        public long DocladId { get; set; }

        [JsonProperty("docladNo")]
        public long DocladNo { get; set; }

        [JsonProperty("docladState")]
        public long DocladState { get; set; }
    }
}
