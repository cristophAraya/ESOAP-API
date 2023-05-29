using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarCalculo;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Cl.Sura.ESoapApi.Controllers.ConfirmarCalculo
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmarCalculoController : BaseController<ConfirmarCalculoController>
    {
        IConfirmarCalculoService confirmarService;
        public ConfirmarCalculoController(ILogger<ConfirmarCalculoController> logger, IWebHostEnvironment environment, IConfirmarCalculoService polizaService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.confirmarService = polizaService;
        }

        [HttpPost("v1/confirmarCalculo")]
        public ActionResult Post(ConfirmarCalculoRequest confirmarRequest)
        {
            ConfirmarCalculoResult result = new ConfirmarCalculoResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.confirmarService.ConfirmarCalculo(confirmarRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error ConfirmarCalculoController.Get {e.StackTrace}");
                result.Errores.Add(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }

    }
}