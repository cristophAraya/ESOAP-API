using Cl.Sura.ESoapApi.Models.Entities.ListaEvento;
using Cl.Sura.ESoapApi.Models.Request.ListaEvento;

namespace Cl.Sura.ESoapApi.Data.Evento
{
    public interface IEventoRepository
    {
        ListaEventoModel ListaEventos(ListaEventoRequest listaEventoRequest);
    }
}