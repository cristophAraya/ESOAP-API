using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.ConfirmarPago;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarPago;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarPago;
using Microsoft.AspNetCore.Mvc;

namespace Cl.Sura.ESoapApi.Controllers.ConfirmarPago
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmarPagoController : BaseController<ConfirmarPagoController>
    {
        IConfirmarPagoService confirmarService;
        public ConfirmarPagoController(ILogger<ConfirmarPagoController> logger, IWebHostEnvironment environment, IConfirmarPagoService polizaService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.confirmarService = polizaService;
        }

        [HttpPost("v1/confirmarPago")]
        public ActionResult Post(ConfirmarPagoRequest confirmarRequest)
        {
            ConfirmarPagoResult result = new ConfirmarPagoResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.confirmarService.ConfirmarPago(confirmarRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error ConfirmarPagoController.Get {e.StackTrace}");
                result.Errores.Add(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return StatusCode(result.StatusCode, result);
        }

    }
}