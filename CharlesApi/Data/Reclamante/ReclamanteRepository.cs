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
using CharlesApi.Entities.Reclamante;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.Reclamante
{
	/// <summary>
	/// Esta Clase Reclamante  permite gestionar la interacción con la base de datos para la tabla Reclamante
	/// </summary>
	public partial class ReclamanteRepository : DBBaseHelper, IReclamanteRepository
	{	

			public ReclamanteRepository(ISettingsConfig settings) : base(settings)
			{
				this.settingsConfig = settings;
			}

		/// <summary>
		/// Consulta todos los elementos existentes
		/// </summary>
		/// <returns>Una lista de objetos</returns>
		public IList<ReclamanteModel> ObtenerReclamantes( )
		{
			IList<ReclamanteModel> result = null;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
				string query = @"Select NumeroSiniestro,NumeroInforme, MontoProvision, MonedaProvision, Cobertura, Rut, PrimerNombre, SegundoNombre, Apellidos, FechaNacimiento, Genero, Pais, Ciudad, Region, Comuna, Calle, CasaDepto, Numeracion, TipoContacto, FormaContacto, IdPersona, NumeroSolicitud  FROM Dbo.Reclamante";
				result = db.Query<ReclamanteModel>(query).AsList();
			}
			return result;       
		}
		/// <summary>
		/// Consulta una colección de elementos según parámetros de busqueda
		/// </summary>
		/// <returns>Una lista de objetos para la busqueda especificada</returns>
		public IList<ReclamanteModel> BuscarReclamantes(ReclamanteModel reclamanteModel)
		{
			IList<ReclamanteModel> result = null;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro,NumeroInforme, MontoProvision, MonedaProvision, Cobertura, Rut, PrimerNombre, SegundoNombre, Apellidos, 
                                FechaNacimiento, Genero, Pais, Ciudad, Region, Comuna, Calle, CasaDepto, Numeracion, TipoContacto, FormaContacto, 
                                IdPersona, NumeroSolicitud ,TipoReclamante,CodigoTipoReclamante
                                FROM Dbo.Reclamante WHERE  
                                NumeroInforme = @NumeroInforme 
                                AND NumeroSiniestro = @NumeroSiniestro ";
                    //and Rut=@Rut and NumeroInforme=@NumeroInforme";
				result = db.Query<ReclamanteModel>(query, 
                    new {
                            NumeroInforme = reclamanteModel.NumeroInforme,
                            NumeroSiniestro = reclamanteModel.NumeroSiniestro
                            //Rut = reclamanteModel.Rut 
                    }).AsList();
			}
			return result;       
		}
		/// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
		public ReclamanteModel ObtenerReclamante(ReclamanteModel reclamanteModel)
		{
			ReclamanteModel result = null;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
				string query = @"Select NumeroSiniestro,NumeroInforme, MontoProvision, MonedaProvision, Cobertura, Rut, PrimerNombre, SegundoNombre, Apellidos, FechaNacimiento,
                                Genero, Pais, Ciudad, Region, Comuna, Calle, CasaDepto, Numeracion, TipoContacto, FormaContacto, IdPersona, NumeroSolicitud  ,TipoReclamante,CodigoTipoReclamante
                                FROM Dbo.Reclamante 
                                WHERE NumeroInforme= @NumeroInforme AND NumeroSiniestro = @NumeroSiniestro and  Cobertura = @Cobertura and Rut = @Rut";
				result = db.QueryFirstOrDefault<ReclamanteModel>(query, new { NumeroInforme = reclamanteModel.NumeroInforme, NumeroSiniestro = reclamanteModel.NumeroSiniestro, Cobertura = reclamanteModel.Cobertura , Rut  = reclamanteModel.Rut});
			}
			return result;                        
		}

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="reclamanteModel"></param>
        /// <returns>El mismo objeto de entrada, modifica si es necesario</returns>
        public ReclamanteModel CrearReclamante(ReclamanteModel reclamanteModel)
        {
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"INSERT INTO Dbo.Reclamante  (NumeroSiniestro, NumeroInforme,MontoProvision, MonedaProvision, Cobertura, Rut, PrimerNombre, SegundoNombre, Apellidos, FechaNacimiento, Genero, Pais, Ciudad, Region, Comuna, Calle, CasaDepto, Numeracion, TipoContacto, FormaContacto, IdPersona, NumeroSolicitud,TipoReclamante,CodigoTipoReclamante) VALUES (@NumeroSiniestro,@NumeroInforme, @MontoProvision, @MonedaProvision, @Cobertura, @Rut, @PrimerNombre, @SegundoNombre, @Apellidos, @FechaNacimiento, @Genero, @Pais, @Ciudad, @Region, @Comuna, @Calle, @CasaDepto, @Numeracion, @TipoContacto, @FormaContacto, @IdPersona, @NumeroSolicitud,@TipoReclamante,@CodigoTipoReclamante)";
                db.Execute(query, reclamanteModel);
            }
            return reclamanteModel;
        }

		/// <summary>
		/// Actualiza un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="reclamanteModel"></param>
		/// <returns>booleano indicando si la operación fue exitosa o no</returns>
		public bool ActualizarReclamante(ReclamanteModel reclamanteModel)
		{
			bool result = false;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
				string query = @"UPDATE Dbo.Reclamante SET IdPersona=@IdPersona, NumeroSolicitud=@NumeroSolicitud
                                WHERE NumeroSiniestro = @NumeroSiniestro and NumeroInforme = @NumeroInforme AND Cobertura = @Cobertura AND Rut = @Rut AND IdPersona = ''";
				int i = db.Execute(query, reclamanteModel);
                result = i >= 0;
			}
			return result;
		}
		/// <summary>
		/// Elimina un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>booleano indicando si la operación fue exitosa o no</returns>
		public bool EliminarReclamante()
		{
			bool result = false;
			using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
				string query = @"DELETE FROM Dbo.Reclamante WHERE ";
                int i = db.Execute(query, new {  });
				result = i >= 1;
			}
			return result;
		}
	}
}

