





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*06-06-2023,Generador de Código, Clase Inicial 
*/

	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Text.Json.Serialization;

	namespace CharlesApi.Request.Banco
	{
		/// <summary>
		/// Esta Clase BancoRequest define la estructura para las llamadas a la api
		/// </summary>
		public partial class BancoRequest
		{	
			[MaxLength(50, ErrorMessage ="El campo Rut Banco Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("rutBancoSura")]
			public string RutBancoSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Nombre Banco Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("nombreBancoSura")]
			public string NombreBancoSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Codigo Banco Sura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("codigoBancoSura")]
			public string CodigoBancoSura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Nombre Banco Charles tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("nombreBancoCharles")]
			public string NombreBancoCharles { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Codigo Banco Charles tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("codigoBancoCharles")]
			public string CodigoBancoCharles { get; set; }
		}
	}

