using Newtonsoft.Json;

namespace Cl.Sura.QuartzESoap.Models.Request.ListaEvento
{
    public class ListaEventoRequest
    {
        [JsonProperty("queryId")]
        public string QueryId { get; set; }

        [JsonProperty("filterCriteria")]
        public FilterCriteria FilterCriteria { get; set; }
    }

    public partial class FilterCriteria
    {
        [JsonProperty("filterCriterion")]
        public FilterCriterion[] FilterCriterion { get; set; }
    }

    public partial class FilterCriterion
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }
    }
}
