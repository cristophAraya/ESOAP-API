






/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*24-05-2023,Generador de Código, Clase Inicial 
*/


using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CharlesApi.Entities.Participante;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.Participante
{
    /// <summary>
    /// Esta Clase Participante  permite gestionar la interacción con la base de datos para la tabla Participante
    /// </summary>
    public partial class ParticipanteRepository : DBBaseHelper, IParticipanteRepository
    {

        public ParticipanteRepository(ISettingsConfig settings) : base(settings)
        {
            this.settingsConfig = settings;
        }

        /// <summary>
        /// Consulta todos los elementos existentes
        /// </summary>
        /// <returns>Una lista de objetos</returns>
        public IList<ParticipanteModel> ObtenerParticipantes()
        {
            IList<ParticipanteModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro, NumeroInforme, Rut, PrimerNombre, SegundoNombre, Apellidos, FechaNacimiento, Genero, Pais, Ciudad, Region, Comuna, Calle, CasaDepto, Numeracion  FROM Dbo.Participante";
                result = db.Query<ParticipanteModel>(query).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta una colección de elementos según parámetros de busqueda
        /// </summary>
        /// <returns>Una lista de objetos para la busqueda especificada</returns>
        public IList<ParticipanteModel> BuscarParticipantes()
        {
            IList<ParticipanteModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro, NumeroInforme, Rut, PrimerNombre, SegundoNombre, Apellidos, FechaNacimiento, Genero, Pais, Ciudad, Region, Comuna, Calle, CasaDepto, Numeracion  FROM Dbo.Participante WHERE  ";
                result = db.Query<ParticipanteModel>(query, new { }).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
        public ParticipanteModel ObtenerParticipante(ParticipanteModel participanteModel)
        {
            ParticipanteModel result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro, NumeroInforme, Rut, PrimerNombre, SegundoNombre, Apellidos, FechaNacimiento, Genero, Pais, Ciudad, Region, Comuna, Calle, CasaDepto, Numeracion, NumeroSolicitud  FROM Dbo.Participante WHERE NumeroSiniestro = @NumeroSiniestro AND NumeroInforme = @NumeroInforme AND Rut = @Rut ";
                result = db.QueryFirstOrDefault<ParticipanteModel>(query, participanteModel);
            }
            return result;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="participanteModel"></param>
        /// <returns>El mismo objeto de entrada, modifica si es necesario</returns>
        public ParticipanteModel CrearParticipante(ParticipanteModel participanteModel)
        {
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"INSERT INTO Dbo.Participante  (NumeroSiniestro, NumeroInforme, Rut, PrimerNombre, SegundoNombre, Apellidos, FechaNacimiento, Genero, Pais, Ciudad, Region, Comuna, Calle, CasaDepto, Numeracion,NumeroSolicitud) VALUES (@NumeroSiniestro, @NumeroInforme, @Rut, @PrimerNombre, @SegundoNombre, @Apellidos, @FechaNacimiento, @Genero, @Pais, @Ciudad, @Region, @Comuna, @Calle, @CasaDepto, @Numeracion,@NumeroSolicitud)";
                db.Execute(query, participanteModel);
            }
            return participanteModel;
        }

        /// <summary>
        /// Actualiza un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="participanteModel"></param>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool ActualizarParticipante(ParticipanteModel participanteModel)
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"UPDATE Dbo.Participante SET NumeroSiniestro=@NumeroSiniestro, NumeroInforme=@NumeroInforme, Rut=@Rut, PrimerNombre=@PrimerNombre, SegundoNombre=@SegundoNombre, Apellidos=@Apellidos, FechaNacimiento=@FechaNacimiento, Genero=@Genero, Pais=@Pais, Ciudad=@Ciudad, Region=@Region, Comuna=@Comuna, Calle=@Calle, CasaDepto=@CasaDepto, Numeracion=@Numeracion WHERE ";
                int i = db.Execute(query, participanteModel);
                result = i >= 0;
            }
            return result;
        }

        public IList<ParticipanteModel> ObtenerParticipante()
        {
            throw new NotImplementedException();
        }
    }
}

