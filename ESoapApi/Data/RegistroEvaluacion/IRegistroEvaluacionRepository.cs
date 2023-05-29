using Cl.Sura.ESoapApi.Models.Entities.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Models.Request.RegistroEvaluacion;

namespace Cl.Sura.ESoapApi.Data.RegistroEvaluacion
{
    public interface IRegistroEvaluacionRepository
    {
        RegistroEvaluacionModel RegistroEvaluacion(RegistroEvaluacionRequest registroEvaluacionRequest);
    }
}