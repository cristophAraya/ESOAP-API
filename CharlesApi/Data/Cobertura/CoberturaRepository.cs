






/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*05-06-2023,Generador de Código, Clase Inicial 
*/


using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CharlesApi.Entities.Cobertura;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.Cobertura
{
	/// <summary>
	/// Esta Clase Cobertura  permite gestionar la interacción con la base de datos para la tabla Cobertura
	/// </summary>
	public partial class CoberturaRepository : DBBaseHelper, ICoberturaRepository
	{	
			public CoberturaRepository(ISettingsConfig settings) : base(settings)
			{
				this.settingsConfig = settings;
			}

		public CoberturaModel ObtenerCobertura(CoberturaModel coberturaModel)
		{
			CoberturaModel result = null;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
				string query = @"Select CodigoCoberturaSura, NombreCoberturaSura, CodigoCoberturaCharles, NombreCoberturaCharles  FROM Dbo.Cobertura WHERE  CodigoCoberturaCharles = @CodigoCoberturaCharles ";
				result = db.QueryFirstOrDefault<CoberturaModel>(query, coberturaModel);
			}
			return result;                        
		}
	}
}

