






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
using CharlesApi.Entities.Beneficiario;
using CharlesApi.Helpers.Base;
//using CharlesApi.Helpers.Base;

namespace CharlesApi.Repository.Beneficiario
{
    /// <summary>
    /// Esta Clase Beneficiario  permite gestionar la interacción con la base de datos para la tabla Beneficiario
    /// </summary>
    public partial class BeneficiarioRepository : DBBaseHelper, IBeneficiarioRepository
    {

        public BeneficiarioRepository(ISettingsConfig settings) : base(settings)
        {
            this.settingsConfig = settings;
        }

        /// <summary>
        /// Consulta todos los elementos existentes
        /// </summary>
        /// <returns>Una lista de objetos</returns>
        public IList<BeneficiarioModel> ObtenerBeneficiarios()
        {
            IList<BeneficiarioModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro,NumeroInforme, RutReclamante, Cobertura, Porcentaje, FechaNacimiento, Rut, PrimerNombre, SegundoNombre, Apellidos, Genero, Pais, Region, Comuna, Calle, CasaDepto, Numeracion, TipoContacto, FormaContacto, DocladId, DocladNo, DocladState,Moneda,NumeroCuenta,Banco  FROM Dbo.Beneficiario";
                result = db.Query<BeneficiarioModel>(query).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta una colección de elementos según parámetros de busqueda
        /// </summary>
        /// <returns>Una lista de objetos para la busqueda especificada</returns>
        public IList<BeneficiarioModel> BuscarBeneficiarios(BeneficiarioModel beneficiarioModel)
        {
            IList<BeneficiarioModel> result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro,NumeroInforme, RutReclamante, Cobertura, Porcentaje, FechaNacimiento, Rut, PrimerNombre, SegundoNombre, Apellidos, Genero, Pais, Region, 
                                Comuna, Calle, CasaDepto, Numeracion, TipoContacto, FormaContacto, DocladId, DocladNo, DocladState  ,Moneda,NumeroCuenta,Banco
                                FROM Dbo.Beneficiario WHERE NumeroInforme = @NumeroInforme 
                                AND NumeroSiniestro = @NumeroSiniestro ";
                //and RutReclamante=@RutReclamante and Cobertura = @Cobertura";
                result = db.Query<BeneficiarioModel>(query,
                            new
                            {
                                NumeroSiniestro = beneficiarioModel.NumeroSiniestro,
                                NumeroInforme = beneficiarioModel.NumeroInforme//,
                                                                               // RutReclamante = beneficiarioModel.RutReclamante,
                                                                               // Cobertura = beneficiarioModel.Cobertura
                            }).AsList();
            }
            return result;
        }
        /// <summary>
        /// Consulta un único elemento según clave especificada
        /// </summary>
        /// <returns>Un objeto de persistencia para la clave especificada</returns>
        public BeneficiarioModel ObtenerBeneficiario(BeneficiarioModel beneficiarioModel)
        {
            BeneficiarioModel result = null;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"Select NumeroSiniestro, NumeroInforme,RutReclamante, Cobertura, Porcentaje, FechaNacimiento, Rut, PrimerNombre, SegundoNombre, Apellidos, Genero, Pais, Region, Comuna, 
                                Calle, CasaDepto, Numeracion, TipoContacto, FormaContacto, DocladId, DocladNo, DocladState  ,Moneda,NumeroCuenta,Banco
                                FROM Dbo.Beneficiario WHERE  NumeroSiniestro = @NumeroSiniestro and  NumeroInforme = @NumeroInforme and RutReclamante = @RutReclamante and Rut = @Rut";
                result = db.QueryFirstOrDefault<BeneficiarioModel>(query, new { NumeroSiniestro = beneficiarioModel.NumeroSiniestro, NumeroInforme = beneficiarioModel.NumeroInforme, RutReclamante = beneficiarioModel.RutReclamante, Rut = beneficiarioModel.Rut });
            }
            return result;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="beneficiarioModel"></param>
        /// <returns>El mismo objeto de entrada, modifica si es necesario</returns>
        public BeneficiarioModel CrearBeneficiario(BeneficiarioModel beneficiarioModel)
        {
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"INSERT INTO Dbo.Beneficiario  (NumeroSiniestro, NumeroInforme,RutReclamante,RutParticipante, Cobertura, Porcentaje, FechaNacimiento, Rut, PrimerNombre, SegundoNombre, Apellidos, Genero, Pais, Region, Comuna, Calle, CasaDepto, Numeracion, TipoContacto, FormaContacto, DocladId, DocladNo, DocladState,Ciudad,Moneda,NumeroCuenta,Banco,NumeroSolicitud) VALUES (@NumeroSiniestro,@NumeroInforme, @RutReclamante, @RutParticipante, @Cobertura, @Porcentaje, @FechaNacimiento, @Rut, @PrimerNombre, @SegundoNombre, @Apellidos, @Genero, @Pais, @Region, @Comuna, @Calle, @CasaDepto, @Numeracion, @TipoContacto, @FormaContacto, @DocladId, @DocladNo, @DocladState,@Ciudad,@Moneda,@NumeroCuenta,@Banco,@NumeroSolicitud)";
                db.Execute(query, beneficiarioModel);
            }
            return beneficiarioModel;
        }

        /// <summary>
        /// Actualiza un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="beneficiarioModel"></param>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool ActualizarBeneficiario(BeneficiarioModel beneficiarioModel)
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"UPDATE Dbo.Beneficiario SET DocladId=@DocladId, DocladNo=@DocladNo, DocladState=@DocladState 
                                WHERE NumeroSiniestro=@NumeroSiniestro AND  NumeroInforme= @NumeroInforme AND RutReclamante = @RutReclamante AND Cobertura = @Cobertura AND Rut=@Rut";
                int i = db.Execute(query, beneficiarioModel);
                result = i >= 0;
            }
            return result;
        }
        /// <summary>
        /// Elimina un elemento desde el medio de persistencia
        /// </summary>
        /// <returns>booleano indicando si la operación fue exitosa o no</returns>
        public bool EliminarBeneficiario()
        {
            bool result = false;
            using (IDbConnection db = new SqlConnection(GetDatabase()))
            {
                string query = @"DELETE FROM Dbo.Beneficiario WHERE ";
                int i = db.Execute(query, new { });
                result = i >= 1;
            }
            return result;
        }
    }
}

