





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*22-03-2023,Generador de Código, Clase Inicial 
*/

    using System;
	using System.Collections.Generic;
	using System.Text.Json.Serialization;

namespace CharlesApi.Result.Beneficiario
{
    /// <summary>
    /// Esta Clase BeneficiarioResult  Representa objeto para la salida json
    /// </summary>
    public partial class ListadoBeneficiarioResult
    {
        public IList<BeneficiarioResult> Beneficiarios { get; set; }
        public int StatusCode { get; set; }
    }

    /// <summary>
    /// Esta Clase BeneficiarioResult  Representa objeto para la salida json
    /// </summary>
    public partial class BeneficiarioResult
    {
        [JsonPropertyName("NumeroSiniestro")]
        public int NumeroSiniestro { get; set; }
        [JsonPropertyName("rutReclamante")]
        public string RutReclamante { get; set; }
        [JsonPropertyName("cobertura")]
        public string Cobertura { get; set; }
        [JsonPropertyName("porcentaje")]
        public int Porcentaje { get; set; }
        [JsonPropertyName("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [JsonPropertyName("rut")]
        public string Rut { get; set; }
        [JsonPropertyName("primerNombre")]
        public string PrimerNombre { get; set; }
        [JsonPropertyName("segundoNombre")]
        public string SegundoNombre { get; set; }
        [JsonPropertyName("apellidos")]
        public string Apellidos { get; set; }
        [JsonPropertyName("genero")]
        public string Genero { get; set; }
        [JsonPropertyName("pais")]
        public string Pais { get; set; }
        [JsonPropertyName("region")]
        public string Region { get; set; }
        [JsonPropertyName("comuna")]
        public string Comuna { get; set; }
        [JsonPropertyName("calle")]
        public string Calle { get; set; }
        [JsonPropertyName("casaDepto")]
        public string CasaDepto { get; set; }
        [JsonPropertyName("numeracion")]
        public string Numeracion { get; set; }
        [JsonPropertyName("tipoContacto")]
        public string TipoContacto { get; set; }
        [JsonPropertyName("formaContact")]
        public string FormaContact { get; set; }
        [JsonPropertyName("docladId")]
        public int DocladId { get; set; }
        [JsonPropertyName("docladNo")]
        public int DocladNo { get; set; }
        [JsonPropertyName("docladState")]
        public int DocladState { get; set; }
        public int StatusCode { get; set; }


        [JsonPropertyName("ciudad")]
        public string Ciudad { get; set; }
        [JsonPropertyName("moneda")]
        public string Moneda { get; set; }
        [JsonPropertyName("numeroCuenta")]
        public string NumeroCuenta { get; set; }
        [JsonPropertyName("banco")]
        public string Banco { get; set; }


    }
}

