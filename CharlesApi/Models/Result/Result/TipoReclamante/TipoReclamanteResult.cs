





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
	using System.Text.Json.Serialization;

	namespace CharlesApi.Result.TipoReclamante
	{
	/// <summary>
		/// Esta Clase TipoReclamanteResult  Representa objeto para la salida json
		/// </summary>
		public partial class ListadoTipoReclamanteResult
		{	
			public IList<TipoReclamanteResult> TipoReclamantes { get; set; }
			public int StatusCode { get; set; }
		}

		/// <summary>
		/// Esta Clase TipoReclamanteResult  Representa objeto para la salida json
		/// </summary>
		public partial class TipoReclamanteResult
		{	
			[JsonPropertyName("codigoTipoReclamanteSura")]
			public string CodigoTipoReclamanteSura { get; set; }
			[JsonPropertyName("nombreTipoReclamanteSura")]
			public string NombreTipoReclamanteSura { get; set; }
			[JsonPropertyName("codigoTipoReclamanteCharles")]
			public string CodigoTipoReclamanteCharles { get; set; }
			[JsonPropertyName("nombreTipoReclamanteCharles")]
			public string NombreTipoReclamanteCharles { get; set; }
			public int StatusCode { get; set; }
		}
	}

