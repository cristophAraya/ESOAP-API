using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.RegistroDenuncio
{
    public class RegistroDenuncioModel
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
