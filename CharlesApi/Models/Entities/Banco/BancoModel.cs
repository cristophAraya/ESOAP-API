





/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
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
	namespace CharlesApi.Entities.Banco
	{
		/// <summary>
		/// Esta Clase BancoModel  Representa el objeto de persistencia para la tabla Banco
		/// </summary>
		public partial class BancoModel
		{	
			public string RutBancoSura { get; set; }
			public string NombreBancoSura { get; set; }
			public string CodigoBancoSura { get; set; }
			public string NombreBancoCharles { get; set; }
			public string CodigoBancoCharles { get; set; }
			/// <summary>
			/// Constructor de la Clase BancoTo
			/// </summary>
			public BancoModel() {
 		RutBancoSura = string.Empty; 
			NombreBancoSura = string.Empty; 
			CodigoBancoSura = string.Empty; 
			NombreBancoCharles = string.Empty; 
			CodigoBancoCharles = string.Empty; 
			}
		}
	}

