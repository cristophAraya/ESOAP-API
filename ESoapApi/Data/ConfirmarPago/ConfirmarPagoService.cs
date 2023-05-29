using AutoMapper;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarPago;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarPago;


namespace Cl.Sura.ESoapApi.Data.ConfirmarPago
{
    public class ConfirmarPagoService : IConfirmarPagoService
    {
        private ISettingsConfig settings;
        private IConfirmarPagoRepository eventoRepository;
        private IMapper mapper;
        public ConfirmarPagoService(IConfirmarPagoRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.eventoRepository = eventoRepository;
            this.mapper = mapper;
        }
        public ConfirmarPagoResult ConfirmarPago(ConfirmarPagoRequest confirmarCalculoRequest)
        {
            ConfirmarPagoResult listaConfirmarPago = new ConfirmarPagoResult();
            listaConfirmarPago.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = eventoRepository.ConfirmarPago(confirmarCalculoRequest);
                if (eventos != null)
                {
                    listaConfirmarPago = mapper.Map<ConfirmarPagoResult>(eventos);
                    listaConfirmarPago.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaConfirmarPago;

        }
    }
}
