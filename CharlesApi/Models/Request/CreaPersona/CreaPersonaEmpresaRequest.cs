using Newtonsoft.Json;

namespace CharlesApi.Models.Request.CreaPersona
{
    public class CreaPersonaEmpresaRequest
    {
        [JsonProperty("manComp")]
        public int ManComp { get; set; }

        [JsonProperty("egn")]
        public string Egn { get; set; }

        public string Name { get; set; }
       
    }
}
