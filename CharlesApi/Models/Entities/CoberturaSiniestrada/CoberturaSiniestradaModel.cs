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
namespace CharlesApi.Entities.CoberturaSiniestrada
{
    /// <summary>
    /// Esta Clase CoberturaSiniestradaModel  Representa el objeto de persistencia para la tabla CoberturaSiniestrada
    /// </summary>
    public partial class CoberturaSiniestradaModel
    {
        public string NumeroSiniestro { get; set; }
        public string NumeroInforme { get; set; }
        public string NumeroSolicitud { get; set; }


        public string RutReclamante { get; set; }
        public string Cobertura { get; set; }
        public int? MontoLiquidado { get; set; }
        public string MonedaLiquidacion { get; set; }
        public DateTime? FechaInformeLiquidador { get; set; }

        /// <summary>
        /// Constructor de la Clase CoberturaSiniestradaTo
        /// </summary>
        public CoberturaSiniestradaModel()
        {
            NumeroSiniestro = string.Empty;
            RutReclamante = string.Empty;
            Cobertura = string.Empty;
            MontoLiquidado = 0;
            MonedaLiquidacion = string.Empty;
            FechaInformeLiquidador = new DateTime(1900, 1, 1);
        }
    }
}

