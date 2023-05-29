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
	using System.ComponentModel.DataAnnotations;
	using System.Text.Json.Serialization;

namespace CharlesApi.Request.CoberturaSiniestrada
{
    /// <summary>
    /// Esta Clase CoberturaSiniestradaRequest define la estructura para las llamadas a la api
    /// </summary>
    public partial class CoberturaSiniestradaRequest
    {
        [JsonPropertyName("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }

        [JsonPropertyName("numeroInforme")]
        public string NumeroInforme { get; set; }

        [JsonPropertyName("numeroSolicitud")]
        public int NumeroSolicitud { get; set; }


        [MaxLength(50, ErrorMessage = "El campo Rut Reclamante tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("rutReclamante")]
        public string RutReclamante { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Cobertura tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("cobertura")]
        public string Cobertura { get; set; }
        [JsonPropertyName("montoLiquidado")]
        public int? MontoLiquidado { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Moneda Liquidacion tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("monedaLiquidacion")]
        public string MonedaLiquidacion { get; set; }
        [JsonPropertyName("fechaInformeLiquidador")]
        public DateTime? FechaInformeLiquidador { get; set; }
    }
}

