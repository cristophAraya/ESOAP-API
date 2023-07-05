






/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*05-07-2023,Generador de Código, Clase Inicial 
*/

using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CharlesApi.Entities.Factura;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.Factura
{
	/// <summary>
	/// Esta Clase Factura  permite gestionar la interacción con la base de datos para la tabla Factura
	/// </summary>
	public partial class FacturaRepository : DBBaseHelper, IFacturaRepository
	{	

			public FacturaRepository(ISettingsConfig settings) : base(settings)
			{
				this.settingsConfig = settings;
			}

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="facturaModel"></param>
        /// <returns>El mismo objeto de entrada, modifica si es necesario</returns>
        public FacturaModel CrearFactura(FacturaModel facturaModel)
        {
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"INSERT INTO Dbo.Factura  (NumeroFactura, NumeroPoliza, NumeroSiniestro, Cobertura, ValorFactura, FechaFactura, Moneda) VALUES (@NumeroFactura, @NumeroPoliza, @NumeroSiniestro, @Cobertura, @ValorFactura, @FechaFactura, @Moneda)";
                db.Execute(query, facturaModel);
            }
            return facturaModel;
        }


	}
}

