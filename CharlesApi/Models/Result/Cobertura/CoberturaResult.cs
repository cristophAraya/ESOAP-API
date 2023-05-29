





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
	using System.Text.Json.Serialization;

	namespace CharlesApi.Result.Cobertura
	{
	/// <summary>
		/// Esta Clase CoberturaResult  Representa objeto para la salida json
		/// </summary>
		public partial class ListadoCoberturaResult
		{	
			public IList<CoberturaResult> Coberturas { get; set; }
			public int StatusCode { get; set; }
		}

		/// <summary>
		/// Esta Clase CoberturaResult  Representa objeto para la salida json
		/// </summary>
		public partial class CoberturaResult
		{	
			[JsonPropertyName("codigoCoberturaSura")]
			public string CodigoCoberturaSura { get; set; }
			[JsonPropertyName("nombreCoberturaSura")]
			public string NombreCoberturaSura { get; set; }
			[JsonPropertyName("codigoCoberturaCharles")]
			public string CodigoCoberturaCharles { get; set; }
			[JsonPropertyName("nombreCoberturaCharles")]
			public string NombreCoberturaCharles { get; set; }
			public int StatusCode { get; set; }
		}
	}

