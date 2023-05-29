using AutoMapper;
using CharlesApi.Controllers.Base;
using CharlesApi.Controllers.LiquidarSiniestro;
using CharlesApi.Data.Liquidar;
using CharlesApi.Helpers.Security;
using CharlesApi.Models.Request.ConfirmarLiquidacion;
using CharlesApi.Models.Request.LiquidarSiniestro;
using CharlesApi.Models.Result.ConfirmarLiquidacion;
using CharlesApi.Models.Result.LiquidarSiniestro;
using Microsoft.AspNetCore.Mvc;

namespace CharlesApi.Controllers.ConfirmarLiquidacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmarLiquidacionController : BaseController<ConfirmarLiquidacionController>
    {
        private ILiquidarService liquidarService;
        public ConfirmarLiquidacionController(ILogger<ConfirmarLiquidacionController> logger, IWebHostEnvironment environment, IMapper mapper, ILiquidarService liquidarService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.mapper = mapper;
            this.liquidarService = liquidarService;
        }

        [HttpPost("v1/confirmarLiquidacion")]
       // [ApiKey]
        public IActionResult Post(ConfirmarLiquidacionRequest confirmarLiquidacionRequest)
        {
            ConfirmarLiquidacionResult confirmarResutl = new ConfirmarLiquidacionResult() { StatusCode = StatusCodes.Status400BadRequest };

            //if (confirmarLiquidacionRequest.NumeroSiniestro == "19881109")
            //{
            //    confirmarResutl.Errores.Add("Siniestro no existe");
            //}
            //else
            //{
            //    confirmarResutl.StatusCode = StatusCodes.Status201Created;
            //}


            try
            {
              //  confirmarResutl = liquidarService.ConfirmarLiquidacion(confirmarLiquidacionRequest);
            }
            catch (Exception e)
            {

                logger.LogError($"Error ConfirmarLiquidacionController.Post {e.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return StatusCode(confirmarResutl.StatusCode, confirmarResutl);
        }
    }
}
