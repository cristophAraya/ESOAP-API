





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*05-07-2023,Generador de Código, Clase Inicial 
*/

    using System;
	using System.Collections.Generic;
	using System.Text.Json.Serialization;

	namespace CharlesApi.Result.Factura
	{
	/// <summary>
		/// Esta Clase FacturaResult  Representa objeto para la salida json
		/// </summary>
		public partial class ListadoFacturaResult
		{	
			public IList<FacturaResult> Facturas { get; set; }
			public int StatusCode { get; set; }
		}

		/// <summary>
		/// Esta Clase FacturaResult  Representa objeto para la salida json
		/// </summary>
		public partial class FacturaResult
		{	
			[JsonPropertyName("numeroFactura")]
			public int NumeroFactura { get; set; }
			[JsonPropertyName("numeroPoliza")]
			public string NumeroPoliza { get; set; }
			[JsonPropertyName("numeroSiniestro")]
			public string NumeroSiniestro { get; set; }
			[JsonPropertyName("cobertura")]
			public string Cobertura { get; set; }
			[JsonPropertyName("valorFactura")]
			public int ValorFactura { get; set; }
			[JsonPropertyName("fechaFactura")]
			public DateTime FechaFactura { get; set; }
			[JsonPropertyName("moneda")]
			public string Moneda { get; set; }
			public int StatusCode { get; set; }
		}
	}

