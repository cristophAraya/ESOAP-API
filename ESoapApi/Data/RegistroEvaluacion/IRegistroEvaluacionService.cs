using Cl.Sura.ESoapApi.Models.Request.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Models.Result.RegistroEvaluacion;

namespace Cl.Sura.ESoapApi.Data.RegistroEvaluacion
{
    public interface IRegistroEvaluacionService
    {
        RegistroEvaluacionResult RegistroEvaluacion(RegistroEvaluacionRequest registroEvaluacionRequest);
    }
}