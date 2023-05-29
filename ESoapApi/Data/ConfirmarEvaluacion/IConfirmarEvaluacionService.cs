using Cl.Sura.ESoapApi.Models.Request.ConfirmarEvaluacion;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarEvaluacion;

namespace Cl.Sura.ESoapApi.Data.ConfirmarEvaluacion
{
    public interface IConfirmarEvaluacionService
    {
        ConfirmarEvaluacionResult ConfirmarEvaluacion(ConfirmarEvaluacionRequest confirmarEvaluacionRequest);
    }
}