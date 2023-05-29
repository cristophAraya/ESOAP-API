using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Data.Evento;
using Cl.Sura.ESoapApi.Models.Request.ListaEvento;
using Cl.Sura.ESoapApi.Models.Result.ListaEvento;
using Microsoft.AspNetCore.Mvc;

namespace Cl.Sura.ESoapApi.Controllers.ListaEvento
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaEventosController : BaseController<ListaEventosController>
    {
        IEventoService eventoService;

        public ListaEventosController(ILogger<ListaEventosController> logger, IWebHostEnvironment environment, IEventoService eventoService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.eventoService = eventoService;            
        }

        [HttpPost("v1/listaEventos")]
        public IActionResult Post([FromBody] ListaEventoRequest listaEventoRequest)
        {
            ListaEventoResult result = new ListaEventoResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
               result = this.eventoService.ListarEventos(listaEventoRequest);
            }
            catch (Exception e)
            {
                logger.LogError($"Error PolizaController.Get {e.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return StatusCode(result.StatusCode, result);
        }

    }
}
