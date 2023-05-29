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

namespace CharlesApi.Request.Reclamante
{
    /// <summary>
    /// Esta Clase ReclamanteRequest define la estructura para las llamadas a la api
    /// </summary>
    public partial class ReclamanteRequest
    {
        [JsonPropertyName("numeroSiniestro")]
        public string NumeroSiniestro { get; set; }
        [JsonPropertyName("montoProvision")]
        public int MontoProvision { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Monde Provision tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("mondeProvision")]
        public string MonedaProvision { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Cobertura tiene un largo máximo de 50 caracteres")]     


        [JsonPropertyName("cobertura")]
        public string Cobertura { get; set; }
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
        [MaxLength(50, ErrorMessage = "El campo Tipo Contacto tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("tipoContacto")]
        public string TipoContacto { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Forma Contacto tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("formaContacto")]
        public string FormaContacto { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Id Persona tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("idPersona")]
        public string IdPersona { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Numero Solicitud tiene un largo máximo de 50 caracteres")]
        [JsonPropertyName("numeroSolicitud")]
        public int NumeroSolicitud { get; set; }

        [JsonPropertyName("numeroPoliza")]
        public string NumeroPoliza { get; set; }

        [JsonPropertyName("numeroInforme")]
        public string NumeroInforme { get; set; }

        [JsonPropertyName("codigoTipoReclamante")]
        public string CodigoTipoReclamante { get; set; }

        [JsonPropertyName("TipoReclamante")]
        public string TipoReclamante { get; set; }
    }
}

