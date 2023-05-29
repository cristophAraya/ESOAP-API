using Cl.Sura.ESoapApi.Models.Request.RegistroReclamante;
using Cl.Sura.ESoapApi.Models.Result.RegistroReclamante;

namespace Cl.Sura.ESoapApi.Data.RegistroReclamante
{
    public interface IRegistroReclamanteService
    {
        RegistroReclamanteResult RegistroReclamante(RegistroReclamanteRequest registroReclamanteRequest);
    }
}