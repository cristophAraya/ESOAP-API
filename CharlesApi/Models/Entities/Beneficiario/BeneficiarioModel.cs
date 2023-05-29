





/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
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

namespace CharlesApi.Entities.Beneficiario
{
    /// <summary>
    /// Esta Clase BeneficiarioModel  Representa el objeto de persistencia para la tabla Beneficiario
    /// </summary>
    public partial class BeneficiarioModel
    {
        public string NumeroSiniestro { get; set; }
        public string NumeroInforme { get; set; }
        public string RutReclamante { get; set; }
        public string RutParticipante { get; set; }
        public string Cobertura { get; set; }
        public int? Porcentaje { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Rut { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string Pais { get; set; }
        public string Region { get; set; }
        public string Comuna { get; set; }
        public string Ciudad { get; set; }

        public string Calle { get; set; }
        public string CasaDepto { get; set; }
        public string Numeracion { get; set; }
        public string TipoContacto { get; set; }
        public string FormaContacto { get; set; }          
        public string Moneda { get; set; }  
        public string NumeroCuenta { get; set; }  
        public string Banco { get; set; }
        public long DocladId { get; set; }
        public long DocladNo { get; set; }
        public long DocladState { get; set; }

        public int NumeroSolicitud { get; set; }


        /// <summary>
        /// Constructor de la Clase BeneficiarioTo
        /// </summary>
        public BeneficiarioModel()
        {
            NumeroSiniestro = string.Empty;
            RutReclamante = string.Empty;
            Cobertura = string.Empty;
            Porcentaje = 0;
            FechaNacimiento = new DateTime(1900, 1, 1);
            Rut = string.Empty;
            PrimerNombre = string.Empty;
            SegundoNombre = string.Empty;
            Apellidos = string.Empty;
            Genero = string.Empty;
            Pais = string.Empty;
            Region = string.Empty;
            Comuna = string.Empty;
            Calle = string.Empty;
            CasaDepto = string.Empty;
            Numeracion = string.Empty;
            TipoContacto = string.Empty;
            FormaContacto = string.Empty;
            DocladId = 0;
            DocladNo = 0;
            DocladState = 0;
        }
    }
}

