 using AutoMapper;
using CharlesApi.Controllers.Base;
using CharlesApi.Data.Siniestro;
using CharlesApi.Data.SiniestroLog;
using CharlesApi.Data.TipoEvento;
using CharlesApi.Helpers.Base;
using CharlesApi.Helpers.Security;
using CharlesApi.Models.Request.DeclararSiniestro;
using CharlesApi.Models.Request.ListaEvento;
using CharlesApi.Models.Request.RegistroDenuncio;
using CharlesApi.Models.Request.RegistroReclamante;
using CharlesApi.Models.Result.ConsultaPersona;
using CharlesApi.Models.Result.ConsultaPoliza;
using CharlesApi.Models.Result.DeclararSiniestro;
using CharlesApi.Models.Result.ListaEvento;
using CharlesApi.Models.Result.RegistroDenuncio;
using CharlesApi.Models.Result.RegistroReclamante;
using CharlesApi.Repository.TipoEvento;
using CharlesApi.Request.Siniestro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Globalization;
using static Dapper.SqlMapper;

namespace CharlesApi.Controllers.RegistroDenuncio
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroDenuncioController : BaseController<RegistroDenuncioController>
    {

        ISiniestroService siniestroService;
        ITipoEventoService tipoEventoService;
        ISiniestroLogService siniestroLogService;
        public RegistroDenuncioController(ILogger<RegistroDenuncioController> logger, IWebHostEnvironment environment, ISiniestroService siniestroService, IMapper mapper, ITipoEventoService tipoEventoService, ISiniestroLogService siniestroLogService, ISettingsConfig settings)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.mapper = mapper;
            this.siniestroService = siniestroService;
            this.tipoEventoService = tipoEventoService;
            this.siniestroLogService = siniestroLogService;
        }

        [HttpPost("v1/registroDenuncio")]
        //[ApiKey]
        public IActionResult Post( DeclararSiniestroRequest declararSiniestroRequest)
        {
            logger.LogInformation($"registroDenuncio => {DateTime.Now},declararSiniestroRequest => { JsonConvert.SerializeObject(declararSiniestroRequest) }");

            DeclararSiniestroResult declararSiniestroResult = new DeclararSiniestroResult() { StatusCode = StatusCodes.Status400BadRequest };
            RegistroDenuncioResult result = new RegistroDenuncioResult() { StatusCode = StatusCodes.Status204NoContent };


            //if (declararSiniestroRequest.NumeroPoliza != "100036948")
            //{
            //    declararSiniestroResult.Errores.Add("Numero Poliza no corresponde a Patente Indicada");
            //}
            //else
            //{
            //    var random = new Random();
            //    var value = random.Next(0,15000 );
            //    declararSiniestroResult.StatusCode = StatusCodes.Status201Created;
            //    declararSiniestroResult.NumeroSiniestro = value.ToString();
            //}


            try
            {   //Consulta Datos Poliza (IPC 101)
                ConsultaPolizaResult consultaPolizaResult = ConsultaPoliza(declararSiniestroRequest.NumeroPoliza);

                //Existe Poliza ? y validar contra patnte del request
                if (consultaPolizaResult.StatusCode == StatusCodes.Status200OK)
                {
                    var tipoEventoRequest = new Request.TipoEvento.TipoEventoRequest() { CodigoTipoEventoCharles = declararSiniestroRequest.CodigoEvento };
                    var tipoEvento = tipoEventoService.ObtenerTipoEvento(tipoEventoRequest);

                    RegistroDenunioRequest registroDenuncioRequest = new RegistroDenunioRequest();
                    registroDenuncioRequest.ClaimGroup = new ClaimGroup();
                    registroDenuncioRequest.ClaimGroup.PolicyNo = declararSiniestroRequest.NumeroPoliza;// "100036948";
                    registroDenuncioRequest.ClaimGroup.CauseId = 1;
                    registroDenuncioRequest.ClaimGroup.ClaimCategory = "DAMAGES";
                    registroDenuncioRequest.ClaimGroup.EventType = (long)Convert.ToDouble(tipoEvento.CodigoTipoEventoSura);


                    CultureInfo provider = CultureInfo.InvariantCulture;
                    // It throws Argument null exception
                    //var fecha = declararSiniestroRequest.FechaSiniestro.Split(' ', ':');
                    //var fechaConvertida = new DateTime(Convert.ToInt32(fecha[0].Substring(0, 4)), Convert.ToInt32(fecha[0].Substring(4, 2)), Convert.ToInt32(fecha[0].Substring(6, 2)));

                    //sDateTime dateTime10 = DateTime.ParseExact(declararSiniestroRequest.FechaSiniestro, "YYYYMMDD HH:mm:ss", provider);

                    registroDenuncioRequest.ClaimGroup.EventDate = "2023-02-13T00:00:00Z";//  declararSiniestroRequest.FechaSiniestro.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
                    registroDenuncioRequest.ClaimGroup.EventDescription = declararSiniestroRequest.RelatoSiniestro;// "Relato del siniestro texto libre";
                    registroDenuncioRequest.ClaimGroup.EventCountry = "CL";
                    registroDenuncioRequest.ClaimGroup.EventPlace = declararSiniestroRequest.LugarSiniestro;// "Lugar del siniestro texto libre";
                    registroDenuncioRequest.ClaimGroup.ClaimComment = declararSiniestroRequest.ComentarioSiniestro;// "Comentario del siniestro texto libre";

                    logger.LogInformation($"REGISTRO DENUNCIO => {DateTime.Now}, registroDenuncioRequest =>{JsonConvert.SerializeObject(registroDenuncioRequest)}");

                    //DECLARAR SINIESTRO  => REGISTRO DENUNCIO (IPC 110)
                    result = RegistroDenunio(registroDenuncioRequest);
                    if (result.StatusCode == StatusCodes.Status200OK)
                    {
                        declararSiniestroResult.NumeroSiniestro = result.NotificationId.ToString();
                        declararSiniestroResult.StatusCode = StatusCodes.Status201Created;

                        //BD
                        var siniestroRequest = mapper.Map<SiniestroRequest>(declararSiniestroRequest);
                        siniestroRequest.NumeroSiniestro = declararSiniestroResult.NumeroSiniestro;
                        siniestroService.CrearSiniestro(siniestroRequest);
                    }
                    else
                    {
                        Request.SiniestroLog.SiniestroLogRequest siniestroLogRequest = new Request.SiniestroLog.SiniestroLogRequest();
                        siniestroLogRequest.Status = "Problemas al REGISTRAR DENUNCIO (IPC 110)";
                        siniestroLogRequest.NumeroPoliza = declararSiniestroRequest.NumeroPoliza;
                        siniestroLogRequest.MensajeError = result.Errores.FirstOrDefault();
                        siniestroLogRequest.Fecha = DateTime.Now;
                        siniestroLogService.CrearSiniestroLog(siniestroLogRequest);

                        declararSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                        declararSiniestroResult.Errores.Add(siniestroLogRequest.MensajeError);
                    }
                }
                else
                {
                    
                    Request.SiniestroLog.SiniestroLogRequest siniestroLogRequest = new Request.SiniestroLog.SiniestroLogRequest();
                    siniestroLogRequest.Status = "Problemas al Consultar Poliza";
                    siniestroLogRequest.NumeroPoliza = declararSiniestroRequest.NumeroPoliza;
                    siniestroLogRequest.MensajeError = consultaPolizaResult.Errores.FirstOrDefault();
                    siniestroLogRequest.Fecha = DateTime.Now;
                    siniestroLogService.CrearSiniestroLog(siniestroLogRequest);

                    declararSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                    declararSiniestroResult.Errores.Add(siniestroLogRequest.MensajeError);
                }
            }
            catch (Exception e)
            {
                logger.LogError($"Error RegistroDenuncioController.Post {e.StackTrace}");
                declararSiniestroResult.Errores.Add(e.Message);
                logger.LogInformation($"registroDenuncio => {DateTime.Now},declararSiniestroResult => {JsonConvert.SerializeObject(declararSiniestroResult)}");
                return StatusCode(StatusCodes.Status400BadRequest, declararSiniestroResult);
            }

            logger.LogInformation($"registroDenuncio => {DateTime.Now},declararSiniestroResult => {JsonConvert.SerializeObject(declararSiniestroResult)}");
            return StatusCode(declararSiniestroResult.StatusCode, declararSiniestroResult);
        }




        private ConsultaPolizaResult ConsultaPoliza(string policyNo)
        {  
            //101
            ConsultaPolizaResult consultaPolizaResult = new ConsultaPolizaResult();
            var options = new RestClientOptions(settings.UrlBaseEsoapApi)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/poliza/v1/poliza?policyNo={policyNo}", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaPolizaResult>(request);
            consultaPolizaResult = response.Data;
            //if (response.IsSuccessStatusCode)
            //{
            //    consultaPolizaResult = response.Data;
            //}
            return consultaPolizaResult;
        }


        private RegistroDenuncioResult RegistroDenunio( RegistroDenunioRequest registroDenuncioRequest )
        {
            //110
            RegistroDenuncioResult registroDenuncioResult = new RegistroDenuncioResult();

            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/RegistroDenuncio/v1/registroDenuncio");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(registroDenuncioRequest);
            request.AddStringBody(body, DataFormat.Json);
            var response = client.Execute<RegistroDenuncioResult>(request);
            registroDenuncioResult = response.Data;
            //if (response.IsSuccessStatusCode)
            //{
            //    registroDenuncioResult = JsonConvert.DeserializeObject<RegistroDenuncioResult>(response.Content);
            //}
            return registroDenuncioResult;
        }
    }
}
