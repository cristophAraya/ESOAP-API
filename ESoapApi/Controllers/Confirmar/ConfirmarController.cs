using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Controllers.Confirmar;
using Cl.Sura.ESoapApi.Data.Confirmar;
using Cl.Sura.ESoapApi.Models.Request.Confirmar;
using Cl.Sura.ESoapApi.Models.Result.Confirmar;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Cl.Sura.ESoapApi.Controllers.Confirmar
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmarController : BaseController<ConfirmarController>
    {
        IConfirmarService confirmarService;
        public ConfirmarController(ILogger<ConfirmarController> logger, IWebHostEnvironment environment, IConfirmarService polizaService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.confirmarService = polizaService;
        }

        [HttpPost("v1/confirmar")]
        public IActionResult Post([FromBody] ConfirmarRequest confirmarRequest)
        {
            ConfirmarResult result = new ConfirmarResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.confirmarService.Confimar(confirmarRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error ConfirmarController.Get {e.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return StatusCode(result.StatusCode, result);
        }

    }
}
