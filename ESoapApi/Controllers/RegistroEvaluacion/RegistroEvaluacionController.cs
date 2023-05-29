using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Models.Request.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Models.Result.RegistroEvaluacion;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Cl.Sura.ESoapApi.Controllers.RegistroEvaluacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroEvaluacionController : BaseController<RegistroEvaluacionController>
    {
        IRegistroEvaluacionService registroDenuncioService;
        public RegistroEvaluacionController(ILogger<RegistroEvaluacionController> logger, IWebHostEnvironment environment, IRegistroEvaluacionService registroDenuncioService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.registroDenuncioService = registroDenuncioService;
        }

        [HttpPost("v1/registroEvaluacion")]
        public IActionResult Post([FromBody] RegistroEvaluacionRequest registroDenuncioRequest)
        {
            RegistroEvaluacionResult result = new RegistroEvaluacionResult() { StatusCode = StatusCodes.Status204NoContent };

            try
            {
                result = this.registroDenuncioService.RegistroEvaluacion(registroDenuncioRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error RegistroEvaluacionController.Get {e.StackTrace}");
                result.Errores.Add(e.Message);        
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }
    }
}
