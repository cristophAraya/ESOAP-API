





/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
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
namespace CharlesApi.Entities.Participante
{
    /// <summary>
    /// Esta Clase ParticipanteModel  Representa el objeto de persistencia para la tabla Participante
    /// </summary>
    public partial class ParticipanteModel
    {
        public string NumeroSiniestro { get; set; }
        public string NumeroInforme { get; set; }
        public string Rut { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Comuna { get; set; }
        public string Calle { get; set; }
        public string CasaDepto { get; set; }
        public string Numeracion { get; set; }
        public int NumeroSolicitud { get; set; }
        /// <summary>
        /// Constructor de la Clase ParticipanteTo
        /// </summary>
        public ParticipanteModel()
        {
            NumeroSiniestro = string.Empty;
            NumeroInforme = string.Empty;
            Rut = string.Empty;
            PrimerNombre = string.Empty;
            SegundoNombre = string.Empty;
            Apellidos = string.Empty;
            FechaNacimiento = new DateTime(1900, 1, 1);
            Genero = string.Empty;
            Pais = string.Empty;
            Ciudad = string.Empty;
            Region = string.Empty;
            Comuna = string.Empty;
            Calle = string.Empty;
            CasaDepto = string.Empty;
            Numeracion = string.Empty;
        }
    }
}

