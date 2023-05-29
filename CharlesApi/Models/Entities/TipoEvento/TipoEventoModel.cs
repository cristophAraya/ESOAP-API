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
	namespace CharlesApi.Entities.TipoEvento
	{
		/// <summary>
		/// Esta Clase TipoEventoModel  Representa el objeto de persistencia para la tabla TipoEvento
		/// </summary>
		public partial class TipoEventoModel
		{	
			public string CodigoTipoEventoSura { get; set; }
			public string NombreTipoEventoSura { get; set; }
			public string CodigoTipoEventoCharles { get; set; }
			public string NombreTipoEventoCharles { get; set; }
			/// <summary>
			/// Constructor de la Clase TipoEventoTo
			/// </summary>
			public TipoEventoModel() {
 		CodigoTipoEventoSura = string.Empty; 
			NombreTipoEventoSura = string.Empty; 
			CodigoTipoEventoCharles = string.Empty; 
			NombreTipoEventoCharles = string.Empty; 
			}
		}
	}

