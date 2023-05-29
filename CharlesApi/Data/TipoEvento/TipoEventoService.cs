/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*05-04-2023,Generador de Código, Clase Inicial 
*/



//using CharlesApi.Data.Base;
using AutoMapper;
using CharlesApi.Entities.TipoEvento;
using CharlesApi.Helpers.Base;
using CharlesApi.Repository.TipoEvento;
using CharlesApi.Request.TipoEvento;
using CharlesApi.Result.TipoEvento;

namespace CharlesApi.Data.TipoEvento
{
	/// <summary>
	/// Esta Clase TipoEvento  permite gestionar reglas de negocio asociados a la entidad TipoEvento
	/// </summary>
	public partial class TipoEventoService : ITipoEventoService
	{	
        private ISettingsConfig settings;
        private ITipoEventoRepository tipoEventoRepository;
        private IMapper mapper;
        public TipoEventoService(ITipoEventoRepository tipoEventoRepository, IMapper mapper)
        {
            this.tipoEventoRepository = tipoEventoRepository;
            this.mapper = mapper;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

		public TipoEventoResult ObtenerTipoEvento(TipoEventoRequest tipoEventoRequest)
        {
			TipoEventoResult tipoEventoResult = new TipoEventoResult();
            tipoEventoResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
                var tipoEventoModel = mapper.Map<TipoEventoModel>(tipoEventoRequest);

                var tipoEvento = tipoEventoRepository.ObtenerTipoEvento(tipoEventoModel);
                if (tipoEvento!=null)
                {
                    tipoEventoResult = mapper.Map<TipoEventoResult>(tipoEvento);
                    tipoEventoResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return tipoEventoResult;
        }

	
	}
}

