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
using CharlesApi.Entities.Siniestro;
using CharlesApi.Helpers.Base;
using CharlesApi.Repository.Siniestro;
using CharlesApi.Repository.SiniestroLog;
using CharlesApi.Request.Siniestro;
using CharlesApi.Result.Siniestro;

namespace CharlesApi.Data.Siniestro
{
    /// <summary>
    /// Esta Clase Siniestro  permite gestionar reglas de negocio asociados a la entidad Siniestro
    /// </summary>
    public partial class SiniestroService : ISiniestroService
    {
        private ISettingsConfig settings;
        private ISiniestroRepository siniestroRepository;
        private IMapper mapper;
        public SiniestroService(ISiniestroRepository siniestroRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.siniestroRepository = siniestroRepository;
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
        /// <returns>Objeto SiniestroResult con información del resultado de la operación</returns>
        public ListadoSiniestroResult ObtenerSiniestros()
        {
            ListadoSiniestroResult listadoSiniestroResult = new ListadoSiniestroResult();
            listadoSiniestroResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var siniestros = siniestroRepository.ObtenerSiniestros();
                listadoSiniestroResult.Siniestros = new List<SiniestroResult>();

                if (siniestros != null)
                {
                    listadoSiniestroResult.Siniestros = mapper.Map<IList<SiniestroResult>>(siniestros);
                    listadoSiniestroResult.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listadoSiniestroResult;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <returns>Objeto SiniestroResult con información del resultado de la operación</returns>
        public ListadoSiniestroResult BuscarSiniestros()
        {
            ListadoSiniestroResult listadoSiniestroResult = new ListadoSiniestroResult();
            listadoSiniestroResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var siniestros = siniestroRepository.BuscarSiniestros();
                listadoSiniestroResult.Siniestros = new List<SiniestroResult>();

                if (siniestros != null)
                {
                    listadoSiniestroResult.Siniestros = mapper.Map<IList<SiniestroResult>>(siniestros);
                    listadoSiniestroResult.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listadoSiniestroResult;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <returns>Objeto SiniestroResult con información del resultado de la operación</returns>
        public SiniestroResult ObtenerSiniestro()
        {
            SiniestroResult siniestroResult = new SiniestroResult();
            siniestroResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
                var siniestro = siniestroRepository.ObtenerSiniestro(new SiniestroModel());
                if (siniestro != null)
                {
                    siniestroResult = mapper.Map<SiniestroResult>(siniestro);
                    siniestroResult.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return siniestroResult;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="siniestroModel"></param>
        /// <returns>Objeto SiniestroResult con información del resultado de la operación</returns>
        public SiniestroResult CrearSiniestro(SiniestroRequest siniestroRequest)
        {
            SiniestroResult siniestroResult = new SiniestroResult();
            siniestroResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
                var siniestro = mapper.Map<SiniestroModel>(siniestroRequest);
                siniestro = siniestroRepository.CrearSiniestro(siniestro);
                if (siniestro != null)
                {
                    siniestroResult = mapper.Map<SiniestroResult>(siniestro);
                    siniestroResult.StatusCode = StatusCodes.Status201Created;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return siniestroResult;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="siniestroModel"></param>
        /// <returns>Objeto SiniestroResult con información del resultado de la operación</returns>
        public SiniestroResult ActualizarSiniestro(SiniestroRequest siniestroRequest)
        {
            SiniestroResult siniestroResult = new SiniestroResult();
            siniestroResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
                var siniestro = mapper.Map<SiniestroModel>(siniestroRequest);
                var result = siniestroRepository.ActualizarSiniestro(siniestro);
                if (result)
                {
                    siniestroResult.StatusCode = StatusCodes.Status204NoContent;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return siniestroResult;
        }

        /// <summary>
        /// Agrega un elemento desde el medio de persistencia
        /// </summary>
        /// <param name="siniestroModel"></param>
        /// <returns>Objeto SiniestroResult con información del resultado de la operación</returns>
        public SiniestroResult EliminarSiniestro()
        {
            SiniestroResult siniestroResult = new SiniestroResult();
            siniestroResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
                var result = siniestroRepository.EliminarSiniestro();
                if (result)
                {
                    siniestroResult.StatusCode = StatusCodes.Status204NoContent;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return siniestroResult;
        }
    }
}

