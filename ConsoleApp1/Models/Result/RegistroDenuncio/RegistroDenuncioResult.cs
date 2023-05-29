using Newtonsoft.Json;

namespace Cl.Sura.QuartzESoap.Models.Result.RegistroDenuncio
{
    public class RegistroDenuncioResult
    {
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
