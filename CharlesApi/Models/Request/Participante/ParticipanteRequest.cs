





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*24-05-2023,Generador de Código, Clase Inicial 
*/

	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Text.Json.Serialization;

namespace CharlesApi.Request.Participante
{
    /// <summary>
    /// Esta Clase ParticipanteRequest define la estructura para las llamadas a la api
    /// </summary>
    public partial class ParticipanteRequest
    {
        [MaxLength(50, ErrorMessage = "El campo Numero Siniestro tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Numero Informe tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("numeroInforme")]
        public string NumeroInforme { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Rut tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("rut")]
        public string Rut { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Primer Nombre tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("primerNombre")]
        public string PrimerNombre { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Segundo Nombre tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("segundoNombre")]
        public string SegundoNombre { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Apellidos tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("apellidos")]
        public string Apellidos { get; set; }
        [JsonPropertyName("fechaNacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Genero tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("genero")]
        public string Genero { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Pais tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("pais")]
        public string Pais { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Ciudad tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("ciudad")]
        public string Ciudad { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Region tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("region")]
        public string Region { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Comuna tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("comuna")]
        public string Comuna { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Calle tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("calle")]
        public string Calle { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Cada Depto tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("casaDepto")]
        public string CasaDepto { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Numeracion tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("numeracion")]
        public string Numeracion { get; set; }

        [JsonPropertyName("numeroSolicitud")]
        public int NumeroSolicitud { get; set; }

    }
}

