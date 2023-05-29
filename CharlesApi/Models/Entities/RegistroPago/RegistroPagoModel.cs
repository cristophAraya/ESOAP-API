using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.RegistroPago
{
    public class RegistroPagoModel
    {
        [JsonProperty("reportId")]
        public long ReportId { get; set; }

        [JsonProperty("reportNo")]
        public long ReportNo { get; set; }

        [JsonProperty("docladState")]
        public long DocladState { get; set; }
    }
}
