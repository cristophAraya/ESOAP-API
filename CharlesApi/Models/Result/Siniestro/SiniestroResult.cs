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

namespace CharlesApi.Result.Siniestro
{
    /// <summary>
    /// Esta Clase SiniestroResult  Representa objeto para la salida json
    /// </summary>
    public partial class ListadoSiniestroResult
    {
        public IList<SiniestroResult> Siniestros { get; set; }
        public int StatusCode { get; set; }
    }

    /// <summary>
    /// Esta Clase SiniestroResult  Representa objeto para la salida json
    /// </summary>
    public partial class SiniestroResult
    {
        [JsonPropertyName("numeroPoliza")]
        public string NumeroPoliza { get; set; }
        [JsonPropertyName("patente")]
        public string Patente { get; set; }
        [JsonPropertyName("relatoSiniestro")]
        public string RelatoSiniestro { get; set; }
        [JsonPropertyName("fechaSiniestro")]
        public string FechaSiniestro { get; set; }
        [JsonPropertyName("lugarSiniestro")]
        public string LugarSiniestro { get; set; }
        [JsonPropertyName("comentarioSiniestro")]
        public string ComentarioSiniestro { get; set; }
        [JsonPropertyName("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }

        [JsonPropertyName("numeroInforme")]
        public string NumeroInforme { get; set; }
        public int StatusCode { get; set; }
    }
}

