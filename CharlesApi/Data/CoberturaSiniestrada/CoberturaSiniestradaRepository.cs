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

using Dapper;
using System.Data;
using System.Data.SqlClient;
using CharlesApi.Entities.CoberturaSiniestrada;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.CoberturaSiniestrada
{
    /// <summary>
    /// Esta Clase CoberturaSiniestrada  permite gestionar la interacción con la base de datos para la tabla CoberturaSiniestrada
    /// </summary>
    public partial class CoberturaSiniestradaRepository : DBBaseHelper, ICoberturaSiniestradaRepository
    {

        public CoberturaSiniestradaRepository(ISettingsConfig settings) : base(settings)
        {
            this.settingsConfig = settings;
        }

        /// <summary>
        /// Consulta todos los elementos existentes
        /// </summary>
        /// <returns>Una lista de objetos</returns>
        public IList<CoberturaSiniestradaModel> ObtenerCoberturaSiniestradas()
        {
            IList<CoberturaSiniestradaModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro, NumeroInforme,RutReclamante, Cobertura, MontoLiquidado, MonedaLiquidacion, FechaInformeLiquidador  FROM Dbo.CoberturaSiniestrada";
                result = db.Query<CoberturaSiniestradaModel>(query).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta una colección de elementos según parámetros de busqueda
        /// </summary>
        /// <returns>Una lista de objetos para la busqueda especificada</returns>
        public IList<CoberturaSiniestradaModel> BuscarCoberturaSiniestradas(CoberturaSiniestradaModel coberturaSiniestradaModel)
        {
            IList<CoberturaSiniestradaModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro,NumeroInforme, RutReclamante, Cobertura, MontoLiquidado, MonedaLiquidacion, FechaInformeLiquidador  
                                    FROM Dbo.CoberturaSiniestrada 
                                    WHERE  NumeroInforme = @NumeroInforme
                                    AND NumeroSiniestro = @NumeroSiniestro";
                //and RutReclamante = @RutReclamante  ";
                result = db.Query<CoberturaSiniestradaModel>(query,
                                                new
                                                {
                                                    NumeroInforme = coberturaSiniestradaModel.NumeroInforme,
                                                    NumeroSiniestro = coberturaSiniestradaModel.NumeroSiniestro
                                                    //RutReclamante = coberturaSiniestradaModel.RutReclamante
                                                }).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
        public CoberturaSiniestradaModel ObtenerCoberturaSiniestrada(CoberturaSiniestradaModel coberturaSiniestradaModel)
        {
            CoberturaSiniestradaModel result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro,NumeroInforme, RutReclamante, Cobertura, MontoLiquidado, MonedaLiquidacion, FechaInformeLiquidador  
                                FROM Dbo.CoberturaSiniestrada WHERE  NumeroInforme = @NumeroInforme AND NumeroSiniestro=@NumeroSiniestro and Cobertura = @Cobertura ";
                result = db.QueryFirstOrDefault<CoberturaSiniestradaModel>(query, new { NumeroInforme = coberturaSiniestradaModel.NumeroInforme, NumeroSiniestro = coberturaSiniestradaModel.NumeroSiniestro, Cobertura = coberturaSiniestradaModel.Cobertura });
            }
            return result;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="coberturaSiniestradaModel"></param>
        /// <returns>El mismo objeto de entrada, modifica si es necesario</returns>
        public CoberturaSiniestradaModel CrearCoberturaSiniestrada(CoberturaSiniestradaModel coberturaSiniestradaModel)
        {
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"INSERT INTO Dbo.CoberturaSiniestrada  (NumeroSiniestro, NumeroInforme,NumeroSolicitud,RutReclamante, Cobertura, MontoLiquidado, MonedaLiquidacion, FechaInformeLiquidador) VALUES (@NumeroSiniestro,@NumeroInforme, @NumeroSolicitud, @RutReclamante, @Cobertura, @MontoLiquidado, @MonedaLiquidacion, @FechaInformeLiquidador)";
                db.Execute(query, coberturaSiniestradaModel);
            }
            return coberturaSiniestradaModel;
        }

        /// <summary>
        /// Actualiza un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="coberturaSiniestradaModel"></param>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool ActualizarCoberturaSiniestrada(CoberturaSiniestradaModel coberturaSiniestradaModel)
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"UPDATE Dbo.CoberturaSiniestrada SET NumeroSiniestro=@NumeroSiniestro, RutReclamante=@RutReclamante, Cobertura=@Cobertura, MontoLiquidado=@MontoLiquidado, MonedaLiquidacion=@MonedaLiquidacion, FechaInformeLiquidador=@FechaInformeLiquidador WHERE ";
                int i = db.Execute(query, coberturaSiniestradaModel);
                result = i >= 0;
            }
            return result;
        }
        /// <summary>
        /// Elimina un elemento desde el medio de persistencia
        /// </summary>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool EliminarCoberturaSiniestrada()
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"DELETE FROM Dbo.CoberturaSiniestrada WHERE ";
                int i = db.Execute(query, new { });
                result = i >= 1;
            }
            return result;
        }
    }
}

