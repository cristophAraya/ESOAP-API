





/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
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
namespace CharlesApi.Entities.SiniestroLog
{
    /// <summary>
    /// Esta Clase SiniestroLogModel  Representa el objeto de persistencia para la tabla SiniestroLog
    /// </summary>
    public partial class SiniestroLogModel
    {

        public string NumeroPoliza { get; set; }
        public string NumeroSiniestro { get; set; }
        public string NumeroInforme { get; set; }
        public string Status { get; set; }
        public DateTime? Fecha { get; set; }
        public string MensajeError { get; set; }
        /// <summary>
        /// Constructor de la Clase SiniestroLogTo
        /// </summary>
        public SiniestroLogModel()
        {
            NumeroSiniestro = string.Empty;
            NumeroInforme = string.Empty;
            Status = string.Empty;
            Fecha = DateTime.Now;
        }
    }
}

