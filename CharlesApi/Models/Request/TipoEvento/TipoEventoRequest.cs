/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
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
	using System.Text.Json.Serialization;

	namespace CharlesApi.Request.TipoEvento
	{
		/// <summary>
		/// Esta Clase TipoEventoRequest define la estructura para las llamadas a la api
		/// </summary>
		public partial class TipoEventoRequest
		{	
			[MaxLength(50, ErrorMessage ="El campo Codigo Tipo Evento Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("codigoTipoEventoSura")]
			public string CodigoTipoEventoSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Nombre Tipo Evento Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("nombreTipoEventoSura")]
			public string NombreTipoEventoSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Codigo Tipo Evento Charles tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("codigoTipoEventoCharles")]
			public string CodigoTipoEventoCharles { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Nombre Tipo Evento Charles tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("nombreTipoEventoCharles")]
			public string NombreTipoEventoCharles { get; set; }
		}
	}

