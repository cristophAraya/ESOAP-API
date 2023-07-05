





/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*05-07-2023,Generador de Código, Clase Inicial 
*/

	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	namespace CharlesApi.Entities.Factura
	{
		/// <summary>
		/// Esta Clase FacturaModel  Representa el objeto de persistencia para la tabla Factura
		/// </summary>
		public partial class FacturaModel
		{	
			public int? NumeroFactura { get; set; }
			public string NumeroPoliza { get; set; }
			public string NumeroSiniestro { get; set; }
			public string Cobertura { get; set; }
			public int? ValorFactura { get; set; }
			public DateTime? FechaFactura { get; set; }
			public string Moneda { get; set; }
			/// <summary>
			/// Constructor de la Clase FacturaTo
			/// </summary>
			public FacturaModel() {
 		NumeroFactura = 0; 
			NumeroPoliza = string.Empty; 
			NumeroSiniestro = string.Empty; 
			Cobertura = string.Empty; 
			ValorFactura = 0; 
			FechaFactura = new DateTime(1900,1,1); 
			Moneda = string.Empty; 
			}
		}
	}

