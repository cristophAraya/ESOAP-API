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

namespace CharlesApi.Result.CoberturaSiniestrada
{
    /// <summary>
    /// Esta Clase CoberturaSiniestradaResult  Representa objeto para la salida json
    /// </summary>
    public partial class ListadoCoberturaSiniestradaResult
    {
        public IList<CoberturaSiniestradaResult> CoberturaSiniestradas { get; set; }
        public int StatusCode { get; set; }
    }

    /// <summary>
    /// Esta Clase CoberturaSiniestradaResult  Representa objeto para la salida json
    /// </summary>
    public partial class CoberturaSiniestradaResult
    {
        [JsonPropertyName("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }
        [JsonPropertyName("numeroSolicitud")]
        public int NumeroSolicitud { get; set; }
        [JsonPropertyName("rutReclamante")]
        public string RutReclamante { get; set; }
        [JsonPropertyName("cobertura")]
        public string Cobertura { get; set; }
        [JsonPropertyName("montoLiquidado")]
        public int MontoLiquidado { get; set; }
        [JsonPropertyName("monedaLiquidacion")]
        public string MonedaLiquidacion { get; set; }
        [JsonPropertyName("fechaInformeLiquidador")]
        public DateTime FechaInformeLiquidador { get; set; }
        public int StatusCode { get; set; }
    }
}

