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
using System.Text.Json.Serialization;

namespace CharlesApi.Entities.Siniestro
{
    /// <summary>
    /// Esta Clase SiniestroModel  Representa el objeto de persistencia para la tabla Siniestro
    /// </summary>
    public partial class SiniestroModel
    {
        public string NumeroPoliza { get; set; }
        public string Patente { get; set; }
        public string RelatoSiniestro { get; set; }
        public string FechaSiniestro { get; set; }
        public string LugarSiniestro { get; set; }
        public string ComentarioSiniestro { get; set; }
        public string NumeroSiniestro { get; set; }
        public string NumeroInforme { get; set; }        
        public string CodigoEvento { get; set; }        
        public string TipoEvento { get; set; }

        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Constructor de la Clase SiniestroTo
        /// </summary>
        public SiniestroModel()
        {
            NumeroPoliza = string.Empty;
            Patente = string.Empty;
            RelatoSiniestro = string.Empty;
            FechaSiniestro = string.Empty;
            LugarSiniestro = string.Empty;
            ComentarioSiniestro = string.Empty;
            NumeroSiniestro = string.Empty;
            FechaRegistro = DateTime.Now;
        }
    }
}

