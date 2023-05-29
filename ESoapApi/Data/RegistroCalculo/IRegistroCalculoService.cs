using Cl.Sura.ESoapApi.Models.Request.RegistroCalculo;
using Cl.Sura.ESoapApi.Models.Result.RegistroCalculo;

namespace Cl.Sura.ESoapApi.Data.RegistroCalculo
{
    public interface IRegistroCalculoService
    {
        RegistroCalculoResult RegistroCalculo(RegistroCalculoRequest registroCalculoRequest);
    }
}