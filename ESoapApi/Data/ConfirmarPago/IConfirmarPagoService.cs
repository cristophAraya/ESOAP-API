using Cl.Sura.ESoapApi.Models.Request.ConfirmarPago;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarPago;

namespace Cl.Sura.ESoapApi.Data.ConfirmarPago
{
    public interface IConfirmarPagoService
    {
        ConfirmarPagoResult ConfirmarPago(ConfirmarPagoRequest confirmarCalculoRequest);
    }
}