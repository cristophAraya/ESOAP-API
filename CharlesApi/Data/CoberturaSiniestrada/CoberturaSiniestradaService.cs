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
using CharlesApi.Entities.CoberturaSiniestrada;
using CharlesApi.Helpers.Base;
using CharlesApi.Repository.CoberturaSiniestrada;
using CharlesApi.Request.CoberturaSiniestrada;
using CharlesApi.Result.CoberturaSiniestrada;

namespace CharlesApi.Data.CoberturaSiniestrada
{
	/// <summary>
	/// Esta Clase CoberturaSiniestrada  permite gestionar reglas de negocio asociados a la entidad CoberturaSiniestrada
	/// </summary>
	public partial class CoberturaSiniestradaService : ICoberturaSiniestradaService
	{	
        private ISettingsConfig settings;
        private ICoberturaSiniestradaRepository coberturaSiniestradaRepository;
        private IMapper mapper;
        public CoberturaSiniestradaService(ICoberturaSiniestradaRepository coberturaSiniestradaRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.coberturaSiniestradaRepository = coberturaSiniestradaRepository;
            this.mapper = mapper;
            this.settings = settings;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto CoberturaSiniestradaResult con información del resultado de la operación</returns>
		public ListadoCoberturaSiniestradaResult ObtenerCoberturaSiniestradas()
		{
			ListadoCoberturaSiniestradaResult listadoCoberturaSiniestradaResult = new ListadoCoberturaSiniestradaResult();
            listadoCoberturaSiniestradaResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var coberturaSiniestradas = coberturaSiniestradaRepository.ObtenerCoberturaSiniestradas();
                listadoCoberturaSiniestradaResult.CoberturaSiniestradas = new List<CoberturaSiniestradaResult>();

                if (coberturaSiniestradas != null)
                {
                    listadoCoberturaSiniestradaResult.CoberturaSiniestradas = mapper.Map<IList<CoberturaSiniestradaResult>>(coberturaSiniestradas);
                    listadoCoberturaSiniestradaResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoCoberturaSiniestradaResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto CoberturaSiniestradaResult con información del resultado de la operación</returns>
		public ListadoCoberturaSiniestradaResult BuscarCoberturaSiniestradas()
		{
			ListadoCoberturaSiniestradaResult listadoCoberturaSiniestradaResult = new ListadoCoberturaSiniestradaResult();
            listadoCoberturaSiniestradaResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var coberturaSiniestradas = coberturaSiniestradaRepository.BuscarCoberturaSiniestradas(new CoberturaSiniestradaModel());
                listadoCoberturaSiniestradaResult.CoberturaSiniestradas = new List<CoberturaSiniestradaResult>();

                if (coberturaSiniestradas != null)
                {
                    listadoCoberturaSiniestradaResult.CoberturaSiniestradas = mapper.Map<IList<CoberturaSiniestradaResult>>(coberturaSiniestradas);
                    listadoCoberturaSiniestradaResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoCoberturaSiniestradaResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto CoberturaSiniestradaResult con información del resultado de la operación</returns>
		public CoberturaSiniestradaResult ObtenerCoberturaSiniestrada(CoberturaSiniestradaRequest coberturaSiniestradaRequest)
        {
			CoberturaSiniestradaResult coberturaSiniestradaResult = new CoberturaSiniestradaResult();
            coberturaSiniestradaResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
                var coberturaSiniestrada = mapper.Map<CoberturaSiniestradaModel>(coberturaSiniestradaRequest);
                coberturaSiniestrada = coberturaSiniestradaRepository.ObtenerCoberturaSiniestrada(coberturaSiniestrada);
                if (coberturaSiniestrada!=null)
                {
                    coberturaSiniestradaResult = mapper.Map<CoberturaSiniestradaResult>(coberturaSiniestrada);
                    coberturaSiniestradaResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return coberturaSiniestradaResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="coberturaSiniestradaModel"></param>
		/// <returns>Objeto CoberturaSiniestradaResult con información del resultado de la operación</returns>
		public CoberturaSiniestradaResult CrearCoberturaSiniestrada(CoberturaSiniestradaRequest coberturaSiniestradaRequest)
		{
			CoberturaSiniestradaResult coberturaSiniestradaResult = new CoberturaSiniestradaResult();
            coberturaSiniestradaResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
				var coberturaSiniestrada = mapper.Map<CoberturaSiniestradaModel>(coberturaSiniestradaRequest);
                coberturaSiniestrada = coberturaSiniestradaRepository.CrearCoberturaSiniestrada(coberturaSiniestrada);
                if (coberturaSiniestrada != null)
                {
                    coberturaSiniestradaResult = mapper.Map<CoberturaSiniestradaResult>(coberturaSiniestrada);
                    coberturaSiniestradaResult.StatusCode = StatusCodes.Status201Created;
                }
			}
			catch (Exception e)
            {
                throw e;
            }
            return coberturaSiniestradaResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="coberturaSiniestradaModel"></param>
		/// <returns>Objeto CoberturaSiniestradaResult con información del resultado de la operación</returns>
		public CoberturaSiniestradaResult ActualizarCoberturaSiniestrada(CoberturaSiniestradaRequest coberturaSiniestradaRequest)
		{
			CoberturaSiniestradaResult coberturaSiniestradaResult = new CoberturaSiniestradaResult();
            coberturaSiniestradaResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var coberturaSiniestrada = mapper.Map<CoberturaSiniestradaModel>(coberturaSiniestradaRequest);
                var result = coberturaSiniestradaRepository.ActualizarCoberturaSiniestrada(coberturaSiniestrada);
                if (result)
                {
                    coberturaSiniestradaResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return coberturaSiniestradaResult;
		}
		
		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="coberturaSiniestradaModel"></param>
		/// <returns>Objeto CoberturaSiniestradaResult con información del resultado de la operación</returns>
		public CoberturaSiniestradaResult EliminarCoberturaSiniestrada()
        {
			CoberturaSiniestradaResult coberturaSiniestradaResult = new CoberturaSiniestradaResult();
            coberturaSiniestradaResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var result = coberturaSiniestradaRepository.EliminarCoberturaSiniestrada();
                if (result)
                {
                    coberturaSiniestradaResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return coberturaSiniestradaResult;
        }
	}
}

