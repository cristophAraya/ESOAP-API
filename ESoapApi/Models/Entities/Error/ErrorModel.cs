using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Entities.Error
{
    public class ErrorModel
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }    

        [JsonProperty("hierarchyLevel")]
        public long HierarchyLevel { get; set; }
    }
}