using Cl.Sura.ESoapApi.Models.Entities.RegistroPago;
using Cl.Sura.ESoapApi.Models.Request.RegistroPago;

namespace Cl.Sura.ESoapApi.Data.RegistroPago
{
    public interface IRegistroPagoRepository
    {
        RegistroPagoModel RegistroPago(RegistroPagoRequest registroPagoRequest);
    }
}