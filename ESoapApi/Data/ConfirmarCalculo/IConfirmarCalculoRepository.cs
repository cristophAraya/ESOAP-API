using Cl.Sura.ESoapApi.Models.Entities.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarCalculo;

namespace Cl.Sura.ESoapApi.Data.ConfirmarCalculo
{
    public interface IConfirmarCalculoRepository
    {
        ConfirmarCalculoModel ConfirmarCalculo(ConfirmarCalculoRequest onfirmarCalculoRequest);
    }
}