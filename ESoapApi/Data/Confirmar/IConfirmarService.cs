using Cl.Sura.ESoapApi.Models.Request.Confirmar;
using Cl.Sura.ESoapApi.Models.Result.Confirmar;


namespace Cl.Sura.ESoapApi.Data.Confirmar
{
    public interface IConfirmarService
    {
        ConfirmarResult Confimar(ConfirmarRequest confirmarRequest);
    }
}