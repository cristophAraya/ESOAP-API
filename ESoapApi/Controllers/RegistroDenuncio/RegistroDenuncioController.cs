using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Request.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Result.RegistroDenuncio;
using Microsoft.AspNetCore.Mvc;

namespace Cl.Sura.ESoapApi.Controllers.RegistroDenuncio
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroDenuncioController : BaseController<RegistroDenuncioController>
    {
        IRegistroDenuncioService registroDenuncioService;
        public RegistroDenuncioController(ILogger<RegistroDenuncioController> logger, IWebHostEnvironment environment, IRegistroDenuncioService registroDenuncioService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.registroDenuncioService = registroDenuncioService;
        }

        [HttpPost("v1/registroDenuncio")]
        public IActionResult Post([FromBody] RegistroDenunioRequest registroDenuncioRequest)
        {
            RegistroDenuncioResult result = new RegistroDenuncioResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.registroDenuncioService.RegistroDenuncio(registroDenuncioRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error RegistroDenuncioController.Post {e.StackTrace}");
                result.Errores.Add(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }
    }
}
