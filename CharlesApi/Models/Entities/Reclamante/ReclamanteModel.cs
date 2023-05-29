/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
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
namespace CharlesApi.Entities.Reclamante
{
    /// <summary>
    /// Esta Clase ReclamanteModel  Representa el objeto de persistencia para la tabla Reclamante
    /// </summary>
    public partial class ReclamanteModel
    {
        public string NumeroSiniestro { get; set; }
        public int MontoProvision { get; set; }
        public string MonedaProvision { get; set; }
        public string CodigoTipoReclamante { get; set; }
        public string TipoReclamante { get; set; }
        public string Cobertura { get; set; }
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
        public string TipoContacto { get; set; }
        public string FormaContacto { get; set; }
        public string IdPersona { get; set; }
        public int NumeroSolicitud { get; set; }
        public string NumeroInforme { get; set; }

        /// <summary>
        /// Constructor de la Clase ReclamanteTo
        /// </summary>
        public ReclamanteModel()
        {
            NumeroSiniestro = string.Empty;
            MontoProvision = 0;
            MonedaProvision = string.Empty;
            Cobertura = string.Empty;
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
            TipoContacto = string.Empty;
            FormaContacto = string.Empty;
            IdPersona = string.Empty;
            NumeroSolicitud = 0;
        }
    }
}

