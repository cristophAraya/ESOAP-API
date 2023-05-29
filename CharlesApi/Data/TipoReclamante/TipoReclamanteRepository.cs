






/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*13-04-2023,Generador de Código, Clase Inicial 
*/


using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CharlesApi.Entities.TipoReclamante;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.TipoReclamante
{
	/// <summary>
	/// Esta Clase TipoReclamante  permite gestionar la interacción con la base de datos para la tabla TipoReclamante
	/// </summary>
	public partial class TipoReclamanteRepository : DBBaseHelper, ITipoReclamanteRepository
	{	

			public TipoReclamanteRepository(ISettingsConfig settings) : base(settings)
			{
				this.settingsConfig = settings;
			}


		/// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
		public TipoReclamanteModel ObtenerTipoReclamante(TipoReclamanteModel tipoReclamanteModel)
		{
			TipoReclamanteModel result = null;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
				string query = @"Select CodigoTipoReclamanteSura, NombreTipoReclamanteSura, CodigoTipoReclamanteCharles, NombreTipoReclamanteCharles  FROM Dbo.TipoReclamante WHERE CodigoTipoReclamanteCharles = @CodigoTipoReclamanteCharles ";
				result = db.QueryFirstOrDefault<TipoReclamanteModel>(query, tipoReclamanteModel);
			}
			return result;                        
		}

	
	}
}

