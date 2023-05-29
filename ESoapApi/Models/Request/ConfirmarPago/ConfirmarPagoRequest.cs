using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Request.ConfirmarPago
{
    public class ConfirmarPagoRequest
    {
        [JsonProperty("claimReportGroup")]
        public ClaimReportGroup ClaimReportGroup { get; set; }

        [JsonProperty("docladId")]
        public long DocladId { get; set; }
    }

    public partial class ClaimReportGroup
    {
        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requestNo")]
        public long RequestNo { get; set; }

        [JsonProperty("docladNo")]
        public long DocladNo { get; set; }
    }
}
