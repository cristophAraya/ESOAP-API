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
using CharlesApi.Entities.Siniestro;
using CharlesApi.Helpers.Base;
using CharlesApi.Data.Siniestro;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.Siniestro
{
    /// <summary>
    /// Esta Clase Siniestro  permite gestionar la interacción con la base de datos para la tabla Siniestro
    /// </summary>
    public partial class SiniestroRepository : DBBaseHelper, ISiniestroRepository
    {

        public SiniestroRepository(ISettingsConfig settings) : base(settings)
        {
            this.settingsConfig = settings;
        }

        /// <summary>
        /// Consulta todos los elementos existentes
        /// </summary>
        /// <returns>Una lista de objetos</returns>
        public IList<SiniestroModel> ObtenerSiniestros()
        {
            IList<SiniestroModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroPoliza, Patente, RelatoSiniestro, FechaSiniestro, LugarSiniestro, ComentarioSiniestro, NumeroSiniestro,NumeroInforme  FROM Dbo.Siniestro";
                result = db.Query<SiniestroModel>(query).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta una colección de elementos según parámetros de busqueda
        /// </summary>
        /// <returns>Una lista de objetos para la busqueda especificada</returns>
        public IList<SiniestroModel> BuscarSiniestros()
        {
            IList<SiniestroModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroPoliza, Patente, RelatoSiniestro, FechaSiniestro, LugarSiniestro, ComentarioSiniestro, NumeroSiniestro,NumeroInforme  FROM Dbo.Siniestro WHERE  ";
                result = db.Query<SiniestroModel>(query, new { }).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
        public SiniestroModel ObtenerSiniestro(SiniestroModel siniestroModel)
        {
            SiniestroModel result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroPoliza, Patente, RelatoSiniestro, FechaSiniestro, LugarSiniestro, ComentarioSiniestro, NumeroSiniestro,NumeroInforme  
                                FROM Dbo.Siniestro WHERE  NumeroSiniestro = @NumeroSiniestro";
                result = db.QueryFirstOrDefault<SiniestroModel>(query, new { NumeroSiniestro  = siniestroModel .NumeroSiniestro});
            }
            return result;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="siniestroModel"></param>
        /// <returns>El mismo objeto de entrada, modifica si es necesario</returns>
        public SiniestroModel CrearSiniestro(SiniestroModel siniestroModel)
        {
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"INSERT INTO Dbo.Siniestro  (NumeroPoliza, Patente, RelatoSiniestro, FechaSiniestro, LugarSiniestro, ComentarioSiniestro, NumeroSiniestro,NumeroInforme,CodigoTipoEvento,TipoEvento) VALUES (@NumeroPoliza, @Patente, @RelatoSiniestro, @FechaSiniestro, @LugarSiniestro, @ComentarioSiniestro, @NumeroSiniestro,@NumeroInforme,@CodigoTipoEvento,@TipoEvento)";
                db.Execute(query, siniestroModel);
            }
            return siniestroModel;
        }

        /// <summary>
        /// Actualiza un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="siniestroModel"></param>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool ActualizarSiniestro(SiniestroModel siniestroModel)
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"UPDATE Dbo.Siniestro SET NumeroPoliza=@NumeroPoliza, Patente=@Patente, RelatoSiniestro=@RelatoSiniestro, FechaSiniestro=@FechaSiniestro, LugarSiniestro=@LugarSiniestro, ComentarioSiniestro=@ComentarioSiniestro, NumeroSiniestro=@NumeroSiniestro WHERE ";
                int i = db.Execute(query, siniestroModel);
                result = i >= 0;
            }
            return result;
        }
        /// <summary>
        /// Elimina un elemento desde el medio de persistencia
        /// </summary>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool EliminarSiniestro()
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"DELETE FROM Dbo.Siniestro WHERE ";
                int i = db.Execute(query, new { });
                result = i >= 1;
            }
            return result;
        }
    }
}

