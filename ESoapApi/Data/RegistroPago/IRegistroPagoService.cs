using Cl.Sura.ESoapApi.Models.Request.RegistroPago;
using Cl.Sura.ESoapApi.Models.Result.RegistroPago;

namespace Cl.Sura.ESoapApi.Data.RegistroPago
{
    public interface IRegistroPagoService
    {
        RegistroPagoResult RegistroPago(RegistroPagoRequest registroPagoRequest);
    }
}