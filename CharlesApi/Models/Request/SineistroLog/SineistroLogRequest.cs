





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*29-03-2023,Generador de Código, Clase Inicial 
*/

	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Text.Json.Serialization;

	namespace CharlesApi.Request.SiniestroLog
	{
    /// <summary>
    /// Esta Clase SiniestroLogRequest define la estructura para las llamadas a la api
    /// </summary>
    public partial class SiniestroLogRequest
    {
        [JsonPropertyName("numeroPoliza")]
        public string NumeroPoliza { get; set; }

        [MaxLength(50, ErrorMessage = "El campo Numero Siniestro tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Numero Informe tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("numeroInforme")]
        public string NumeroInforme { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Status tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("fecha")]
        public DateTime? Fecha { get; set; }
        public string MensajeError { get; set; }


    }
	}

