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
using CharlesApi.Entities.Reclamante;
using CharlesApi.Helpers.Base;
using CharlesApi.Repository.Reclamante;
using CharlesApi.Request.Reclamante;
using CharlesApi.Result.Reclamante;

namespace CharlesApi.Data.Reclamante
{
	/// <summary>
	/// Esta Clase Reclamante  permite gestionar reglas de negocio asociados a la entidad Reclamante
	/// </summary>
	public partial class ReclamanteService : IReclamanteService
	{	
        private ISettingsConfig settings;
        private IReclamanteRepository reclamanteRepository;
        private IMapper mapper;
        public ReclamanteService(IReclamanteRepository reclamanteRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.reclamanteRepository = reclamanteRepository;
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
		/// <returns>Objeto ReclamanteResult con información del resultado de la operación</returns>
		public ListadoReclamanteResult ObtenerReclamantes()
		{
			ListadoReclamanteResult listadoReclamanteResult = new ListadoReclamanteResult();
            listadoReclamanteResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var reclamantes = reclamanteRepository.ObtenerReclamantes();
                listadoReclamanteResult.Reclamantes = new List<ReclamanteResult>();

                if (reclamantes != null)
                {
                    listadoReclamanteResult.Reclamantes = mapper.Map<IList<ReclamanteResult>>(reclamantes);
                    listadoReclamanteResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoReclamanteResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto ReclamanteResult con información del resultado de la operación</returns>
		public ListadoReclamanteResult BuscarReclamantes()
		{
			ListadoReclamanteResult listadoReclamanteResult = new ListadoReclamanteResult();
            listadoReclamanteResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var reclamantes = reclamanteRepository.BuscarReclamantes( new ReclamanteModel());
                listadoReclamanteResult.Reclamantes = new List<ReclamanteResult>();

                if (reclamantes != null)
                {
                    listadoReclamanteResult.Reclamantes = mapper.Map<IList<ReclamanteResult>>(reclamantes);
                    listadoReclamanteResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoReclamanteResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto ReclamanteResult con información del resultado de la operación</returns>
		public ReclamanteResult ObtenerReclamante(ReclamanteModel reclamanteModel)
        {
			ReclamanteResult reclamanteResult = new ReclamanteResult();
            reclamanteResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var reclamante = reclamanteRepository.ObtenerReclamante(reclamanteModel);
                if (reclamante!=null)
                {
                    reclamanteResult = mapper.Map<ReclamanteResult>(reclamante);
                    reclamanteResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return reclamanteResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="reclamanteModel"></param>
		/// <returns>Objeto ReclamanteResult con información del resultado de la operación</returns>
		public ReclamanteResult CrearReclamante(ReclamanteRequest reclamanteRequest)
		{
			ReclamanteResult reclamanteResult = new ReclamanteResult();
            reclamanteResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
				var reclamante = mapper.Map<ReclamanteModel>(reclamanteRequest);
                reclamante = reclamanteRepository.CrearReclamante(reclamante);
                if (reclamante != null)
                {
                    reclamanteResult = mapper.Map<ReclamanteResult>(reclamante);
                    reclamanteResult.StatusCode = StatusCodes.Status201Created;
                }
			}
			catch (Exception e)
            {
                throw e;
            }
            return reclamanteResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="reclamanteModel"></param>
		/// <returns>Objeto ReclamanteResult con información del resultado de la operación</returns>
		public ReclamanteResult ActualizarReclamante(ReclamanteRequest reclamanteRequest)
		{
			ReclamanteResult reclamanteResult = new ReclamanteResult();
            reclamanteResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var reclamante = mapper.Map<ReclamanteModel>(reclamanteRequest);
                var result = reclamanteRepository.ActualizarReclamante(reclamante);
                if (result)
                {
                    reclamanteResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return reclamanteResult;
		}
		
		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="reclamanteModel"></param>
		/// <returns>Objeto ReclamanteResult con información del resultado de la operación</returns>
		public ReclamanteResult EliminarReclamante()
        {
			ReclamanteResult reclamanteResult = new ReclamanteResult();
            reclamanteResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var result = reclamanteRepository.EliminarReclamante();
                if (result)
                {
                    reclamanteResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return reclamanteResult;
        }
	}
}

