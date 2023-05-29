using Cl.Sura.ESoapApi.Models.Request.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Result.RegistroDenuncio;

namespace Cl.Sura.ESoapApi.Data.RegistroDenuncio
{
    public interface IRegistroDenuncioService
    {
        RegistroDenuncioResult RegistroDenuncio(RegistroDenunioRequest registroDenunioRequest);
    }
}