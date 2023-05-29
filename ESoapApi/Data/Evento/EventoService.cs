using AutoMapper;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.ListaEvento;
using Cl.Sura.ESoapApi.Models.Result.ListaEvento;


namespace Cl.Sura.ESoapApi.Data.Evento
{
    public class EventoService : IEventoService
    {
        private ISettingsConfig settings;
        private IEventoRepository eventoRepository;
        private IMapper mapper;
        public EventoService(IEventoRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.eventoRepository = eventoRepository;
            this.mapper = mapper;
        }
        public ListaEventoResult ListarEventos(ListaEventoRequest listaEventoRequest)
        {
            ListaEventoResult listaEvento = new ListaEventoResult();
            listaEvento.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = eventoRepository.ListaEventos(listaEventoRequest);
                if (eventos != null)
                {
                    listaEvento = mapper.Map<ListaEventoResult>(eventos);
                    listaEvento.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaEvento;

        }
    }
}
