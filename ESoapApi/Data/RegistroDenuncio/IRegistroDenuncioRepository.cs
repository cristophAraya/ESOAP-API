using Cl.Sura.ESoapApi.Models.Entities.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Request.RegistroDenuncio;


namespace Cl.Sura.ESoapApi.Data.RegistroDenuncio
{
    public interface IRegistroDenuncioRepository
    {
        RegistroDenuncioModel RegistroDenuncio(RegistroDenunioRequest registroDenunioRequest);
    }
}