using Cl.Sura.QuartzESoap.Models.Request.ListaEvento;
using Cl.Sura.QuartzESoap.Models.Request.RegistroDenuncio;
using Cl.Sura.QuartzESoap.Models.Request.RegistroReclamante;
using Cl.Sura.QuartzESoap.Models.Result.ListaEvento;
using Cl.Sura.QuartzESoap.Models.Result.RegistroDenuncio;
using Cl.Sura.QuartzESoap.Models.Result.RegistroReclamante;
using Cl.Sura.QuartzSoap.Models.Result.ConsultaPersona;
using Cl.Sura.QuartzSoap.Models.Result.ConsultaPoliza;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Quartz;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl.Sura.QuartzESoap.Jobs
{
    internal class NotificationJob : IJob
    {
        private readonly ILogger<NotificationJob> _logger;

        public NotificationJob(ILogger<NotificationJob> logger)
        {
            this._logger = logger;
        }



        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                //Consulta Datos Poliza (IPC 101)
                ConsultaPolizaResult consultaPolizaResult = ConsultaPoliza();
                //Existe Poliza ?
                if (consultaPolizaResult != null)
                {
                    //Consulta Personaas (IPC 109)
                    var persona = ConsultaPersona();
                    if (persona == null)
                    {
                        //Existe Persona ?  => CREAR PERSONA (IPC 107)
                    }
                    else
                    {    //HOMOLOGAR EVENTOS => Lista de Eventos (IPC 127)
                        var eventos = ListaEventos();

                        if (eventos != null)
                        {
                            //DECLARAR SINIESTRO  => REGISTRO DENUNCIO (IPC 110)
                            var denuuncio = RegistroDenunio();

                            if(denuuncio != null)
                            {  
                                //ASOCIA RECLAMANTE => REGISTRO RECLAMANTE (IPC 113)
                                var reclamante = RegistroReclamante();
                            }
                        }

                    }
                }


              

            }
            catch (Exception ex )
            {

                throw ex;
            }
           

            _logger.LogInformation($"Notificacion de JOB: Notify User at {DateTime.Now} and Tipo De JOB: {context.JobDetail.JobType}");
            return Task.CompletedTask;
        }


        public ConsultaPolizaResult ConsultaPoliza()
        {
            ConsultaPolizaResult consultaPolizaResult = new ConsultaPolizaResult();
            var options = new RestClientOptions("https://localhost:7186/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/poliza/v1/poliza", Method.Get);          
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaPolizaResult>(request);

            if(response.IsSuccessStatusCode) 
            {
                consultaPolizaResult = response.Data;
            }
            return consultaPolizaResult;
        }

        public ConsultaPersonaResult ConsultaPersona()
        {
            ConsultaPersonaResult consultaPersonaResult = new ConsultaPersonaResult();
            var options = new RestClientOptions("https://localhost:7186/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/persona/v1/persona", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaPersonaResult>(request);

            if (response.IsSuccessStatusCode)
            {
                consultaPersonaResult = response.Data;
            }

            return consultaPersonaResult;
        }

        public ListaEventoResult ListaEventos()
        {
            ListaEventoResult listaEventoResult = new ListaEventoResult();

            ListaEventoRequest listaEventoRequest = new ListaEventoRequest();
            listaEventoRequest.QueryId = "get-clm_event_type";
            listaEventoRequest.FilterCriteria = new FilterCriteria();
         //   listaEventoRequest.FilterCriteria.FilterCriterion = new FilterCriterion[2];

            FilterCriterion filterCriterion1 = new FilterCriterion();
            filterCriterion1.Value = "100000211610";
            filterCriterion1.Field = "policyId";
            //listaEventoRequest.FilterCriteria.FilterCriterion.Append(filterCriterion);
            FilterCriterion filterCriterion2 = new FilterCriterion();
            filterCriterion2.Value = "COB_022";
            filterCriterion2.Field = "cover_type";
            //listaEventoRequest.FilterCriteria.FilterCriterion.Append(filterCriterion);

            listaEventoRequest.FilterCriteria.FilterCriterion = new FilterCriterion[2] { filterCriterion1,filterCriterion2 };

            var client = new RestClient("https://localhost:7186/api/ListaEventos/v1/listaEventos");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
           
            var body = JsonConvert.SerializeObject(listaEventoRequest);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                listaEventoResult = JsonConvert.DeserializeObject<ListaEventoResult>(response.Content);
            }


            return listaEventoResult;
        }

        public RegistroDenuncioResult RegistroDenunio()
        {
            RegistroDenuncioResult registroDenuncioResult = new RegistroDenuncioResult();

            RegistroDenuncioRequest registroDenuncioRequest = new RegistroDenuncioRequest();
            registroDenuncioRequest.ClaimGroup = new ClaimGroup();
            registroDenuncioRequest.ClaimGroup.PolicyNo = "100036948";
            registroDenuncioRequest.ClaimGroup.CauseId = 1;
            registroDenuncioRequest.ClaimGroup.ClaimCategory = "DAMAGES";
            registroDenuncioRequest.ClaimGroup.EventType = 500;
            registroDenuncioRequest.ClaimGroup.EventDate = DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
            registroDenuncioRequest.ClaimGroup.EventDescription = "Relato del siniestro texto libre";
            registroDenuncioRequest.ClaimGroup.EventCountry = "CL";
            registroDenuncioRequest.ClaimGroup.EventPlace = "Lugar del siniestro texto libre";
            registroDenuncioRequest.ClaimGroup.ClaimComment = "Comentario del siniestro texto libre";

            var client = new RestClient("https://localhost:7186/api/RegistroDenuncio/v1/registroDenuncio");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(registroDenuncioRequest);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                registroDenuncioResult = JsonConvert.DeserializeObject<RegistroDenuncioResult>(response.Content);
            }


            return registroDenuncioResult;

        }

        public RegistroReclamanteResult RegistroReclamante()
        {
            RegistroReclamanteResult registroReclamanteResult = new RegistroReclamanteResult();
            RegistroReclamanteRequest  registroReclamanteRequest  = new RegistroReclamanteRequest();
            registroReclamanteRequest.ClaimNo = "20700001714";
            registroReclamanteRequest.Request = new Request();
            registroReclamanteRequest.Request.RequestDate = DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
            registroReclamanteRequest.Request.ClaimantId = 6000057318;
            registroReclamanteRequest.Request.ClaimantType = 2;
            registroReclamanteRequest.Request.InjuredObjects = new InjuredObjects();
            registroReclamanteRequest.Request.InjuredObjects.InjuredObject = new List<InjuredObject>();


            InjuredObject injured = new InjuredObject();
            injured.InsuredData = new InsuredData();
            injured.InsuredData.InsuredObjectId = 3080182568;
            injured.InsuredData.GrcId = 120000460566;
            injured.InsuredData.CoverCode = "COB_022";
            injured.InsuredData.RiskType = "RSG_007";
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
            injured.InitialReserve = 99;//variable, por la vista Charles Taylor (reserva Inicial)
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



    }
}
