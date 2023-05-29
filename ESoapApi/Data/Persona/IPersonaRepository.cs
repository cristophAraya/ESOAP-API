using Cl.Sura.ESoapApi.Models.Entities.ConsultaPersona;
using Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta;
using Cl.Sura.ESoapApi.Models.Entities.CreaPersona;
using Cl.Sura.ESoapApi.Models.Request.CreaPersona;

namespace Cl.Sura.ESoapApi.Data.Persona
{
    public interface IPersonaRepository
    {
        ConsultaPersonaModel ConsultaPersona(string egn);
        ConsultaPersonaCompletaModel ConsultaPersonaCompleta(string egn);
        CreaPersonaModel CreaPersona(CreaPersonaRequest personaRequest);
    }
}