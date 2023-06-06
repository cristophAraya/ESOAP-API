






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
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CharlesApi.Entities.Banco;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.Banco
{
	/// <summary>
	/// Esta Clase Banco  permite gestionar la interacción con la base de datos para la tabla Banco
	/// </summary>
	public partial class BancoRepository : DBBaseHelper, IBancoRepository
	{	

			public BancoRepository(ISettingsConfig settings) : base(settings)
			{
				this.settingsConfig = settings;
			}


		/// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
		public BancoModel ObtenerBanco(BancoModel bancoModel)
		{
			BancoModel result = null;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
				string query = @"Select RutBancoSura, NombreBancoSura, CodigoBancoSura, NombreBancoCharles, CodigoBancoCharles  FROM Dbo.Banco WHERE CodigoBancoCharles= @CodigoBancoCharles ";
				result = db.QueryFirstOrDefault<BancoModel>(query, bancoModel);
			}
			return result;                        
		}

		
	}
}

