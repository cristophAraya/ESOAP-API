using AutoMapper;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.Confirmar;
using Cl.Sura.ESoapApi.Models.Result.Confirmar;

namespace Cl.Sura.ESoapApi.Data.Confirmar
{
    public class ConfirmarService : IConfirmarService
    {
        private ISettingsConfig settings;
        private IConfirmarRepository eventoRepository;
        private IMapper mapper;
        public ConfirmarService(IConfirmarRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.eventoRepository = eventoRepository;
            this.mapper = mapper;
        }
        public ConfirmarResult Confimar(ConfirmarRequest confirmarRequest)
        {
            ConfirmarResult confirmar = new ConfirmarResult();
            confirmar.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = eventoRepository.Confirmar(confirmarRequest);
                if (eventos != null)
                {
                    confirmar = mapper.Map<ConfirmarResult>(eventos);
                    confirmar.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return confirmar;

        }
    }
}
