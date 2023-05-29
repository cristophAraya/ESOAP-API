using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.ConfirmarPago
{
    public class ConfirmarPagoModel
    {
        public int StatusCode { get; set; }
        [JsonProperty("docladId")]
        public long DocladId { get; set; }

        [JsonProperty("docladNo")]
        public long DocladNo { get; set; }

        [JsonProperty("docladState")]
        public long DocladState { get; set; }
    }
}
