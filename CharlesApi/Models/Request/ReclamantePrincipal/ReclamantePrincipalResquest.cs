using Newtonsoft.Json;

namespace CharlesApi.Models.Request.ReclamantePrincipal
{
    public class ReclamantePrincipalResquest
    {
        [JsonProperty("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }

        [JsonProperty("numeroInforme")]
        public string NumeroInforme { get; set; }

        [JsonProperty("montoProvision")]
        public int MontoProvision { get; set; }

        [JsonProperty("monedaProvision")]
        public string MonedaProvision { get; set; }

        [JsonProperty("cobertura")]
        public string Cobertura { get; set; }

        [JsonProperty("reclamante")]
        public ReclamantePrincipal Reclamante { get; set; }
    }

    public partial class ReclamantePrincipal
    {
        [JsonProperty("codigoTipoReclamante")]
        public string CodigoTipoReclamante { get; set; }

        [JsonProperty("tipoReclamante")]
        public string TipoReclamante { get; set; }

        [JsonProperty("fechaNacimiento")]
        public string FechaNacimiento { get; set; }

        [JsonProperty("rut")]
        public string Rut { get; set; }

        [JsonProperty("primerNombre")]
        public string PrimerNombre { get; set; }

        [JsonProperty("segundoNombre")]
        public string SegundoNombre { get; set; }

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("genero")]
        public string Genero { get; set; }

        [JsonProperty("direccion")]
        public DireccionPrincipal Direccion { get; set; }

        [JsonProperty("viaContacto")]
        public ViaContactoPrincipal ViaContacto { get; set; }

        [JsonProperty("participante")]
        public ParticipantePrincipal Participante { get; set; }
    }

    public class ParticipantePrincipal
    {
        [JsonProperty("fechaNacimiento")]
        public string FechaNacimiento { get; set; }

        [JsonProperty("rut")]
        public string Rut { get; set; }

        [JsonProperty("primerNombre")]
        public string PrimerNombre { get; set; }

        [JsonProperty("segundoNombre")]
        public string SegundoNombre { get; set; }

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("genero")]
        public string Genero { get; set; }

        [JsonProperty("direccion")]
        public DireccionPrincipal Direccion { get; set; }
    }

    public partial class DireccionPrincipal
    {
        [JsonProperty("casaDepto")]
        public string CasaDepto { get; set; }

        [JsonProperty("ciudad")]
        public string Ciudad { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("comuna")]
        public string Comuna { get; set; }

        [JsonProperty("calle")]
        public string Calle { get; set; }

        [JsonProperty("numeracion")]
        public string Numeracion { get; set; }
    }

    public partial class ViaContactoPrincipal
    {
        [JsonProperty("tipoContacto")]
        public string TipoContacto { get; set; }

        [JsonProperty("formaContacto")]
        public string FormaContacto { get; set; }
    }
}

