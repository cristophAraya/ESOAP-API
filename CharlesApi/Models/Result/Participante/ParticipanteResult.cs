





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*24-05-2023,Generador de Código, Clase Inicial 
*/

    using System;
	using System.Collections.Generic;
	using System.Text.Json.Serialization;

	namespace CharlesApi.Result.Participante
	{
	/// <summary>
		/// Esta Clase ParticipanteResult  Representa objeto para la salida json
		/// </summary>
		public partial class ListadoParticipanteResult
		{	
			public IList<ParticipanteResult> Participantes { get; set; }
			public int StatusCode { get; set; }
		}

		/// <summary>
		/// Esta Clase ParticipanteResult  Representa objeto para la salida json
		/// </summary>
		public partial class ParticipanteResult
		{	
			[JsonPropertyName("numeroSiniestro")]
			public string NumeroSiniestro { get; set; }
			[JsonPropertyName("numeroInforme")]
			public string NumeroInforme { get; set; }
			[JsonPropertyName("rut")]
			public string Rut { get; set; }
			[JsonPropertyName("primerNombre")]
			public string PrimerNombre { get; set; }
			[JsonPropertyName("segundoNombre")]
			public string SegundoNombre { get; set; }
			[JsonPropertyName("apellidos")]
			public string Apellidos { get; set; }
			[JsonPropertyName("fechaNacimiento")]
			public DateTime FechaNacimiento { get; set; }
			[JsonPropertyName("genero")]
			public string Genero { get; set; }
			[JsonPropertyName("pais")]
			public string Pais { get; set; }
			[JsonPropertyName("ciudad")]
			public string Ciudad { get; set; }
			[JsonPropertyName("region")]
			public string Region { get; set; }
			[JsonPropertyName("comuna")]
			public string Comuna { get; set; }
			[JsonPropertyName("calle")]
			public string Calle { get; set; }
			[JsonPropertyName("casaDepto")]
			public string CasaDepto { get; set; }
			[JsonPropertyName("numeracion")]
			public string Numeracion { get; set; }
			public int StatusCode { get; set; }
		}
	}

