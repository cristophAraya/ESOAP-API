using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.RegistroReclamante
{
    public class RegistroReclamanteModel
    {
        public int StatusCode { get; set; }
        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requestNo")]
        public long RequestNo { get; set; }

        [JsonProperty("claimState")]
        public long ClaimState { get; set; }

        [JsonProperty("claimStateAux")]
        public long ClaimStateAux { get; set; }

        [JsonProperty("returningMessages")]
        public ReturningMessages ReturningMessages { get; set; }
    }

    public partial class ReturningMessages
    {
        [JsonProperty("returningMessage")]
        public List<object> ReturningMessage { get; set; }
    }
}
