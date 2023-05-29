using AutoMapper;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarCalculo;


namespace Cl.Sura.ESoapApi.Data.ConfirmarCalculo
{
    public class ConfirmarCalculoService : IConfirmarCalculoService
    {
        private ISettingsConfig settings;
        private IConfirmarCalculoRepository eventoRepository;
        private IMapper mapper;
        public ConfirmarCalculoService(IConfirmarCalculoRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.eventoRepository = eventoRepository;
            this.mapper = mapper;
        }
        public ConfirmarCalculoResult ConfirmarCalculo(ConfirmarCalculoRequest confirmarCalculoRequest)
        {
            ConfirmarCalculoResult listaConfirmarCalculo = new ConfirmarCalculoResult();
            listaConfirmarCalculo.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = eventoRepository.ConfirmarCalculo(confirmarCalculoRequest);
                if (eventos != null)
                {
                    listaConfirmarCalculo = mapper.Map<ConfirmarCalculoResult>(eventos);
                    listaConfirmarCalculo.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaConfirmarCalculo;

        }
    }
}
