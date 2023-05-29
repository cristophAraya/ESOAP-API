/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*05-04-2023,Generador de Código, Clase Inicial 
*/


using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CharlesApi.Entities.TipoEvento;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.TipoEvento
{
	/// <summary>
	/// Esta Clase TipoEvento  permite gestionar la interacción con la base de datos para la tabla TipoEvento
	/// </summary>
	public partial class TipoEventoRepository : DBBaseHelper, ITipoEventoRepository
	{	

			public TipoEventoRepository(ISettingsConfig settings) : base(settings)
			{
				this.settingsConfig = settings;
			}

		/// <summary>
		/// Consulta todos los elementos existentes
		/// </summary>
		/// <returns>Una lista de objetos</returns>
		//public IList<TipoEventoModel> ObtenerTipoEventos( )
		//{
		//	IList<TipoEventoModel> result = null;
		//	using (IDbConnection db = new SqlConnection(GetDatabase()))
  //          {
		//		string query = @"Select CodigoTipoEventoSura, NombreTipoEventoSura, CodigoTipoEventoCharles, NombreTipoEventoCharles  FROM Dbo.TipoEvento";
		//		result = db.Query<TipoEventoModel>(query).AsList();
		//	}
		//	return result;       
		//}
		/// <summary>
		/// Consulta una colección de elementos según parámetros de busqueda
		/// </summary>
		/// <returns>Una lista de objetos para la busqueda especificada</returns>
		//public IList<TipoEventoModel> BuscarTipoEventos( )
		//{
		//	IList<TipoEventoModel> result = null;
		//	using (IDbConnection db = new SqlConnection(GetDatabase()))
  //          {
		//		string query = @"Select CodigoTipoEventoSura, NombreTipoEventoSura, CodigoTipoEventoCharles, NombreTipoEventoCharles  FROM Dbo.TipoEvento WHERE  ";
		//		result = db.Query<TipoEventoModel>(query, new {  }).AsList();
		//	}
		//	return result;       
		//}
		/// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
		public TipoEventoModel ObtenerTipoEvento(TipoEventoModel tipoEventoModel)
		{
			TipoEventoModel result = null;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
				string query = @"Select CodigoTipoEventoSura, NombreTipoEventoSura, CodigoTipoEventoCharles, NombreTipoEventoCharles  FROM Dbo.TipoEvento WHERE  CodigoTipoEventoCharles = @CodigoTipoEventoCharles ";
				result = db.QueryFirstOrDefault<TipoEventoModel>(query, tipoEventoModel);
			}
			return result;                        
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="tipoEventoModel"></param>
		/// <returns>El mismo objeto de entrada, modifica si es necesario</returns>
		//public TipoEventoModel CrearTipoEvento(TipoEventoModel tipoEventoModel)
		//{
		//	using (IDbConnection db = new SqlConnection(GetDatabase()))
  //          {
		//string query = @"INSERT INTO Dbo.TipoEvento  (CodigoTipoEventoSura, NombreTipoEventoSura, CodigoTipoEventoCharles, NombreTipoEventoCharles) VALUES (@CodigoTipoEventoSura, @NombreTipoEventoSura, @CodigoTipoEventoCharles, @NombreTipoEventoCharles)";
		//db.Execute(query, tipoEventoModel);
		//				}
		//	return tipoEventoModel;
		//}

		/// <summary>
		/// Actualiza un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="tipoEventoModel"></param>
		/// <returns>booleano indicando si la operación fue exitosa o no</returns>
		//public bool ActualizarTipoEvento(TipoEventoModel tipoEventoModel)
		//{
		//	bool result = false;
		//	using (IDbConnection db = new SqlConnection(GetDatabase()))
  //          {
		//		string query = @"UPDATE Dbo.TipoEvento SET CodigoTipoEventoSura=@CodigoTipoEventoSura, NombreTipoEventoSura=@NombreTipoEventoSura, CodigoTipoEventoCharles=@CodigoTipoEventoCharles, NombreTipoEventoCharles=@NombreTipoEventoCharles WHERE ";
		//		int i = db.Execute(query, tipoEventoModel);
  //              result = i >= 0;
		//	}
		//	return result;
		//}
		/// <summary>
		/// Elimina un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>booleano indicando si la operación fue exitosa o no</returns>
		//public bool EliminarTipoEvento()
		//{
		//	bool result = false;
		//	using (IDbConnection db = new SqlConnection(GetDatabase()))
  //          {
		//		string query = @"DELETE FROM Dbo.TipoEvento WHERE ";
  //              int i = db.Execute(query, new {  });
		//		result = i >= 1;
		//	}
		//	return result;
		//}
	}
}

