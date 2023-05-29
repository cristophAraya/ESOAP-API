using Cl.Sura.ESoapApi.Models.Request.ListaEvento;
using Cl.Sura.ESoapApi.Models.Result.ListaEvento;

namespace Cl.Sura.ESoapApi.Data.Evento
{
    public interface IEventoService
    {
        ListaEventoResult ListarEventos(ListaEventoRequest listaEventoRequest);
    }
}