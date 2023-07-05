using CharlesApi.Models.Result.TipoReclamante;
using CharlesApi.Request.TipoReclamante;

namespace CharlesApi.Data.TipoReclamante
{
    public interface ITipoReclamanteService
    {
     public    TipoReclamanteResult ObtenerTipoReclamante(TipoReclamanteRequest tipoReclamanteRequest);
    }
}