





/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*05-04-2023,Generador de Código, Clase Inicial 
*/

	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	namespace CharlesApi.Entities.Cobertura
	{
		/// <summary>
		/// Esta Clase CoberturaModel  Representa el objeto de persistencia para la tabla Cobertura
		/// </summary>
		public partial class CoberturaModel
		{	
			public string CodigoCoberturaSura { get; set; }
			public string NombreCoberturaSura { get; set; }
			public string CodigoCoberturaCharles { get; set; }
			public string NombreCoberturaCharles { get; set; }
			/// <summary>
			/// Constructor de la Clase CoberturaTo
			/// </summary>
			public CoberturaModel() {
 		CodigoCoberturaSura = string.Empty; 
			NombreCoberturaSura = string.Empty; 
			CodigoCoberturaCharles = string.Empty; 
			NombreCoberturaCharles = string.Empty; 
			}
		}
	}

