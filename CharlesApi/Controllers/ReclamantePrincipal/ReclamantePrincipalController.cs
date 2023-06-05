using AutoMapper;
using Charles.Models.Result.Confirmar;
using CharlesApi.Controllers.Base;
using CharlesApi.Data.CoberturaSiniestrada;
using CharlesApi.Data.Participante;
using CharlesApi.Data.Reclamante;
using CharlesApi.Data.SiniestroLog;
using CharlesApi.Data.TipoReclamante;
using CharlesApi.Models.Request.Confirmar;
using CharlesApi.Models.Request.CreaPersona;
using CharlesApi.Models.Request.ReclamantePrincipal;
using CharlesApi.Models.Request.RegistroReclamante;
using CharlesApi.Models.Result.ConsultaPersona;
using CharlesApi.Models.Result.ConsultaPoliza;
using CharlesApi.Models.Result.ConsultaSiniestro;
using CharlesApi.Models.Result.CreaPersona;
using CharlesApi.Models.Result.ReclamantePrincipal;
using CharlesApi.Models.Result.RegistroReclamante;
using CharlesApi.Request.CoberturaSiniestrada;
using CharlesApi.Request.Participante;
using CharlesApi.Request.Reclamante;
using CharlesApi.Request.SiniestroLog;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace CharlesApi.Controllers.ReclamantePrincipal
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReclamantePrincipalController :  BaseController<ReclamantePrincipalController>
    {
        IReclamanteService reclamanteService;
        IParticipanteService participanteService;
        ITipoReclamanteService tipoReclamanteRepository;
        ICoberturaSiniestradaService coberturaSiniestradaService;
        ISiniestroLogService siniestroLogService;

        public ReclamantePrincipalController(ILogger<ReclamantePrincipalController> logger, IWebHostEnvironment environment,IMapper mapper, IReclamanteService reclamanteService, IParticipanteService participanteService, ITipoReclamanteService tipoReclamanteRepository, ICoberturaSiniestradaService coberturaSiniestradaService, ISiniestroLogService siniestroLogService)
        {
            this.logger = logger;
            this.environment = environment;
            this.settings = settings;
            this.mapper = mapper;
            this.reclamanteService = reclamanteService;
            this.participanteService = participanteService;
            this.tipoReclamanteRepository = tipoReclamanteRepository;
            this.coberturaSiniestradaService = coberturaSiniestradaService;
            this.siniestroLogService = siniestroLogService;
        }

        [HttpPost("v1/reclamantePrincipal")]
     //   [ApiKey]
        public IActionResult Post(ReclamantePrincipalResquest reclamantePrincipalRequest)
        {
            ReclamantePrincipalResult reclamantePrincipalResult = new ReclamantePrincipalResult() { StatusCode = StatusCodes.Status400BadRequest };
            try
            {               
                //validar siniestro al 115
                var siniestro = ConsultaSiniestro(reclamantePrincipalRequest.NumeroSiniestro);
                if(siniestro.StatusCode == StatusCodes.Status200OK)
                {
                    //EXISTE PERSONA
                    var persona = ConsultaPersona(reclamantePrincipalRequest.Reclamante.Rut);
                    if(persona.StatusCode != StatusCodes.Status200OK && persona.TotalRowCount == 0)
                    {
                        var creaPersona =  CreaPersona(reclamantePrincipalRequest);
                        if (creaPersona.StatusCode == StatusCodes.Status200OK)
                        {
                            persona = ConsultaPersona(reclamantePrincipalRequest.Reclamante.Rut);
                        }
                        else
                        {
                            RegistraSiniestroLog(reclamantePrincipalRequest, "PROBLEMAS AL CREAR PERSONA (IPC 107)", creaPersona.Errores.FirstOrDefault());
                            reclamantePrincipalResult.StatusCode = StatusCodes.Status400BadRequest;
                            reclamantePrincipalResult.Errores.Add(creaPersona.Errores.FirstOrDefault());
                            return StatusCode(reclamantePrincipalResult.StatusCode, reclamantePrincipalResult);
                        }
                    }

                    if (persona.StatusCode != StatusCodes.Status200OK)
                    {
                        RegistraSiniestroLog(reclamantePrincipalRequest, "PROBLEMAS AL CONSULTAR PERSONA (IPC 109)", persona.Errores.FirstOrDefault());
                        reclamantePrincipalResult.StatusCode = StatusCodes.Status400BadRequest;
                        reclamantePrincipalResult.Errores.Add(persona.Errores.FirstOrDefault());
                        return StatusCode(reclamantePrincipalResult.StatusCode, reclamantePrincipalResult);
                    }

                    var participante = ConsultaPersona(reclamantePrincipalRequest.Reclamante.Participante.Rut);
                    if (participante.StatusCode == StatusCodes.Status200OK && participante.TotalRowCount == 0)
                    {
                        var creaPersona = CreaPersonaParticipante(reclamantePrincipalRequest.Reclamante.Participante);//107
                        if (creaPersona.StatusCode == StatusCodes.Status200OK)
                        {
                            participante = ConsultaPersona(reclamantePrincipalRequest.Reclamante.Participante.Rut);
                        }
                        else
                        {
                            RegistraSiniestroLog(reclamantePrincipalRequest, "PROBLEMAS AL CREAR PERSONA (IPC 107)", creaPersona.Errores.FirstOrDefault());
                            reclamantePrincipalResult.StatusCode = StatusCodes.Status400BadRequest;
                            reclamantePrincipalResult.Errores.Add(creaPersona.Errores.FirstOrDefault());
                            return StatusCode(reclamantePrincipalResult.StatusCode, reclamantePrincipalResult);
                        }
                    }
                    if (participante.StatusCode != StatusCodes.Status200OK)
                    {
                        RegistraSiniestroLog(reclamantePrincipalRequest, "PROBLEMAS AL CONSULTAR PERSONA (IPC 109)", persona.Errores.FirstOrDefault());
                        reclamantePrincipalResult.StatusCode = StatusCodes.Status400BadRequest;
                        reclamantePrincipalResult.Errores.Add(persona.Errores.FirstOrDefault());
                        return StatusCode(reclamantePrincipalResult.StatusCode, reclamantePrincipalResult);
                    }

                    //REGISTRAR RECLAMANTE => 113
                    var reclamantePrincipal = RegistroReclamante(reclamantePrincipalRequest, persona, siniestro, participante);
                    if (reclamantePrincipal.StatusCode == StatusCodes.Status200OK)
                    {
                        //CONFIRMAR REQUEST => 114
                        ConfirmarRequest confirmarRequest = new ConfirmarRequest();
                        confirmarRequest.ClaimId = reclamantePrincipal.ClaimId;
                        confirmarRequest.ClaimNo = reclamantePrincipal.ClaimId.ToString();
                        confirmarRequest.RequestNo = reclamantePrincipal.RequestNo;

                        var confirmar = ConfirmarRequest(confirmarRequest);
                        if(confirmar.StatusCode == StatusCodes.Status200OK)
                        {
                            //RECLAMANTE
                            reclamantePrincipalResult.StatusCode = StatusCodes.Status201Created;
                            reclamantePrincipalResult.IdPersona = persona.RowSet[0].ManId.ToString();
                            reclamantePrincipalResult.NumeroSolicitud = Convert.ToInt32(reclamantePrincipal.RequestNo);

                            var reclamanteRequest = mapper.Map<ReclamanteRequest>(reclamantePrincipalRequest);
                            reclamanteRequest.NumeroPoliza = siniestro.PolicyReg.ToString();
                            reclamanteRequest.IdPersona = reclamantePrincipalResult.IdPersona;
                            reclamanteRequest.NumeroSolicitud = reclamantePrincipalResult.NumeroSolicitud;
                            reclamanteService.CrearReclamante(reclamanteRequest);

                            //PARTICIPANTE
                            var participanteRequest = mapper.Map<ParticipanteRequest>(reclamantePrincipalRequest.Reclamante.Participante);
                            participanteRequest.NumeroSiniestro = reclamantePrincipalRequest.NumeroSiniestro;
                            participanteRequest.NumeroInforme = reclamantePrincipalRequest.NumeroInforme;
                            participanteRequest.NumeroSolicitud = reclamantePrincipalResult.NumeroSolicitud;
                            participanteService.CrearParticipante(participanteRequest);

                            //COBERTURA
                            CoberturaSiniestradaRequest coberturaModel = new CoberturaSiniestradaRequest();
                            coberturaModel.NumeroSiniestro = reclamantePrincipalRequest.NumeroSiniestro;
                            coberturaModel.NumeroInforme = reclamantePrincipalRequest.NumeroInforme;
                            coberturaModel.NumeroSolicitud = reclamantePrincipalResult.NumeroSolicitud;
                            coberturaModel.RutReclamante = reclamantePrincipalRequest.Reclamante.Rut;
                            coberturaModel.Cobertura = reclamantePrincipalRequest.Cobertura;
                            coberturaModel.MontoLiquidado = reclamantePrincipalRequest.MontoProvision;
                            coberturaModel.MonedaLiquidacion = reclamantePrincipalRequest.MonedaProvision;
                            coberturaModel.FechaInformeLiquidador = DateTime.Now;
                            //var cobertura = coberturaSiniestradaService.ObtenerCoberturaSiniestrada(coberturaModel);
                            var  cobertura = coberturaSiniestradaService.CrearCoberturaSiniestrada(coberturaModel);
                        }
                        else
                        {
                            //log
                            RegistraSiniestroLog(reclamantePrincipalRequest, "PROBLEMAS AL CONFIRMAR REQUEST (IPC  114)", reclamantePrincipal.Errores.FirstOrDefault());
                            reclamantePrincipalResult.StatusCode = StatusCodes.Status400BadRequest;
                            reclamantePrincipalResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                        }
                    }
                    else
                    {
                        //log
                        RegistraSiniestroLog(reclamantePrincipalRequest, "PROBLEMAS AL registrar reclamante (IPC  113)",  reclamantePrincipal.Errores.FirstOrDefault());
                        reclamantePrincipalResult.StatusCode = StatusCodes.Status400BadRequest;
                        reclamantePrincipalResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                       // return reclamanteprincipalresult;
                    }
                }
                else
                {
                    //log
                    RegistraSiniestroLog(reclamantePrincipalRequest, "PROBLEMAS AL CONSULTAR SINIESTRO (IPC 115)", siniestro.Errores.FirstOrDefault());
                    reclamantePrincipalResult.StatusCode = StatusCodes.Status400BadRequest;
                    reclamantePrincipalResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                   //return reclamantePrincipalResult;
                }
            }
            catch (Exception e)
            {
                logger.LogError($"Error PolizaController.Get {e.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return StatusCode(reclamantePrincipalResult.StatusCode, reclamantePrincipalResult);
        }

        private void RegistraSiniestroLog(ReclamantePrincipalResquest reclamantePrincipalRequest, string status, string mensajeError)
        {
            SiniestroLogRequest siniestroLogRequest = new SiniestroLogRequest();
            siniestroLogRequest.Status = status;
            siniestroLogRequest.NumeroSiniestro = reclamantePrincipalRequest.NumeroSiniestro;
            siniestroLogRequest.NumeroInforme = reclamantePrincipalRequest.NumeroInforme;
            siniestroLogRequest.MensajeError = mensajeError;
            siniestroLogService.CrearSiniestroLog(siniestroLogRequest);
        }

        private ConsultaSiniestroResult ConsultaSiniestro(string claimNo)
        {
            ConsultaSiniestroResult consultaPolizaResult = new ConsultaSiniestroResult();
            var options = new RestClientOptions("https://localhost:7186/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/consultaSiniestro/v1/consultaSiniestro?claimNo={claimNo}", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaSiniestroResult>(request);

            if (response.IsSuccessStatusCode)
            {
                consultaPolizaResult = response.Data;
            }
            return consultaPolizaResult;
        }


        private ConsultaPersonaResult ConsultaPersona(string egn)
        {
            ConsultaPersonaResult consultaPersonaResult = new ConsultaPersonaResult();
            var options = new RestClientOptions("https://localhost:7186/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/persona/v1/persona?egn={egn}", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaPersonaResult>(request);

            if (response.IsSuccessStatusCode)
            {
                consultaPersonaResult = response.Data;
            }

            return consultaPersonaResult;
        }

        private CreaPersonaResult CreaPersona(ReclamantePrincipalResquest reclamantePrincipalResquest)
        {
            CreaPersonaResult creaPersonaResult = new CreaPersonaResult() { StatusCode = StatusCodes.Status400BadRequest };

            CreaPersonaRequest creaPersonaRequest = new CreaPersonaRequest();
            creaPersonaRequest.ManComp = 1;
            creaPersonaRequest.BirthDate = reclamantePrincipalResquest.Reclamante.FechaNacimiento.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"); ;
            creaPersonaRequest.Egn = reclamantePrincipalResquest.Reclamante.Rut;
            creaPersonaRequest.Gname = reclamantePrincipalResquest.Reclamante.PrimerNombre;
            creaPersonaRequest.Sname = reclamantePrincipalResquest.Reclamante.Apellidos;
            creaPersonaRequest.Fname = $"{reclamantePrincipalResquest.Reclamante.PrimerNombre} {reclamantePrincipalResquest.Reclamante.SegundoNombre} {reclamantePrincipalResquest.Reclamante.Apellidos}";
            creaPersonaRequest.Sex = 1;// reclamantePrincipalResquest.Reclamante.Genero; mapear
            creaPersonaRequest.Addresses = new List<Models.Request.CreaPersona.Address>();
            Models.Request.CreaPersona.Address address = new Models.Request.CreaPersona.Address();
            address.AddressType = "H";
            address.AddressAddress = reclamantePrincipalResquest.Reclamante.Direccion.Calle;
            address.BlockNumber = reclamantePrincipalResquest.Reclamante.Direccion.CasaDepto;
            address.City = reclamantePrincipalResquest.Reclamante.Direccion.Ciudad;
            address.CityCode = "";//MATCH
            address.Country = reclamantePrincipalResquest.Reclamante.Direccion.Pais;
            address.CountryCode = "";//match
            address.CountryState = "";
            address.EntranceNumber = "";//????
            address.InvoiceYn = "N";
            address.MailYn = "N";
            address.PostCode = "76000";
            address.PrimaryFlag = "Y";
            address.QuarterId = "253";
            address.RegionName = reclamantePrincipalResquest.Reclamante.Direccion.Region;
            address.StateName = "";
            address.StateRegion = "";
            address.StreetName = reclamantePrincipalResquest.Reclamante.Direccion.Calle;
            address.StreetNumber = reclamantePrincipalResquest.Reclamante.Direccion.Numeracion;
            creaPersonaRequest.Addresses.Add(address);

            Models.Request.CreaPersona.Contact contact = new Models.Request.CreaPersona.Contact();
            contact.ContactType = "EMAIL";
            contact.Details = reclamantePrincipalResquest.Reclamante.ViaContacto.FormaContacto;
            contact.PrimaryFlag = "N";
            creaPersonaRequest.Contacts = new List<Models.Request.CreaPersona.Contact>();
            creaPersonaRequest.Contacts.Add(contact);

            var client = new RestClient("https://localhost:7186/api/Persona/v1/persona");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(creaPersonaRequest);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                creaPersonaResult = JsonConvert.DeserializeObject<CreaPersonaResult>(response.Content);
            }


            return creaPersonaResult;
        }
        private CreaPersonaResult CreaPersonaParticipante(CharlesApi.Models.Request.ReclamantePrincipal.ParticipantePrincipal participante)
        {
            //107

            CreaPersonaResult creaPersonaResult = new CreaPersonaResult() { StatusCode = StatusCodes.Status400BadRequest };

            CreaPersonaRequest creaPersonaRequest = new CreaPersonaRequest();
            creaPersonaRequest.ManComp = 1;
            creaPersonaRequest.BirthDate = participante.FechaNacimiento;
            creaPersonaRequest.Egn = participante.Rut;
            creaPersonaRequest.Gname = participante.PrimerNombre;
            creaPersonaRequest.Sname = participante.Apellidos;
            creaPersonaRequest.Fname = $"{participante.PrimerNombre} {participante.SegundoNombre} {participante.Apellidos}";
            creaPersonaRequest.Sex = 3;// reclamante.Genero; mapear
            creaPersonaRequest.Addresses = new List<Models.Request.CreaPersona.Address>();
            Models.Request.CreaPersona.Address address = new Models.Request.CreaPersona.Address();
            address.AddressType = "H";
            address.AddressAddress = participante.Direccion.Calle;
            address.BlockNumber = participante.Direccion.CasaDepto;
            address.City = participante.Direccion.Ciudad;
            address.CityCode = "";//MATCH
            address.Country = participante.Direccion.Pais;
            address.CountryCode = "";//match
            address.CountryState = "";
            address.EntranceNumber = "";//????
            address.InvoiceYn = "N";
            address.MailYn = "N";
            address.PostCode = "76000";
            address.PrimaryFlag = "Y";
            address.QuarterId = "253";
            address.RegionName = participante.Direccion.Region;
            address.StateName = "";
            address.StateRegion = "";
            address.StreetName = participante.Direccion.Calle;
            address.StreetNumber = participante.Direccion.Numeracion;
            creaPersonaRequest.Addresses.Add(address);
            var client = new RestClient("https://localhost:7186/api/Persona/v1/persona");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(creaPersonaRequest);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                creaPersonaResult = JsonConvert.DeserializeObject<CreaPersonaResult>(response.Content);
            }

            return creaPersonaResult;
        }
        private ConfirmarResult ConfirmarRequest(ConfirmarRequest confirmarRequest)
        {
            ConfirmarResult confirmarResult = new ConfirmarResult() { StatusCode = StatusCodes.Status400BadRequest };

            var client = new RestClient("https://localhost:7186/api/Confirmar/v1/confirmar");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(confirmarRequest);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                confirmarResult = JsonConvert.DeserializeObject<ConfirmarResult>(response.Content);
            }


            return confirmarResult;
        }

        private RegistroReclamanteResult RegistroReclamante(ReclamantePrincipalResquest reclamantePrincipalResquest, ConsultaPersonaResult consultaPersonaResult, ConsultaSiniestroResult consultaSiniestroResult, ConsultaPersonaResult participante)
        {
            RegistroReclamanteResult registroReclamanteResult = new RegistroReclamanteResult() { StatusCode = StatusCodes.Status400BadRequest };

            RegistroReclamanteRequest registroReclamanteRequest = new RegistroReclamanteRequest();
            registroReclamanteRequest.ClaimNo = reclamantePrincipalResquest.NumeroSiniestro;// "20700001714";
            registroReclamanteRequest.Request = new CharlesApi.Models.Request.RegistroReclamante.Request();
            registroReclamanteRequest.Request.RequestDate = DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
            registroReclamanteRequest.Request.ClaimantId = consultaPersonaResult.RowSet[0].ManId;

            var tipoReclamante = tipoReclamanteRepository.ObtenerTipoReclamante(new CharlesApi.Request.TipoReclamante.TipoReclamanteRequest() { CodigoTipoReclamanteCharles = reclamantePrincipalResquest.Reclamante.CodigoTipoReclamante });
            registroReclamanteRequest.Request.ClaimantType = Convert.ToInt32(tipoReclamante.CodigoTipoReclamanteSura);// 2;
            registroReclamanteRequest.Request.InjuredObjects = new InjuredObjects();
            registroReclamanteRequest.Request.InjuredObjects.InjuredObject = new List<InjuredObject>();

            //participante 
            registroReclamanteRequest.Request.Participants = new Participants();
            registroReclamanteRequest.Request.Participants.Participant = new List<Participant>();
            Participant participant = new Participant();
            participant.ManId = participante.RowSet[0].ManId;
            participant.ParticipantRole = "BENEFICIAR";
            participant.Rank = "PRIM";
            participant.Notes = participante.RowSet[0].Name;
            registroReclamanteRequest.Request.Participants.Participant.Add(participant);

            //OBTENEMOS DATOS DE COBERTURA QUE NOS PROVEE LA POLIZA
            var poliza = ConsultaPoliza(consultaSiniestroResult.PolicyReg.ToString());

            if (poliza.StatusCode != StatusCodes.Status200OK)
            {
                registroReclamanteResult.Errores.Add(poliza.Errores.First());
                return registroReclamanteResult;
            }

            var covertura =  poliza.PolicyAnnexes[0].InsuredObjects[0].Covers.Where(c => c.CoverType == reclamantePrincipalResquest.Cobertura).FirstOrDefault();

            InjuredObject injured = new InjuredObject();
            injured.InsuredData = new InsuredData();
            injured.InsuredData.InsuredObjectId = covertura.InsuredObjId;// 3080182568;
            injured.InsuredData.GrcId = covertura.GrcId;// 120000460566;
            injured.InsuredData.CoverCode = covertura.CoverType;// "COB_022";
            injured.InsuredData.RiskType = "RSG_007";///SIEMPRE FIJO
            injured.InsuredData.AnnexId = 0;

            Documents documents = new Documents();
            documents.Document = new List<Models.Request.RegistroReclamante.Document>();
            Models.Request.RegistroReclamante.Document document = new Models.Request.RegistroReclamante.Document();
            document.DocId = "DOC_035";
            document.DocState = 2;
            documents.Document.Add(document);

            Models.Request.RegistroReclamante.Document document37 = new Models.Request.RegistroReclamante.Document();
            document37.DocId = "DOC_037";
            document37.DocState = 2;
            documents.Document.Add(document37);

            Models.Request.RegistroReclamante.Document document40 = new Models.Request.RegistroReclamante.Document();
            document40.DocId = "DOC_040";
            document40.DocState = 2;
            documents.Document.Add(document40);

            Models.Request.RegistroReclamante.Document document43 = new Models.Request.RegistroReclamante.Document();
            document43.DocId = "DOC_043";
            document43.DocState = 2;
            documents.Document.Add(document43);

            Models.Request.RegistroReclamante.Document document47 = new Models.Request.RegistroReclamante.Document();
            document47.DocId = "DOC_047";
            document47.DocState = 2;
            documents.Document.Add(document47);

            Models.Request.RegistroReclamante.Document document48 = new Models.Request.RegistroReclamante.Document();
            document48.DocId = "DOC_048";
            document48.DocState = 2;
            documents.Document.Add(document48);

            Models.Request.RegistroReclamante.Document document49 = new Models.Request.RegistroReclamante.Document();
            document49.DocId = "DOC_049";
            document49.DocState = 2;
            documents.Document.Add(document49);

            Models.Request.RegistroReclamante.Document document50 = new Models.Request.RegistroReclamante.Document();
            document50.DocId = "DOC_050";
            document50.DocState = 2;
            documents.Document.Add(document50);

            Models.Request.RegistroReclamante.Document document51 = new Models.Request.RegistroReclamante.Document();
            document51.DocId = "DOC_051";
            document51.DocState = 2;
            documents.Document.Add(document51);

            Models.Request.RegistroReclamante.Document document52 = new Models.Request.RegistroReclamante.Document();
            document52.DocId = "DOC_052";
            document52.DocState = 2;
            documents.Document.Add(document52);

            Models.Request.RegistroReclamante.Document document56 = new Models.Request.RegistroReclamante.Document();
            document56.DocId = "DOC_056";
            document56.DocState = 2;
            documents.Document.Add(document56);

            injured.InjuryCausedBy = "505";//siempre
            injured.InitialReserve = reclamantePrincipalResquest.MontoProvision;// 99;//variable, por la vista Charles Taylor (reserva Inicial)
            injured.Currency = "UF"; //siempre

            injured.Documents = documents;
            registroReclamanteRequest.Request.InjuredObjects.InjuredObject.Add(injured);

            var client = new RestClient("https://localhost:7186/api/RegistroReclamante/v1/registroReclamante");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(registroReclamanteRequest);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                registroReclamanteResult = JsonConvert.DeserializeObject<RegistroReclamanteResult>(response.Content);
            }


            return registroReclamanteResult;
        }




        private ConsultaPolizaResult ConsultaPoliza(string policyNo)
        {
            ConsultaPolizaResult consultaPolizaResult = new ConsultaPolizaResult();
            var options = new RestClientOptions("https://localhost:7186/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/poliza/v1/poliza?policyNo={policyNo}", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaPolizaResult>(request);

            if (response.IsSuccessStatusCode)
            {
                consultaPolizaResult = response.Data;
            }
            return consultaPolizaResult;
        }
    }
}
