using AutoMapper;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarEvaluacion;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarEvaluacion;


namespace Cl.Sura.ESoapApi.Data.ConfirmarEvaluacion
{
    public class ConfirmarEvaluacionService : IConfirmarEvaluacionService
    {
        private ISettingsConfig settings;
        private IConfirmarEvaluacionRepository eventoRepository;
        private IMapper mapper;
        public ConfirmarEvaluacionService(IConfirmarEvaluacionRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.eventoRepository = eventoRepository;
            this.mapper = mapper;
        }
        public ConfirmarEvaluacionResult ConfirmarEvaluacion(ConfirmarEvaluacionRequest confirmarEvaluacionRequest)
        {
            ConfirmarEvaluacionResult listaConfirmarEvaluacion = new ConfirmarEvaluacionResult();
            listaConfirmarEvaluacion.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = eventoRepository.ConfirmarEvaluacion(confirmarEvaluacionRequest);
                if (eventos != null)
                {
                    listaConfirmarEvaluacion = mapper.Map<ConfirmarEvaluacionResult>(eventos);
                    listaConfirmarEvaluacion.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaConfirmarEvaluacion;

        }
    }
}
