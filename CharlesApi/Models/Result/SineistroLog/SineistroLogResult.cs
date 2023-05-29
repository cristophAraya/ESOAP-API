





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*29-03-2023,Generador de Código, Clase Inicial 
*/

    using System;
	using System.Collections.Generic;
	using System.Text.Json.Serialization;

	namespace CharlesApi.Result.SiniestroLog
	{
	/// <summary>
		/// Esta Clase SiniestroLogResult  Representa objeto para la salida json
		/// </summary>
		public partial class ListadoSiniestroLogResult
		{	
			public IList<SiniestroLogResult> SiniestroLogs { get; set; }
			public int StatusCode { get; set; }
		}

		/// <summary>
		/// Esta Clase SiniestroLogResult  Representa objeto para la salida json
		/// </summary>
		public partial class SiniestroLogResult
		{	
			[JsonPropertyName("numeroSiniestro")]
			public string NumeroSiniestro { get; set; }
			[JsonPropertyName("numeroInforme")]
			public string NumeroInforme { get; set; }
			[JsonPropertyName("status")]
			public string Status { get; set; }
			[JsonPropertyName("fecha")]
			public DateTime Fecha { get; set; }
			public int StatusCode { get; set; }
		}
	}

