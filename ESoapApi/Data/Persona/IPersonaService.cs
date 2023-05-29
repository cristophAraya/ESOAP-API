using Cl.Sura.ESoapApi.Models.Request.CreaPersona;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPersona;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta;
using Cl.Sura.ESoapApi.Models.Result.CreaPersona;

namespace Cl.Sura.ESoapApi.Data.Poliza
{
    public interface IPersonaService
    {
        ConsultaPersonaResult ConsultaPersona(string egn);
        ConsultaPersonaCompletaResult ConsultaPersonaCompleta(string egn);
        CreaPersonaResult CrearPersona(CreaPersonaRequest personaRequest);
    }
}