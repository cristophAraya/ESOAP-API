using AutoMapper;
using Charles.Models.Result.Confirmar;
using CharlesApi.ConfirmarEvaluacion;
using CharlesApi.Controllers.Base;
using CharlesApi.Controllers.ReclamantePrincipal;
using CharlesApi.Data.Liquidar;
using CharlesApi.Data.Reclamante;
using CharlesApi.Helpers.Security;
using CharlesApi.Models.Request.Confirmar;
using CharlesApi.Models.Request.ConfirmarCalculo;
using CharlesApi.Models.Request.ConfirmarPago;
using CharlesApi.Models.Request.CreaPersona;
using CharlesApi.Models.Request.DeclararSiniestro;
using CharlesApi.Models.Request.LiquidarSiniestro;
using CharlesApi.Models.Request.ReclamantePrincipal;
using CharlesApi.Models.Request.RegistroCalculo;
using CharlesApi.Models.Request.RegistroEvaluacion;
using CharlesApi.Models.Request.RegistroPago;
using CharlesApi.Models.Request.RegistroReclamante;
using CharlesApi.Models.Result.ConfirmarCalculo;
using CharlesApi.Models.Result.ConfirmarEvaluacion;
using CharlesApi.Models.Result.ConfirmarPago;
using CharlesApi.Models.Result.ConsultaPersona;
using CharlesApi.Models.Result.ConsultaPersonaCompleta;
using CharlesApi.Models.Result.ConsultaPoliza;
using CharlesApi.Models.Result.ConsultaSiniestro;
using CharlesApi.Models.Result.CreaPersona;
using CharlesApi.Models.Result.DeclararSiniestro;
using CharlesApi.Models.Result.LiquidarSiniestro;
using CharlesApi.Models.Result.ReclamantePrincipal;
using CharlesApi.Models.Result.RegistroCalculo;
using CharlesApi.Models.Result.RegistroEvaluacion;
using CharlesApi.Models.Result.RegistroPago;
using CharlesApi.Models.Result.RegistroReclamante;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;

namespace CharlesApi.Controllers.LiquidarSiniestro
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiquidarSiniestroController : BaseController<LiquidarSiniestroController>
    {
        private ILiquidarService liquidarService;
        public LiquidarSiniestroController(ILogger<LiquidarSiniestroController> logger, IWebHostEnvironment environment, IMapper mapper, ILiquidarService liquidarService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.mapper = mapper;
            this.liquidarService = liquidarService;
        }

       // [HttpPost("v1/liquidarSiniestro")]
       //// [ApiKey]
       // public IActionResult PostLiquidar(LiquidarSiniestroRequest liquidarSiniestroRequest)
       // {
       //     LiquidarSiniestroResult liquidarSiniestroResult = new LiquidarSiniestroResult() { StatusCode = StatusCodes.Status400BadRequest };

       //     //if (liquidarSiniestroRequest.NumeroSiniestro == "19881109")
       //     //{
       //     //    liquidarSiniestroResult.Errores.Add("Siniestro no existe");
       //     //}
       //     //else
       //     //{
       //     //    liquidarSiniestroResult.StatusCode = StatusCodes.Status201Created;
       //     //}

       //     try
       //     {
       //         liquidarService.LiquidarSiniestro(liquidarSiniestroRequest);
       //         liquidarSiniestroResult.StatusCode = StatusCodes.Status201Created;

       //     }
       //     catch (Exception e)
       //     {

       //         logger.LogError($"Error LiquidarSiniestroController.Get {e.StackTrace}");
       //         return StatusCode(StatusCodes.Status500InternalServerError);
       //     }

       //     return StatusCode(liquidarSiniestroResult.StatusCode, liquidarSiniestroResult);
       // }

        [HttpPost("v1/liquidarSiniestro")]
        public IActionResult Post(LiquidarSiniestroRequest liquidarSiniestroRequest)
        {
            logger.LogInformation($"liquidarSiniestro => {DateTime.Now},LiquidarSiniestroRequest => {JsonConvert.SerializeObject(liquidarSiniestroRequest)}");

            LiquidarSiniestroResult liquidarSiniestroResult = new LiquidarSiniestroResult() { StatusCode = StatusCodes.Status204NoContent };

            try
            {
                liquidarSiniestroResult =  liquidarService.LiquidarSiniestro(liquidarSiniestroRequest);
                liquidarSiniestroResult.StatusCode = StatusCodes.Status201Created;
            }
            catch (Exception e)
            {
                logger.LogError($"Error LiquidarSiniestroController.Get {e.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return StatusCode(liquidarSiniestroResult.StatusCode, liquidarSiniestroResult);
        }

    }
}
