using CharlesApi.Models.Request.ConfirmarLiquidacion;
using CharlesApi.Models.Request.LiquidarSiniestro;
using CharlesApi.Models.Result.ConfirmarLiquidacion;
using CharlesApi.Models.Result.LiquidarSiniestro;

namespace CharlesApi.Data.Liquidar
{
    public interface ILiquidarService
    {
       // void LiquidarSiniestro(LiquidarSiniestroRequest liquidarSiniestroRequest);
      //  ConfirmarLiquidacionResult ConfirmarLiquidacion(ConfirmarLiquidacionRequest confirmarLiquidacionRequest);
        LiquidarSiniestroResult LiquidarSiniestro(LiquidarSiniestroRequest liquidarSiniestroRequest);
    }
}