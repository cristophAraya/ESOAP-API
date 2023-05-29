using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.RegistroPago;
using Cl.Sura.ESoapApi.Models.Request.RegistroPago;
using Cl.Sura.ESoapApi.Models.Result.RegistroPago;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Cl.Sura.ESoapApi.Controllers.RegistroPago
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroPagoController : BaseController<RegistroPagoController>
    {
        IRegistroPagoService registroDenuncioService;
        public RegistroPagoController(ILogger<RegistroPagoController> logger, IWebHostEnvironment environment, IRegistroPagoService registroDenuncioService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.registroDenuncioService = registroDenuncioService;
        }

        [HttpPost("v1/registroPago")]
        public IActionResult Post([FromBody] RegistroPagoRequest registroPagoRequest)
        {
            RegistroPagoResult result = new RegistroPagoResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.registroDenuncioService.RegistroPago(registroPagoRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error RegistroPagoController.Get {e.StackTrace}");
                result.Errores.Add(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }
    }
}