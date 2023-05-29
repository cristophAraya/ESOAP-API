using Cl.Sura.ESoapApi.Models.Entities.ConfirmarEvaluacion;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarEvaluacion;

namespace Cl.Sura.ESoapApi.Data.ConfirmarEvaluacion
{
    public interface IConfirmarEvaluacionRepository
    {
        ConfirmarEvaluacionModel ConfirmarEvaluacion(ConfirmarEvaluacionRequest confirmarEvaluacionRequest);
    }
}