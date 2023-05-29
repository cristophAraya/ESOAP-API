





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
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
	using System.Text.Json.Serialization;

	namespace CharlesApi.Request.TipoReclamante
	{
		/// <summary>
		/// Esta Clase TipoReclamanteRequest define la estructura para las llamadas a la api
		/// </summary>
		public partial class TipoReclamanteRequest
		{	
			[MaxLength(50, ErrorMessage ="El campo Codigo Tipo Reclamante Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("codigoTipoReclamanteSura")]
			public string CodigoTipoReclamanteSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Nombre Tipo Reclamante Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("nombreTipoReclamanteSura")]
			public string NombreTipoReclamanteSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Codigo Tipo Reclamante Charles tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("codigoTipoReclamanteCharles")]
			public string CodigoTipoReclamanteCharles { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Nombre Tipo Reclamante Charles tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("nombreTipoReclamanteCharles")]
			public string NombreTipoReclamanteCharles { get; set; }
		}
	}

