using Newtonsoft.Json;

namespace CharlesApi.Models.Request.LiquidarSiniestro
{
    public class LiquidarSiniestroRequest
    {
        [JsonProperty("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }
        [JsonProperty("numeroInforme")]
        public string NumeroInforme { get; set; }

        [JsonProperty("reclamantes")]
        public List<Reclamante> Reclamantes { get; set; }
    }

    public partial class Reclamante
    {
        [JsonProperty("codigoTipoReclamante")]
        public string CodigoTipoReclamante { get; set; }

        [JsonProperty("tipoReclamante")]
        public string TipoReclamante { get; set; }
        [JsonProperty("montoProvision")]
        public int MontoProvision { get; set; }

        [JsonProperty("monedaProvision")]
        public string MonedaProvision { get; set; }
        [JsonProperty("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

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

        public string NumeroSolicitud { get; set; }


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
        public int MontoLiquidado { get; set; }

        [JsonProperty("monedaLiquidacion")]
        public string MonedaLiquidacion { get; set; }

        [JsonProperty("fechaInformeLiquidador")]
        public DateTime FechaInformeLiquidador { get; set; }

        //[JsonProperty("beneficiarios")]
        //public List<Beneficiario> Beneficiarios { get; set; }

        [JsonProperty("participantes")]
        public List<Participante> Participantes { get; set; }
    }

    public partial class Participante
    {
        [JsonProperty("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

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

        [JsonProperty("facturas")]
        public List<Factura> Facturas { get; set; }

    }

    public partial class Beneficiario
    {
        [JsonProperty("porcentaje")]
        public int Porcentaje { get; set; }
        [JsonProperty("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

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
    }

    public partial class Factura
    {
        public string RutBeneficiario { get; set; }

        [JsonProperty("numeroFactura")]
        public int NumeroFactura { get; set; }

        [JsonProperty("valorFactura")]
        public int ValorFactura { get; set; }
        [JsonProperty("moneda")]
        public string Moneda { get; set; }

        [JsonProperty("fechaFactura")]
        public string FechaFactura { get; set; }

        [JsonProperty("beneficiarios")]
        public List<Beneficiario> Beneficiarios { get; set; }
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
        [JsonProperty("direccion")]
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

    public partial class BeneficiarioViaContacto
    {
        [JsonProperty("tipoContacto")]
        public string TipoContacto { get; set; }

        [JsonProperty("informacionContacto")]
        public string InformacionContacto { get; set; }
    }

    public partial class ReclamanteViaContacto
    {
        [JsonProperty("tipoContacto")]
        public string TipoContacto { get; set; }

        [JsonProperty("informacionContacto")]
        public string InformacionContacto { get; set; }
    }
}
