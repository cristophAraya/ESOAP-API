using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.ConfirmarEvaluacion;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarEvaluacion;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarEvaluacion;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Cl.Sura.ESoapApi.Controllers.ConfirmarEvaluacionEvaluacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmarEvaluacionController : BaseController<ConfirmarEvaluacionController>
    {
        IConfirmarEvaluacionService confirmarService;
        public ConfirmarEvaluacionController(ILogger<ConfirmarEvaluacionController> logger, IWebHostEnvironment environment, IConfirmarEvaluacionService polizaService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.confirmarService = polizaService;
        }

        [HttpPost("v1/confirmarEvaluacion")]
        public ActionResult Post(ConfirmarEvaluacionRequest confirmarRequest)
        {
            ConfirmarEvaluacionResult result = new ConfirmarEvaluacionResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.confirmarService.ConfirmarEvaluacion(confirmarRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error ConfirmarEvaluacionController.Post {e.StackTrace}");
                result.Errores.Add(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }

    }
}