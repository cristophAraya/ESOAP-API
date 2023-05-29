
using Newtonsoft.Json;

namespace Cl.Sura.QuartzSoap.Models.Result.ConsultaPersona
{
    public class ConsultaPersonaResult
    {
        public int StatusCode { get; set; }
        [JsonProperty("ResultSetID")]
        public object ResultSetId { get; set; }

        [JsonProperty("TotalRowCount")]
        public long TotalRowCount { get; set; }

        [JsonProperty("RowSet")]
        public RowSet[] RowSet { get; set; }
    }

    public partial class RowSet
    {
        [JsonProperty("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("operation")]
        public object Operation { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("manComp")]
        public long ManComp { get; set; }

        [JsonProperty("birthDate")]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("egn")]

        public long Egn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gname")]
        public string Gname { get; set; }

        [JsonProperty("sname")]
        public string Sname { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("sex")]
        public long Sex { get; set; }

        [JsonProperty("namePrefix")]
        public object NamePrefix { get; set; }

        [JsonProperty("nameSuffix")]
        public object NameSuffix { get; set; }

        [JsonProperty("nationality")]
        public object Nationality { get; set; }

        [JsonProperty("homeCountry")]
        public object HomeCountry { get; set; }

        [JsonProperty("language")]
        public object Language { get; set; }

        [JsonProperty("classCode")]
        public object ClassCode { get; set; }

        [JsonProperty("classSubCode")]
        public object ClassSubCode { get; set; }

        [JsonProperty("compType")]
        public object CompType { get; set; }

        [JsonProperty("dataSource")]
        public object DataSource { get; set; }

        [JsonProperty("fiscalPeriod")]
        public object FiscalPeriod { get; set; }

        [JsonProperty("industryCode")]
        public object IndustryCode { get; set; }

        [JsonProperty("subIndustryCode")]
        public object SubIndustryCode { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("attr1")]
        public object Attr1 { get; set; }

        [JsonProperty("attr2")]
        public object Attr2 { get; set; }

        [JsonProperty("attr3")]
        public object Attr3 { get; set; }

        [JsonProperty("attr4")]
        public object Attr4 { get; set; }

        [JsonProperty("attr5")]
        public object Attr5 { get; set; }
    }
}
