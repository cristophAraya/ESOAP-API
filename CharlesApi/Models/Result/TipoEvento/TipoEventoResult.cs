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

	namespace CharlesApi.Result.TipoEvento
	{
	/// <summary>
		/// Esta Clase TipoEventoResult  Representa objeto para la salida json
		/// </summary>
		public partial class ListadoTipoEventoResult
		{	
			public IList<TipoEventoResult> TipoEventos { get; set; }
			public int StatusCode { get; set; }
		}

		/// <summary>
		/// Esta Clase TipoEventoResult  Representa objeto para la salida json
		/// </summary>
		public partial class TipoEventoResult
		{	
			[JsonPropertyName("codigoTipoEventoSura")]
			public string CodigoTipoEventoSura { get; set; }
			[JsonPropertyName("nombreTipoEventoSura")]
			public string NombreTipoEventoSura { get; set; }
			[JsonPropertyName("codigoTipoEventoCharles")]
			public string CodigoTipoEventoCharles { get; set; }
			[JsonPropertyName("nombreTipoEventoCharles")]
			public string NombreTipoEventoCharles { get; set; }
			public int StatusCode { get; set; }
		}
	}

