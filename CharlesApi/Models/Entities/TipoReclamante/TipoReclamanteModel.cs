





/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*13-04-2023,Generador de Código, Clase Inicial 
*/

	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	namespace CharlesApi.Entities.TipoReclamante
	{
		/// <summary>
		/// Esta Clase TipoReclamanteModel  Representa el objeto de persistencia para la tabla TipoReclamante
		/// </summary>
		public partial class TipoReclamanteModel
		{	
			public string CodigoTipoReclamanteSura { get; set; }
			public string NombreTipoReclamanteSura { get; set; }
			public string CodigoTipoReclamanteCharles { get; set; }
			public string NombreTipoReclamanteCharles { get; set; }
			/// <summary>
			/// Constructor de la Clase TipoReclamanteTo
			/// </summary>
			public TipoReclamanteModel() {
 		CodigoTipoReclamanteSura = string.Empty; 
			NombreTipoReclamanteSura = string.Empty; 
			CodigoTipoReclamanteCharles = string.Empty; 
			NombreTipoReclamanteCharles = string.Empty; 
			}
		}
	}

