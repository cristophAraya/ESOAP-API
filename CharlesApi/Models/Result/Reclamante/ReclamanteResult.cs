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

namespace CharlesApi.Result.Reclamante
{
    /// <summary>
    /// Esta Clase ReclamanteResult  Representa objeto para la salida json
    /// </summary>
    public partial class ListadoReclamanteResult
    {
        public IList<ReclamanteResult> Reclamantes { get; set; }
        public int StatusCode { get; set; }
    }

    /// <summary>
    /// Esta Clase ReclamanteResult  Representa objeto para la salida json
    /// </summary>
    public partial class ReclamanteResult
    {
        [JsonPropertyName("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }
        [JsonPropertyName("numeroInforme")]
        public string NumeroInforme { get; set; }
        [JsonPropertyName("montoProvision")]
        public int MontoProvision { get; set; }
        [JsonPropertyName("mondeProvision")]
        public string MonedaProvision { get; set; }

        [JsonPropertyName("tipoReclamante")]
        public string TipoReclamante { get; set; }


        [JsonPropertyName("cobertura")]
        public string Cobertura { get; set; }
        [JsonPropertyName("rut")]
        public string Rut { get; set; }
        [JsonPropertyName("primerNombre")]
        public string PrimerNombre { get; set; }
        [JsonPropertyName("segundoNombre")]
        public string SegundoNombre { get; set; }
        [JsonPropertyName("apellidos")]
        public string Apellidos { get; set; }
        [JsonPropertyName("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [JsonPropertyName("genero")]
        public string Genero { get; set; }
        [JsonPropertyName("pais")]
        public string Pais { get; set; }
        [JsonPropertyName("ciudad")]
        public string Ciudad { get; set; }
        [JsonPropertyName("region")]
        public string Region { get; set; }
        [JsonPropertyName("comuna")]
        public string Comuna { get; set; }
        [JsonPropertyName("calle")]
        public string Calle { get; set; }
        [JsonPropertyName("cadaDepto")]
        public string CadaDepto { get; set; }
        [JsonPropertyName("numeracion")]
        public string Numeracion { get; set; }
        [JsonPropertyName("tipoContacto")]
        public string TipoContacto { get; set; }
        [JsonPropertyName("formaContacto")]
        public string FormaContacto { get; set; }
        [JsonPropertyName("idPersona")]
        public string IdPersona { get; set; }
        [JsonPropertyName("numeroSolicitud")]
        public int NumeroSolicitud { get; set; }
        public int StatusCode { get; set; }
    }
}

