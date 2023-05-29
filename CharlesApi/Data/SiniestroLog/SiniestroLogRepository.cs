






/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*29-03-2023,Generador de Código, Clase Inicial 
*/

using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CharlesApi.Entities.SiniestroLog;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.SiniestroLog
{
    /// <summary>
    /// Esta Clase SiniestroLog  permite gestionar la interacción con la base de datos para la tabla SiniestroLog
    /// </summary>
    public partial class SiniestroLogRepository : DBBaseHelper, ISiniestroLogRepository
    {

        public SiniestroLogRepository(ISettingsConfig settings) : base(settings)
        {
            this.settingsConfig = settings;
        }

        /// <summary>
        /// Consulta todos los elementos existentes
        /// </summary>
        /// <returns>Una lista de objetos</returns>
        public IList<SiniestroLogModel> ObtenerSiniestroLogs()
        {
            IList<SiniestroLogModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro, NumeroInforme, Status, Fecha  FROM Dbo.SiniestroLog";
                result = db.Query<SiniestroLogModel>(query).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta una colección de elementos según parámetros de busqueda
        /// </summary>
        /// <returns>Una lista de objetos para la busqueda especificada</returns>
        public IList<SiniestroLogModel> BuscarSiniestroLogs()
        {
            IList<SiniestroLogModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro, NumeroInforme, Status, Fecha  FROM Dbo.SiniestroLog WHERE  ";
                result = db.Query<SiniestroLogModel>(query, new { }).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
        public SiniestroLogModel ObtenerSiniestroLog()
        {
            SiniestroLogModel result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro, NumeroInforme, Status, Fecha  FROM Dbo.SiniestroLog WHERE  ";
                result = db.QueryFirstOrDefault<SiniestroLogModel>(query, new { });
            }
            return result;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="SiniestroLogModel"></param>
        /// <returns>El mismo objeto de entrada, modifica si es necesario</returns>
        public SiniestroLogModel CrearSiniestroLog(SiniestroLogModel SiniestroLogModel)
        {
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"INSERT INTO Dbo.SiniestroLog  (NumeroPoliza,NumeroSiniestro, NumeroInforme, Status, Fecha,MensajeError) VALUES (@NumeroPoliza,@NumeroSiniestro, @NumeroInforme, @Status, @Fecha,@MensajeError)";
                db.Execute(query, SiniestroLogModel);
            }
            return SiniestroLogModel;
        }

        /// <summary>
        /// Actualiza un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="SiniestroLogModel"></param>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool ActualizarSiniestroLog(SiniestroLogModel SiniestroLogModel)
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"UPDATE Dbo.SiniestroLog SET NumeroSiniestro=@NumeroSiniestro, NumeroInforme=@NumeroInforme, Status=@Status, Fecha=@Fecha WHERE ";
                int i = db.Execute(query, SiniestroLogModel);
                result = i >= 0;
            }
            return result;
        }
        /// <summary>
        /// Elimina un elemento desde el medio de persistencia
        /// </summary>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool EliminarSiniestroLog()
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"DELETE FROM Dbo.SiniestroLog WHERE ";
                int i = db.Execute(query, new { });
                result = i >= 1;
            }
            return result;
        }
    }
}

