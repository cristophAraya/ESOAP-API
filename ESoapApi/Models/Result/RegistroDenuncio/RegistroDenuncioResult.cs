using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Result.RegistroDenuncio
{
    public class RegistroDenuncioResult
    {
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();
        public int StatusCode { get; set; }
        [JsonProperty("notificationId")]
        public long NotificationId { get; set; }

        [JsonProperty("returningMessages")]
        public ReturningMessages ReturningMessages { get; set; }
    }

    public partial class ReturningMessages
    {
        [JsonProperty("returningMessage")]
        public object[] ReturningMessage { get; set; }
    }
}
