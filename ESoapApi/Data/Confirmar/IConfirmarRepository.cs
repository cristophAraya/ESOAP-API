using Cl.Sura.ESoapApi.Models.Entities.Confirmar;
using Cl.Sura.ESoapApi.Models.Request.Confirmar;

namespace Cl.Sura.ESoapApi.Data.Confirmar
{
    public interface IConfirmarRepository
    {
        ConfirmarModel Confirmar(ConfirmarRequest confirmarRequest);
    }
}