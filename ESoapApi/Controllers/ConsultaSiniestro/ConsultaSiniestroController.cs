using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.ConsultaSiniestro;
using Cl.Sura.ESoapApi.Models.Result.ConsultaSiniestro;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Cl.Sura.ESoapApi.Controllers.ConsultaSiniestro
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaSiniestroController : BaseController<ConsultaSiniestroController>
    {
        IConsultaSiniestroService confirmarService;
        public ConsultaSiniestroController(ILogger<ConsultaSiniestroController> logger, IWebHostEnvironment environment, IConsultaSiniestroService polizaService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.confirmarService = polizaService;
        }

        [HttpGet("v1/consultaSiniestro")]
        public ActionResult Get(long claimNo)
        {
            ConsultaSiniestroResult result = new ConsultaSiniestroResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.confirmarService.ConsultaSiniestro(claimNo);
            }
            catch (Exception e)
            {

                logger.LogError($"Error ConsultaSiniestroController.Get {e.StackTrace}");
                result.Errores.Add(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }

    }
}