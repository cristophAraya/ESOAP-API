using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Globalization;

namespace CharlesApi.Models.Result.ListaEvento
{
    public class ListaEventoResult
    {
        public int StatusCode { get; set; }
        [JsonProperty("totalRowCount")]
        public long TotalRowCount { get; set; }

        [JsonProperty("rowSet")]
        public RowSet RowSet { get; set; }

        [JsonProperty("resultSetId")]
        public object ResultSetId { get; set; }
    }

    public partial class RowSet
    {
        [JsonProperty("row")]
        public Row[] Row { get; set; }

        [JsonProperty("object")]
        public object[] Object { get; set; }
    }

    public partial class Row
    {
        [JsonProperty("column")]
        public Column[] Column { get; set; }
    }

    public partial class Column
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}