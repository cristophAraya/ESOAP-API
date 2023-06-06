





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
	using System.Text.Json.Serialization;

	namespace CharlesApi.Result.Banco
	{
	/// <summary>
		/// Esta Clase BancoResult  Representa objeto para la salida json
		/// </summary>
		public partial class ListadoBancoResult
		{	
			public IList<BancoResult> Bancos { get; set; }
			public int StatusCode { get; set; }
		}

		/// <summary>
		/// Esta Clase BancoResult  Representa objeto para la salida json
		/// </summary>
		public partial class BancoResult
		{	
			[JsonPropertyName("rutBancoSura")]
			public string RutBancoSura { get; set; }
			[JsonPropertyName("nombreBancoSura")]
			public string NombreBancoSura { get; set; }
			[JsonPropertyName("codigoBancoSura")]
			public string CodigoBancoSura { get; set; }
			[JsonPropertyName("nombreBancoCharles")]
			public string NombreBancoCharles { get; set; }
			[JsonPropertyName("codigoBancoCharles")]
			public string CodigoBancoCharles { get; set; }
			public int StatusCode { get; set; }
		}
	}

