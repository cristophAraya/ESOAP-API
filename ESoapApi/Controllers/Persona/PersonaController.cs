using Cl.Sura.ESoapApi.Controllers.Base;
using Cl.Sura.ESoapApi.Controllers.Poliza;
using Cl.Sura.ESoapApi.Data.Poliza;
using Cl.Sura.ESoapApi.Models.Request.CreaPersona;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPersona;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza;
using Cl.Sura.ESoapApi.Models.Result.CreaPersona;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Cl.Sura.ESoapApi.Controllers.Persona
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : BaseController<PersonaController>
    {
        IPersonaService personaService;
        public PersonaController(ILogger<PersonaController> logger, IWebHostEnvironment environment, IPersonaService personaService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.personaService = personaService;
        }

        [HttpGet("v1/persona")]
        public ActionResult Get(string egn)
        {
            ConsultaPersonaResult result = new ConsultaPersonaResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.personaService.ConsultaPersona(egn);
            }
            catch (Exception e)
            {
                logger.LogError($"Error PolizaController.Get {e.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("v1/persona")]
        public IActionResult Post([FromBody] CreaPersonaRequest personaRequest)
        {
            CreaPersonaResult result = new CreaPersonaResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
               result = this.personaService.CrearPersona(personaRequest);
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


        [HttpGet("v1/consultaPersonaCompleta")]
        public ActionResult GetPersona(string egn)
        {
            ConsultaPersonaCompletaResult result = new ConsultaPersonaCompletaResult() { StatusCode = StatusCodes.Status204NoContent };
            try
            {
                result = this.personaService.ConsultaPersonaCompleta(egn);
            }
            catch (Exception e)
            {
                logger.LogError($"Error PolizaController.Get {e.StackTrace}");
                result.Errores.Add(e.Message);
                result.StatusCode = StatusCodes.Status400BadRequest;
                result.StatusCode = StatusCodes.Status400BadRequest;
                return StatusCode(StatusCodes.Status400BadRequest, result);
            }
            return StatusCode(result.StatusCode, result);
        }

    }
}
