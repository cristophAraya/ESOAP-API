using Cl.Sura.ESoapApi.Models.Entities.RegistroCalculo;
using Cl.Sura.ESoapApi.Models.Request.RegistroCalculo;

namespace Cl.Sura.ESoapApi.Data.RegistroCalculo
{
    public interface IRegistroCalculoRepository
    {
        RegistroCalculoModel RegistroCalculo(RegistroCalculoRequest registroCalculoRequest);
    }
}