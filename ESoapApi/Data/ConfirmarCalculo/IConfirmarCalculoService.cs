using Cl.Sura.ESoapApi.Models.Request.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarCalculo;

namespace Cl.Sura.ESoapApi.Data.ConfirmarCalculo
{
    public interface IConfirmarCalculoService
    {
        ConfirmarCalculoResult ConfirmarCalculo(ConfirmarCalculoRequest confirmarCalculoRequest);
    }
}