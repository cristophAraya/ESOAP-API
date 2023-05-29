






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



//using CharlesApi.Data.Base;

using AutoMapper;
using CharlesApi.Entities.SiniestroLog;
using CharlesApi.Helpers.Base;
using CharlesApi.Repository.SiniestroLog;
using CharlesApi.Request.SiniestroLog;
using CharlesApi.Result.SiniestroLog;

namespace CharlesApi.Data.SiniestroLog
{
	/// <summary>
	/// Esta Clase SiniestroLog  permite gestionar reglas de negocio asociados a la entidad SiniestroLog
	/// </summary>
	public partial class SiniestroLogService : ISiniestroLogService
	{	
        private ISettingsConfig settings;
        private ISiniestroLogRepository SiniestroLogRepository;
        private IMapper mapper;
        public SiniestroLogService(ISiniestroLogRepository SiniestroLogRepository, IMapper mapper)
        {
            this.SiniestroLogRepository = SiniestroLogRepository;
            this.mapper = mapper;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto SiniestroLogResult con información del resultado de la operación</returns>
		public ListadoSiniestroLogResult ObtenerSiniestroLogs()
		{
			ListadoSiniestroLogResult listadoSiniestroLogResult = new ListadoSiniestroLogResult();
            listadoSiniestroLogResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var SiniestroLogs = SiniestroLogRepository.ObtenerSiniestroLogs();
                listadoSiniestroLogResult.SiniestroLogs = new List<SiniestroLogResult>();

                if (SiniestroLogs != null)
                {
                    listadoSiniestroLogResult.SiniestroLogs = mapper.Map<IList<SiniestroLogResult>>(SiniestroLogs);
                    listadoSiniestroLogResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoSiniestroLogResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto SiniestroLogResult con información del resultado de la operación</returns>
		public ListadoSiniestroLogResult BuscarSiniestroLogs()
		{
			ListadoSiniestroLogResult listadoSiniestroLogResult = new ListadoSiniestroLogResult();
            listadoSiniestroLogResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var SiniestroLogs = SiniestroLogRepository.BuscarSiniestroLogs();
                listadoSiniestroLogResult.SiniestroLogs = new List<SiniestroLogResult>();

                if (SiniestroLogs != null)
                {
                    listadoSiniestroLogResult.SiniestroLogs = mapper.Map<IList<SiniestroLogResult>>(SiniestroLogs);
                    listadoSiniestroLogResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoSiniestroLogResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto SiniestroLogResult con información del resultado de la operación</returns>
		public SiniestroLogResult ObtenerSiniestroLog()
        {
			SiniestroLogResult SiniestroLogResult = new SiniestroLogResult();
            SiniestroLogResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var SiniestroLog = SiniestroLogRepository.ObtenerSiniestroLog();
                if (SiniestroLog!=null)
                {
                    SiniestroLogResult = mapper.Map<SiniestroLogResult>(SiniestroLog);
                    SiniestroLogResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return SiniestroLogResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="SiniestroLogModel"></param>
		/// <returns>Objeto SiniestroLogResult con información del resultado de la operación</returns>
		public SiniestroLogResult CrearSiniestroLog(SiniestroLogRequest SiniestroLogRequest)
		{
			SiniestroLogResult SiniestroLogResult = new SiniestroLogResult();
            SiniestroLogResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
				var SiniestroLog = mapper.Map<SiniestroLogModel>(SiniestroLogRequest);
                SiniestroLog = SiniestroLogRepository.CrearSiniestroLog(SiniestroLog);
                if (SiniestroLog != null)
                {
                    SiniestroLogResult = mapper.Map<SiniestroLogResult>(SiniestroLog);
                    SiniestroLogResult.StatusCode = StatusCodes.Status201Created;
                }
			}
			catch (Exception e)
            {
                throw e;
            }
            return SiniestroLogResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="SiniestroLogModel"></param>
		/// <returns>Objeto SiniestroLogResult con información del resultado de la operación</returns>
		public SiniestroLogResult ActualizarSiniestroLog(SiniestroLogRequest SiniestroLogRequest)
		{
			SiniestroLogResult SiniestroLogResult = new SiniestroLogResult();
            SiniestroLogResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var SiniestroLog = mapper.Map<SiniestroLogModel>(SiniestroLogRequest);
                var result = SiniestroLogRepository.ActualizarSiniestroLog(SiniestroLog);
                if (result)
                {
                    SiniestroLogResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return SiniestroLogResult;
		}
		
		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="SiniestroLogModel"></param>
		/// <returns>Objeto SiniestroLogResult con información del resultado de la operación</returns>
		public SiniestroLogResult EliminarSiniestroLog()
        {
			SiniestroLogResult SiniestroLogResult = new SiniestroLogResult();
            SiniestroLogResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var result = SiniestroLogRepository.EliminarSiniestroLog();
                if (result)
                {
                    SiniestroLogResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return SiniestroLogResult;
        }
	}
}

