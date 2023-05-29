using AutoMapper;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.RegistroPago;
using Cl.Sura.ESoapApi.Models.Result.RegistroPago;


namespace Cl.Sura.ESoapApi.Data.RegistroPago
{
    public class RegistroPagoService : IRegistroPagoService
    {
        private ISettingsConfig settings;
        private IRegistroPagoRepository eventoRepository;
        private IMapper mapper;
        public RegistroPagoService(IRegistroPagoRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.eventoRepository = eventoRepository;
            this.mapper = mapper;
        }
        public RegistroPagoResult RegistroPago(RegistroPagoRequest registroPagoRequest)
        {
            RegistroPagoResult listaRegistroPago = new RegistroPagoResult();
            listaRegistroPago.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = eventoRepository.RegistroPago(registroPagoRequest);
                if (eventos != null)
                {
                    listaRegistroPago = mapper.Map<RegistroPagoResult>(eventos);
                    listaRegistroPago.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaRegistroPago;

        }
    }
}
