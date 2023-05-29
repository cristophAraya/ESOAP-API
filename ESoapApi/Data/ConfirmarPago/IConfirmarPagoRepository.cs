using Cl.Sura.ESoapApi.Models.Entities.ConfirmarPago;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarPago;

namespace Cl.Sura.ESoapApi.Data.ConfirmarPago
{
    public interface IConfirmarPagoRepository
    {
        ConfirmarPagoModel ConfirmarPago(ConfirmarPagoRequest onfirmarCalculoRequest);
    }
}