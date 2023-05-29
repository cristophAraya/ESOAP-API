using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.RegistroReclamante;
using Cl.Sura.ESoapApi.Models.Request.RegistroReclamante;
using Cl.Sura.ESoapApi.Models.Result.RegistroReclamante;
using Microsoft.AspNetCore.Mvc;

namespace Cl.Sura.ESoapApi.Controllers.RegistroReclamante
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroReclamanteController : BaseController<RegistroReclamanteController>
    {
        IRegistroReclamanteService registroDenuncioService;
        public RegistroReclamanteController(ILogger<RegistroReclamanteController> logger, IWebHostEnvironment environment, IRegistroReclamanteService registroDenuncioService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.registroDenuncioService = registroDenuncioService;
        }

        [HttpPost("v1/registroReclamante")]
        public IActionResult Post([FromBody] RegistroReclamanteRequest registroDenuncioRequest)
        {
            RegistroReclamanteResult result = new RegistroReclamanteResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.registroDenuncioService.RegistroReclamante(registroDenuncioRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error PolizaController.Get {e.StackTrace}");
                result.Errores.Add(e.Message);
                result.StatusCode = StatusCodes.Status400BadRequest;
                return StatusCode(result.StatusCode, result);
            }
            return StatusCode(result.StatusCode, result);
        }
    }
}
