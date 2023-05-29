using CharlesApi.Request.TipoReclamante;
using CharlesApi.Result.TipoReclamante;

namespace CharlesApi.Data.TipoReclamante
{
    public interface ITipoReclamanteService
    {
     public    TipoReclamanteResult ObtenerTipoReclamante(TipoReclamanteRequest tipoReclamanteRequest);
    }
}