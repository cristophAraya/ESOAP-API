





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
	using System.ComponentModel.DataAnnotations;
	using System.Text.Json.Serialization;

	namespace CharlesApi.Request.Factura
	{
		/// <summary>
		/// Esta Clase FacturaRequest define la estructura para las llamadas a la api
		/// </summary>
		public partial class FacturaRequest
		{	
			[JsonPropertyName("numeroFactura")]
			public int? NumeroFactura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Numero Poliza tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("numeroPoliza")]
			public string NumeroPoliza { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Numero Siniestro tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("numeroSiniestro")]
			public string NumeroSiniestro { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Cobertura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("cobertura")]
			public string Cobertura { get; set; }
			[JsonPropertyName("valorFactura")]
			public int? ValorFactura { get; set; }
			[JsonPropertyName("fechaFactura")]
			public DateTime? FechaFactura { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Moneda tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("moneda")]
			public string Moneda { get; set; }
		}
	}

