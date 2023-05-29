using Cl.Sura.ESoapApi.Models.Entities.RegistroReclamante;
using Cl.Sura.ESoapApi.Models.Request.RegistroReclamante;


namespace Cl.Sura.ESoapApi.Data.RegistroReclamante
{
    public interface IRegistroReclamanteRepository
    {
        RegistroReclamanteModel RegistroReclamante(RegistroReclamanteRequest registroReclamanteRequest);
    }
}