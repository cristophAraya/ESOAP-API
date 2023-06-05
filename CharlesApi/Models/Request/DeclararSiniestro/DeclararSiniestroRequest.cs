using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace CharlesApi.Models.Request.DeclararSiniestro
{
    public class DeclararSiniestroRequest
    {
        [JsonProperty("patente")]
        public string Patente { get; set; }

        [JsonProperty("numeroPoliza")]
        public string NumeroPoliza { get; set; }
        //[JsonProperty("numeroInforme")]
        //public string NumeroInforme { get; set; }

        [JsonProperty("relatoSiniestro")]
        public string RelatoSiniestro { get; set; }

        [JsonProperty("fechaSiniestro")]

        public DateTime FechaSiniestro { get; set; }
        //ano+mes+dia con horas ANSI
        //

        [JsonProperty("lugarSiniestro")]
        public string LugarSiniestro { get; set; }

        [JsonProperty("comentarioSiniestro")]
        public string ComentarioSiniestro { get; set; }

        [JsonProperty("tipoEvento")]
        public string TipoEvento { get; set; }
        [JsonProperty("codigoEvento")]
        public string CodigoEvento { get; set; }
    }

}
