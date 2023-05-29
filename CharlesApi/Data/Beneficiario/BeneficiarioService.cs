






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



//using CharlesApi.Data.Base;
using AutoMapper;
using CharlesApi.Entities.Beneficiario;
using CharlesApi.Helpers.Base;
using CharlesApi.Repository.Beneficiario;
using CharlesApi.Request.Beneficiario;
using CharlesApi.Result.Beneficiario;

namespace CharlesApi.Data.Beneficiario
{
	/// <summary>
	/// Esta Clase Beneficiario  permite gestionar reglas de negocio asociados a la entidad Beneficiario
	/// </summary>
	public partial class BeneficiarioService : IBeneficiarioService
	{	
        private ISettingsConfig settings;
        private IBeneficiarioRepository beneficiarioRepository;
        private IMapper mapper;
        public BeneficiarioService(IBeneficiarioRepository beneficiarioRepository, IMapper mapper)
        {
            this.beneficiarioRepository = beneficiarioRepository;
            this.mapper = mapper;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto BeneficiarioResult con información del resultado de la operación</returns>
		public ListadoBeneficiarioResult ObtenerBeneficiarios()
		{
			ListadoBeneficiarioResult listadoBeneficiarioResult = new ListadoBeneficiarioResult();
            listadoBeneficiarioResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var beneficiarios = beneficiarioRepository.ObtenerBeneficiarios();
                listadoBeneficiarioResult.Beneficiarios = new List<BeneficiarioResult>();

                if (beneficiarios != null)
                {
                    listadoBeneficiarioResult.Beneficiarios = mapper.Map<IList<BeneficiarioResult>>(beneficiarios);
                    listadoBeneficiarioResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoBeneficiarioResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto BeneficiarioResult con información del resultado de la operación</returns>
		public ListadoBeneficiarioResult BuscarBeneficiarios()
		{
			ListadoBeneficiarioResult listadoBeneficiarioResult = new ListadoBeneficiarioResult();
            listadoBeneficiarioResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var beneficiarios = beneficiarioRepository.BuscarBeneficiarios(new BeneficiarioModel());
                listadoBeneficiarioResult.Beneficiarios = new List<BeneficiarioResult>();

                if (beneficiarios != null)
                {
                    listadoBeneficiarioResult.Beneficiarios = mapper.Map<IList<BeneficiarioResult>>(beneficiarios);
                    listadoBeneficiarioResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoBeneficiarioResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto BeneficiarioResult con información del resultado de la operación</returns>
		public BeneficiarioResult ObtenerBeneficiario()
        {
			BeneficiarioResult beneficiarioResult = new BeneficiarioResult();
            beneficiarioResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var beneficiario = beneficiarioRepository.ObtenerBeneficiario( new BeneficiarioModel());
                if (beneficiario!=null)
                {
                    beneficiarioResult = mapper.Map<BeneficiarioResult>(beneficiario);
                    beneficiarioResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return beneficiarioResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="beneficiarioModel"></param>
		/// <returns>Objeto BeneficiarioResult con información del resultado de la operación</returns>
		public BeneficiarioResult CrearBeneficiario(BeneficiarioRequest beneficiarioRequest)
		{
			BeneficiarioResult beneficiarioResult = new BeneficiarioResult();
            beneficiarioResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
				var beneficiario = mapper.Map<BeneficiarioModel>(beneficiarioRequest);
                beneficiario = beneficiarioRepository.CrearBeneficiario(beneficiario);
                if (beneficiario != null)
                {
                    beneficiarioResult = mapper.Map<BeneficiarioResult>(beneficiario);
                    beneficiarioResult.StatusCode = StatusCodes.Status201Created;
                }
			}
			catch (Exception e)
            {
                throw e;
            }
            return beneficiarioResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="beneficiarioModel"></param>
		/// <returns>Objeto BeneficiarioResult con información del resultado de la operación</returns>
		public BeneficiarioResult ActualizarBeneficiario(BeneficiarioRequest beneficiarioRequest)
		{
			BeneficiarioResult beneficiarioResult = new BeneficiarioResult();
            beneficiarioResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var beneficiario = mapper.Map<BeneficiarioModel>(beneficiarioRequest);
                var result = beneficiarioRepository.ActualizarBeneficiario(beneficiario);
                if (result)
                {
                    beneficiarioResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return beneficiarioResult;
		}
		
		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="beneficiarioModel"></param>
		/// <returns>Objeto BeneficiarioResult con información del resultado de la operación</returns>
		public BeneficiarioResult EliminarBeneficiario()
        {
			BeneficiarioResult beneficiarioResult = new BeneficiarioResult();
            beneficiarioResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var result = beneficiarioRepository.EliminarBeneficiario();
                if (result)
                {
                    beneficiarioResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return beneficiarioResult;
        }
	}
}

