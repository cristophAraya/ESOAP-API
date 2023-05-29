using AutoMapper;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Models.Result.RegistroEvaluacion;


namespace Cl.Sura.ESoapApi.Data.RegistroEvaluacion
{
    public class RegistroEvaluacionService : IRegistroEvaluacionService
    {
        private ISettingsConfig settings;
        private IRegistroEvaluacionRepository registroEvaluacionRepository;
        private IMapper mapper;
        public RegistroEvaluacionService(IRegistroEvaluacionRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.registroEvaluacionRepository = eventoRepository;
            this.mapper = mapper;
        }
        public RegistroEvaluacionResult RegistroEvaluacion(RegistroEvaluacionRequest registroEvaluacionRequest)
        {
            RegistroEvaluacionResult listaRegistroEvaluacion = new RegistroEvaluacionResult();
            listaRegistroEvaluacion.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = registroEvaluacionRepository.RegistroEvaluacion(registroEvaluacionRequest);
                if (eventos != null)
                {
                    listaRegistroEvaluacion = mapper.Map<RegistroEvaluacionResult>(eventos);
                    listaRegistroEvaluacion.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaRegistroEvaluacion;

        }
    }
}
