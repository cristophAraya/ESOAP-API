using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.RegistroCalculo;
using Cl.Sura.ESoapApi.Models.Request.RegistroCalculo;
using Cl.Sura.ESoapApi.Models.Result.RegistroCalculo;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Cl.Sura.ESoapApi.Controllers.RegistroCalculo
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroCalculoController : BaseController<RegistroCalculoController>
    {
        IRegistroCalculoService registroDenuncioService;
        public RegistroCalculoController(ILogger<RegistroCalculoController> logger, IWebHostEnvironment environment, IRegistroCalculoService registroDenuncioService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.registroDenuncioService = registroDenuncioService;
        }

        [HttpPost("v1/registroCalculo")]
        public IActionResult Post([FromBody] RegistroCalculoRequest registroDenuncioRequest)
        {
            RegistroCalculoResult result = new RegistroCalculoResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.registroDenuncioService.RegistroCalculo(registroDenuncioRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error RegistroCalculoController.POST {e.StackTrace}");
                result.Errores.Add(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }
    }
}
