using AutoMapper;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.RegistroCalculo;
using Cl.Sura.ESoapApi.Models.Result.RegistroCalculo;


namespace Cl.Sura.ESoapApi.Data.RegistroCalculo
{
    public class RegistroCalculoService : IRegistroCalculoService
    {
        private ISettingsConfig settings;
        private IRegistroCalculoRepository eventoRepository;
        private IMapper mapper;
        public RegistroCalculoService(IRegistroCalculoRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.eventoRepository = eventoRepository;
            this.mapper = mapper;
        }
        public RegistroCalculoResult RegistroCalculo(RegistroCalculoRequest registroCalculoRequest)
        {
            RegistroCalculoResult listaRegistroCalculo = new RegistroCalculoResult();
            listaRegistroCalculo.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = eventoRepository.RegistroCalculo(registroCalculoRequest);
                if (eventos != null)
                {
                    listaRegistroCalculo = mapper.Map<RegistroCalculoResult>(eventos);
                    listaRegistroCalculo.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaRegistroCalculo;

        }
    }
}
