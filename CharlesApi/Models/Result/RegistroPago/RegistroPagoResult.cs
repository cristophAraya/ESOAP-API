using Newtonsoft.Json;

namespace CharlesApi.Models.Result.RegistroPago
{
    public class RegistroPagoResult
    {
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("reportId")]
        public long ReportId { get; set; }

        [JsonProperty("reportNo")]
        public long ReportNo { get; set; }

        [JsonProperty("docladState")]
        public long DocladState { get; set; }
    }
}
