





/**
* (c)2019-2023 NEGS Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*22-03-2023,Generador de Código, Clase Inicial 
*/

	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Text.Json.Serialization;

	namespace CharlesApi.Request.Beneficiario
	{
		/// <summary>
		/// Esta Clase BeneficiarioRequest define la estructura para las llamadas a la api
		/// </summary>
		public partial class BeneficiarioRequest
		{	
			[JsonPropertyName("NumeroSiniestro")]
			public int? NumeroSiniestro { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Rut Reclamante tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("rutReclamante")]
			public string RutReclamante { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Cobertura tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("cobertura")]
			public string Cobertura { get; set; }
			[JsonPropertyName("porcentaje")]
			public int? Porcentaje { get; set; }
			[JsonPropertyName("fechaNacimiento")]
			public DateTime? FechaNacimiento { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Rut tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("rut")]
			public string Rut { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Primer Nombre tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("primerNombre")]
			public string PrimerNombre { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Segundo Nombre tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("segundoNombre")]
			public string SegundoNombre { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Apellidos tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("apellidos")]
			public string Apellidos { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Genero tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("genero")]
			public string Genero { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Pais tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("pais")]
			public string Pais { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Region tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("region")]
			public string Region { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Comuna tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("comuna")]
			public string Comuna { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Calle tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("calle")]
			public string Calle { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Casa Depto tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("casaDepto")]
			public string CasaDepto { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Numeracion tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("numeracion")]
			public string Numeracion { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Tipo Contacto tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("tipoContacto")]
			public string TipoContacto { get; set; }
			[MaxLength(50, ErrorMessage ="El campo Forma Contact tiene un largo máximo de 50 caracteres")]
			[JsonPropertyName("formaContact")]
			public string FormaContact { get; set; }
			[JsonPropertyName("docladId")]
			public int? DocladId { get; set; }
			[JsonPropertyName("docladNo")]
			public int? DocladNo { get; set; }
			[JsonPropertyName("docladState")]
			public int? DocladState { get; set; }
		}
	}

