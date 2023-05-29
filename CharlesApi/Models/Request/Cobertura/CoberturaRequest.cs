





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

	namespace CharlesApi.Request.Cobertura
	{
		/// <summary>
		/// Esta Clase CoberturaRequest define la estructura para las llamadas a la api
		/// </summary>
		public partial class CoberturaRequest
		{	
			[MaxLength(50, ErrorMessage ="El campo Codigo Cobertura Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("codigoCoberturaSura")]
			public string CodigoCoberturaSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Nombre Cobertura Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("nombreCoberturaSura")]
			public string NombreCoberturaSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Codigo Cobertura Charles tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("codigoCoberturaCharles")]
			public string CodigoCoberturaCharles { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Nombre Cobertura Charles tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("nombreCoberturaCharles")]
			public string NombreCoberturaCharles { get; set; }
		}
	}

