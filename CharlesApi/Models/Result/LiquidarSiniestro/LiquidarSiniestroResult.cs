using Newtonsoft.Json;

namespace CharlesApi.Models.Result.LiquidarSiniestro
{
    public class LiquidarSiniestroResult
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        //[JsonProperty("numeroSiniestro")]
        //public string NumeroSiniestro { get; set; }

        //[JsonProperty("reclamantes")]
        //public List<Reclamante> Reclamantes { get; set; }
        [JsonProperty("Errores")]
        public List<string> Errores { get; set; } = new List<string>();
    }

    public partial class Reclamante
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
        public Direccion Direccion { get; set; }

        [JsonProperty("viaContacto")]
        public ReclamanteViaContacto ViaContacto { get; set; }

        [JsonProperty("coberturasSiniestradas")]
        public List<CoberturasSiniestrada> CoberturasSiniestradas { get; set; }
    }

    public partial class CoberturasSiniestrada
    {
        [JsonProperty("cobertura")]
        public string Cobertura { get; set; }

        [JsonProperty("montoLiquidado")]
        public long MontoLiquidado { get; set; }

        [JsonProperty("monedaLiquidacion")]
        public string MonedaLiquidacion { get; set; }

        [JsonProperty("fechaInspeccion")]
        public string FechaInspeccion { get; set; }

        [JsonProperty("beneficiarios")]
        public List<Beneficiario> Beneficiarios { get; set; }
    }

    public partial class Beneficiario
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
        public Direccion Direccion { get; set; }

        [JsonProperty("viaContacto")]
        public BeneficiarioViaContacto ViaContacto { get; set; }

        [JsonProperty("cuentaBancaria")]
        public CuentaBancaria CuentaBancaria { get; set; }

        [JsonProperty("resultado")]
        public Resultado Resultado { get; set; }
    }

    public partial class CuentaBancaria
    {
        [JsonProperty("moneda")]
        public string Moneda { get; set; }

        [JsonProperty("numeroCuenta")]
        public string NumeroCuenta { get; set; }

        [JsonProperty("banco")]
        public string Banco { get; set; }
    }

    public partial class Direccion
    {
        [JsonProperty("direcion")]
        public string Direcion { get; set; }

        [JsonProperty("casaDepto")]
        public string CasaDepto { get; set; }

        [JsonProperty("ciudad")]
        public string Ciudad { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("codigoPostal")]
        public string CodigoPostal { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("comuna")]
        public string Comuna { get; set; }

        [JsonProperty("calle")]
        public string Calle { get; set; }

        [JsonProperty("numeracion")]
        public string Numeracion { get; set; }
    }

    public partial class Resultado
    {
        [JsonProperty("docladId")]
        public long DocladId { get; set; }

        [JsonProperty("docladNo")]
        public long DocladNo { get; set; }

        [JsonProperty("docladState")]
        public long DocladState { get; set; }
    }

    public partial class BeneficiarioViaContacto
    {
        [JsonProperty("tipoContacto")]
        public string TipoContacto { get; set; }

        [JsonProperty("formaContacto")]
        public string FormaContacto { get; set; }
    }

    public partial class ReclamanteViaContacto
    {
        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }
}
