using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.Poliza;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza;
using Microsoft.AspNetCore.Mvc;

namespace Cl.Sura.ESoapApi.Controllers.Poliza
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController :  BaseController<PolizaController>
    {
        IPolizaService polizaService;
        public PolizaController(ILogger<PolizaController> logger, IWebHostEnvironment environment, IPolizaService polizaService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.polizaService = polizaService;
        }

        [HttpGet("v1/poliza")]
        public ActionResult Get(string policyNo )
        {
            ConsultaPolizaResult result = new ConsultaPolizaResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.polizaService.ConsultaPoliza(policyNo);
            }
            catch (Exception e)
            {
                logger.LogError($"Error PolizaController.Get {e.StackTrace}");
                result.Errores.Add(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }

    }
}
