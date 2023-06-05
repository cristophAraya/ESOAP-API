






/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*22-03-2023,Generador de Código, Clase Inicial 
*/



//using CharlesApi.Data.Base;
using AutoMapper;
using Charles.Models.Result.Confirmar;
using CharlesApi.ConfirmarEvaluacion;
using CharlesApi.Entities.Beneficiario;
using CharlesApi.Entities.CoberturaSiniestrada;
using CharlesApi.Entities.Participante;
using CharlesApi.Entities.Reclamante;
using CharlesApi.Entities.SiniestroLog;
using CharlesApi.Helpers.Base;
using CharlesApi.Models.Request.Confirmar;
using CharlesApi.Models.Request.ConfirmarCalculo;
using CharlesApi.Models.Request.ConfirmarLiquidacion;
using CharlesApi.Models.Request.ConfirmarPago;
using CharlesApi.Models.Request.CreaPersona;
using CharlesApi.Models.Request.DeclararSiniestro;
using CharlesApi.Models.Request.LiquidarSiniestro;
using CharlesApi.Models.Request.ReclamantePrincipal;
using CharlesApi.Models.Request.RegistroCalculo;
using CharlesApi.Models.Request.RegistroEvaluacion;
using CharlesApi.Models.Request.RegistroPago;
using CharlesApi.Models.Request.RegistroReclamante;
using CharlesApi.Models.Result.ConfirmarCalculo;
using CharlesApi.Models.Result.ConfirmarEvaluacion;
using CharlesApi.Models.Result.ConfirmarLiquidacion;
using CharlesApi.Models.Result.ConfirmarPago;
using CharlesApi.Models.Result.ConsultaPersona;
using CharlesApi.Models.Result.ConsultaPersonaCompleta;
using CharlesApi.Models.Result.ConsultaPoliza;
using CharlesApi.Models.Result.ConsultaSiniestro;
using CharlesApi.Models.Result.CreaPersona;
using CharlesApi.Models.Result.LiquidarSiniestro;
using CharlesApi.Models.Result.ReclamantePrincipal;
using CharlesApi.Models.Result.RegistroCalculo;
using CharlesApi.Models.Result.RegistroEvaluacion;
using CharlesApi.Models.Result.RegistroPago;
using CharlesApi.Models.Result.RegistroReclamante;
using CharlesApi.Repository.Beneficiario;
using CharlesApi.Repository.Cobertura;
using CharlesApi.Repository.CoberturaSiniestrada;
using CharlesApi.Repository.Participante;
using CharlesApi.Repository.Reclamante;
using CharlesApi.Repository.SiniestroLog;
using CharlesApi.Repository.TipoReclamante;
using CharlesApi.Request.CoberturaSiniestrada;
using CharlesApi.Request.Participante;
using CharlesApi.Request.Reclamante;
using Microsoft.Win32;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CharlesApi.Data.Liquidar
{
	/// <summary>
	/// Esta Clase Liquidar  permite gestionar reglas de negocio asociados a la entidad Liquidar
	/// </summary>
	public partial class LiquidarService : ILiquidarService
	{	
        private ISettingsConfig settings;
        private IReclamanteRepository reclamanteRepository;
        private IParticipanteRepository participanteRepository;
        private ICoberturaRepository coberturaRepository;
        private ICoberturaSiniestradaRepository coberturaSiniestradaRepository;
        private IBeneficiarioRepository beneficiarioRepository;
        private ISiniestroLogRepository siniestroLogRepository;
        private ITipoReclamanteRepository  tipoReclamanteRepository;
        private ILogger<LiquidarService> logger;
        private IMapper mapper;        
        public LiquidarService(ISettingsConfig settings,  IMapper mapper, IReclamanteRepository reclamanteRepository, ICoberturaSiniestradaRepository coberturaSiniestradaRepository, IBeneficiarioRepository beneficiarioRepository, ILogger<LiquidarService> logger, ISiniestroLogRepository siniestroLogRepository, ITipoReclamanteRepository tipoReclamanteRepository, IParticipanteRepository participanteRepository, ICoberturaRepository coberturaRepository)
        
        {
            this.logger = logger;
            this.settings = settings;
            this.mapper = mapper;
            this.reclamanteRepository = reclamanteRepository;
            this.coberturaSiniestradaRepository = coberturaSiniestradaRepository;
            this.beneficiarioRepository = beneficiarioRepository;
            this.siniestroLogRepository = siniestroLogRepository;
            this.tipoReclamanteRepository = tipoReclamanteRepository;
            this.participanteRepository = participanteRepository;
            this.coberturaRepository = coberturaRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void LiquidarSiniestroOLD(LiquidarSiniestroRequest liquidarSiniestroRequest)
        {
            try
            {                
                foreach (var unReclamante in liquidarSiniestroRequest.Reclamantes)
                {
                    //existen en la BD ?
                    var reclamanteModel = mapper.Map<ReclamanteModel>(unReclamante);
                    reclamanteModel.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                    reclamanteModel.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;

                    //reclamante por cobertura ?
                    foreach (var unaCobertura in unReclamante.CoberturasSiniestradas)
                    {
                        reclamanteModel.Cobertura = unaCobertura.Cobertura;
                        var  reclamante = reclamanteRepository.CrearReclamante(reclamanteModel);

                       // var reclamante = reclamanteRepository.ObtenerReclamante(reclamanteModel);
                        //if (reclamante == null)
                        //{
                        //    reclamante = reclamanteRepository.CrearReclamante(reclamanteModel);
                        //}

                        //COBERTURAS
                        var coberturaModel = mapper.Map<CoberturaSiniestradaModel>(unaCobertura);
                        coberturaModel.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                        coberturaModel.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;
                        coberturaModel.RutReclamante = unReclamante.Rut;
                        var cobertura = coberturaSiniestradaRepository.ObtenerCoberturaSiniestrada(coberturaModel);
                        if(cobertura == null)
                        {
                            cobertura = coberturaSiniestradaRepository.CrearCoberturaSiniestrada(coberturaModel);
                        }

                        //beneficiarios                        
                        //foreach (var unBeneficiario in unaCobertura.Beneficiarios)
                        //{
                        //    var beneficiarioModel = mapper.Map<BeneficiarioModel>(unBeneficiario);
                        //    beneficiarioModel.RutReclamante = unReclamante.Rut;
                        //    beneficiarioModel.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                        //    beneficiarioModel.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;
                        //    beneficiarioModel.Cobertura = unaCobertura.Cobertura;
                        //    var beneficiario = beneficiarioRepository.ObtenerBeneficiario(beneficiarioModel);
                        //    if(beneficiario == null)
                        //    {
                        //        beneficiario = beneficiarioRepository.CrearBeneficiario(beneficiarioModel);
                        //    }
                        //}
                    }         
                }

                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //public ConfirmarLiquidacionResult ConfirmarLiquidacion(ConfirmarLiquidacionRequest confirmarLiquidacionRequest)
        //{
        //    ConfirmarLiquidacionResult confirmarLiquidacionResult = new ConfirmarLiquidacionResult() { StatusCode = StatusCodes.Status400BadRequest };
        //    try
        //    {
        //        IList<ReclamanteModel> reclamantes = new List<ReclamanteModel>();
        //        IList<CoberturaSiniestradaModel> coberturas = new List<CoberturaSiniestradaModel>();
        //        IList<BeneficiarioModel> beneficiarios = new List<BeneficiarioModel>(); 

        //        ReclamanteModel model = new ReclamanteModel();
        //        model.NumeroInforme = confirmarLiquidacionRequest.NumeroInforme;
        //        model.NumeroSiniestro = confirmarLiquidacionRequest.NumeroSiniestro;
        //        //RECLAMANTES POR NumeroInforme
        //        reclamantes = reclamanteRepository.BuscarReclamantes(model);
        //        if (reclamantes != null && reclamantes.Count > 0)
        //        {
        //            //COBERTURAS =  NumeroSiniestro-RutReclamante+ NumeroInforme
        //            CoberturaSiniestradaModel cobertura = new CoberturaSiniestradaModel();
        //            cobertura.NumeroInforme = confirmarLiquidacionRequest.NumeroInforme;
        //            cobertura.NumeroSiniestro = confirmarLiquidacionRequest.NumeroSiniestro;
        //            coberturas = coberturaSiniestradaRepository.BuscarCoberturaSiniestradas(cobertura);
        //            if(coberturas != null && coberturas.Count > 0)
        //            {
        //                //BENEFICIARIOS =  NumeroSiniestro,RutReclamante,Cobertura+NumeroInforme
        //                BeneficiarioModel beneficiarioModel = new BeneficiarioModel();
        //                beneficiarioModel.NumeroInforme = confirmarLiquidacionRequest.NumeroInforme;
        //                beneficiarioModel.NumeroSiniestro = confirmarLiquidacionRequest.NumeroSiniestro;
        //                beneficiarios = beneficiarioRepository.BuscarBeneficiarios(beneficiarioModel);
        //            }
        //        }
        //        LiquidarSiniestroRequest liquidarSiniestroRequest = new LiquidarSiniestroRequest();
        //        liquidarSiniestroRequest.Reclamantes = new List<Models.Request.LiquidarSiniestro.Reclamante>();

        //        foreach (var item in reclamantes)
        //        {
        //            var unReclamante = mapper.Map<Models.Request.LiquidarSiniestro.Reclamante>(item);
        //            //Coberturas
        //            unReclamante.CoberturasSiniestradas = new List<CoberturasSiniestrada>();
        //            foreach (var unaCobertura in coberturas.Where(c => c.RutReclamante == unReclamante.Rut).ToList())
        //            {
        //                var cobertura = mapper.Map<CoberturasSiniestrada>(unaCobertura);
        //                var beneficiariosCobertura = beneficiarios.Where(c => c.Cobertura == cobertura.Cobertura).ToList();
        //                cobertura.Beneficiarios = mapper.Map<List<Models.Request.LiquidarSiniestro.Beneficiario>>(beneficiariosCobertura);
        //                unReclamante.CoberturasSiniestradas.Add(cobertura);
        //            }

        //            liquidarSiniestroRequest.Reclamantes.Add(unReclamante);
        //        }

        //        //CONFIRMAR TODO
        //        //Consulta Y recuperacion Siniestro
        //        //validar siniestro al 115
        //        var siniestro = ConsultaSiniestro(confirmarLiquidacionRequest.NumeroSiniestro);
        //        if (siniestro.StatusCode == StatusCodes.Status200OK)
        //        {
        //            //REGISTRO EVALUACION DEL SINIESTRO
        //            foreach (var unReclamante in liquidarSiniestroRequest.Reclamantes)
        //            {
        //                var persona = ConsultaPersona(unReclamante.Rut);
        //                if (persona.StatusCode == StatusCodes.Status200OK && persona.TotalRowCount == 0)
        //                {
        //                    var creaPersona = CreaPersona(unReclamante);//107
        //                    if (creaPersona.StatusCode == StatusCodes.Status200OK)
        //                    {
        //                        persona = ConsultaPersona(unReclamante.Rut); 
        //                    }
        //                    else 
        //                    {
        //                        RegistraSiniestroLog(confirmarLiquidacionRequest, "PROBLEMAS AL CREAR PERSONA (IPC 107)", creaPersona.Errores.FirstOrDefault());
        //                        confirmarLiquidacionResult.StatusCode = StatusCodes.Status400BadRequest;
        //                        confirmarLiquidacionResult.Errores.Add(creaPersona.Errores.FirstOrDefault());
        //                        return confirmarLiquidacionResult;
        //                    }
                            
        //                }
        //                if (persona.StatusCode != StatusCodes.Status200OK)
        //                {
        //                    RegistraSiniestroLog(confirmarLiquidacionRequest, "PROBLEMAS AL CONSULTAR PERSONA (IPC 109)", persona.Errores.FirstOrDefault());
        //                    confirmarLiquidacionResult.StatusCode = StatusCodes.Status400BadRequest;
        //                    confirmarLiquidacionResult.Errores.Add(persona.Errores.FirstOrDefault());
        //                    return confirmarLiquidacionResult;
        //                }

        //                //REGISTRAR RECLAMANTE => 113       
        //                foreach (var unaCobertura in unReclamante.CoberturasSiniestradas)
        //                {
        //                    if(unReclamante.NumeroSolicitud == "")
        //                    {
        //                        var reclamantePrincipal = RegistroReclamante(persona, siniestro, unaCobertura, unReclamante.CodigoTipoReclamante);

        //                        if (reclamantePrincipal.StatusCode == StatusCodes.Status200OK)
        //                        {
        //                            //CONFIRMAR REQUEST => 114
        //                            ConfirmarRequest confirmarRequest = new ConfirmarRequest();
        //                            confirmarRequest.ClaimId = reclamantePrincipal.ClaimId;
        //                            confirmarRequest.ClaimNo = reclamantePrincipal.ClaimId.ToString();
        //                            confirmarRequest.RequestNo = reclamantePrincipal.RequestNo;

        //                            var confirmar = ConfirmarRequest(confirmarRequest);
        //                            if (confirmar.StatusCode == StatusCodes.Status200OK)
        //                            {
        //                                //ACTUALIZAR AL RECLAMANTE => NUMEROSOLICITUD == REQUEST
        //                                var reclamanteModel = mapper.Map<ReclamanteModel>(unReclamante);
        //                                reclamanteModel.NumeroSolicitud = reclamantePrincipal.RequestNo.ToString();
        //                                reclamanteModel.IdPersona = persona.RowSet[0].ManId.ToString();
        //                                reclamanteModel.Cobertura = unaCobertura.Cobertura;
        //                                reclamanteModel.NumeroSiniestro = confirmarLiquidacionRequest.NumeroSiniestro;
        //                                reclamanteModel.NumeroInforme = confirmarLiquidacionRequest.NumeroInforme;
        //                                reclamanteRepository.ActualizarReclamante(reclamanteModel);

        //                                siniestro = ConsultaSiniestro(confirmarLiquidacionRequest.NumeroSiniestro);




        //                                // REGISTRAR EVALUACION => 120
        //                                var poliza = ConsultaPoliza(siniestro.PolicyReg.ToString());
        //                                var requestNo = (long)Convert.ToDouble(reclamantePrincipal.RequestNo);// confirmar.Requests.RequestsRequests[0].RequestNo;


        //                                // se saca del 115 con el claimId por el Request denteo de la lista clainObjects dentro de los claimrequest 
        //                                var claimObjectSeq = siniestro.ClaimRequests.Where(c => c.RequestId == requestNo).FirstOrDefault().ClaimObjects.Where(c => c.RequestId == requestNo).FirstOrDefault();

        //                                //  var claimObjectSeq = siniestro.ClaimRequests[0].ClaimObjects.Where(c => c.RequestId == requestNo).FirstOrDefault();

        //                                var registroEvaluacion = RegistroEvaluacion(siniestro, requestNo, claimObjectSeq.ClaimObjSeq, unaCobertura, persona);
        //                                if (registroEvaluacion.StatusCode == StatusCodes.Status200OK)
        //                                {
        //                                    //CONFIRMAR EVALUACION => 121
        //                                    var confirmarEvaluacion = ConfirmarEvaluacion(claimObjectSeq.ClaimObjSeq, registroEvaluacion);
        //                                    if (confirmarEvaluacion.StatusCode == StatusCodes.Status200OK)
        //                                    {
        //                                        //actualizamos la cobertura asegurada con request + datos de respuestas...

        //                                        //REGISTRAR CALCULO => 124
        //                                        var registroCalculo = RegistroCalculo(requestNo, claimObjectSeq.ClaimObjSeq, unaCobertura, siniestro, confirmarEvaluacion);
        //                                        if (registroCalculo.StatusCode == StatusCodes.Status200OK)
        //                                        {
        //                                            //CONFIRMAR CALCULO => 125
        //                                            var confirmacCalculo = ConfirmarCalculo(registroCalculo);
        //                                            if (confirmacCalculo.StatusCode == StatusCodes.Status200OK)
        //                                            {
        //                                                //SE REGISTRAN LOS BENEFICIARIOS PARA LA COBERTURA
        //                                                foreach (var beneficiario in unaCobertura.Beneficiarios)
        //                                                {
        //                                                    var personaBeneficiario = ConsultaPersonaCompleta(beneficiario.Rut);
        //                                                    if (personaBeneficiario.StatusCode != StatusCodes.Status200OK)
        //                                                    {
        //                                                        var creaPersona = CreaPersonaBeneficiario(beneficiario);
        //                                                        personaBeneficiario = ConsultaPersonaCompleta(beneficiario.Rut);
        //                                                    }

        //                                                    //REGISTRO PAGO => 122
        //                                                    var registroPago = RegistroPago(requestNo, confirmacCalculo.ClaimDscrSeq, personaBeneficiario, siniestro, beneficiario);
        //                                                    if (registroPago.StatusCode == StatusCodes.Status200OK)
        //                                                    {
        //                                                        var confirmaPago = ConfirmarPago(requestNo, registroPago, siniestro);

        //                                                        if(confirmaPago.StatusCode == StatusCodes.Status200OK)
        //                                                        {
        //                                                            //ActualizarBeneficiario
        //                                                            var beneficiarioModel = mapper.Map<BeneficiarioModel>(beneficiario);
        //                                                            beneficiarioModel.NumeroSiniestro = confirmarLiquidacionRequest.NumeroSiniestro;
        //                                                            beneficiarioModel.NumeroInforme = confirmarLiquidacionRequest.NumeroInforme;
        //                                                            beneficiarioModel.Cobertura = unaCobertura.Cobertura;
        //                                                            beneficiarioModel.RutReclamante = unReclamante.Rut;
        //                                                            beneficiarioModel.DocladId = confirmaPago.DocladId;
        //                                                            beneficiarioModel.DocladNo = confirmaPago.DocladNo;
        //                                                            beneficiarioModel.DocladState = confirmaPago.DocladState;
        //                                                            beneficiarioRepository.ActualizarBeneficiario(beneficiarioModel);
        //                                                        }
        //                                                    }
        //                                                }
        //                                            }
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {                               
        //                            RegistraSiniestroLog(confirmarLiquidacionRequest, "PROBLEMAS AL INGRESAR RECLAMANTE (IPC 113)", reclamantePrincipal.Errores.FirstOrDefault());
        //                            confirmarLiquidacionResult.StatusCode = StatusCodes.Status400BadRequest;
        //                            confirmarLiquidacionResult.Errores.Add(reclamantePrincipal.Errores.FirstOrDefault());
        //                            return confirmarLiquidacionResult;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            //log
        //            RegistraSiniestroLog(confirmarLiquidacionRequest, "PROBLEMAS AL CONSULTAR SINIESTRO (IPC 115)", siniestro.Errores.FirstOrDefault());
        //            confirmarLiquidacionResult.StatusCode = StatusCodes.Status400BadRequest;
        //            confirmarLiquidacionResult.Errores.Add(siniestro.Errores.FirstOrDefault());
        //            return confirmarLiquidacionResult;
        //        }

        //        confirmarLiquidacionResult.StatusCode = StatusCodes.Status201Created;


        //    }
        //    catch (Exception ex)
        //    {
        //        var mensaje = $"ERROR => {DateTime.Now.ToString()}, MENSAJE => {ex.Message}";
        //        logger.LogError(mensaje);
        //        throw ex;
        //    }

        //    return confirmarLiquidacionResult;
        //}

        public LiquidarSiniestroResult LiquidarSiniestro(LiquidarSiniestroRequest liquidarSiniestroRequest)
        {
            LiquidarSiniestroResult liquidarSiniestroResult = new LiquidarSiniestroResult();

            try
            {
                //CONFIRMAR TODO
                //Consulta Y recuperacion Siniestro
                //validar siniestro al 115

                logger.LogInformation($"ConsultaSiniestro => {DateTime.Now.ToString()}");
                var siniestro = ConsultaSiniestro(liquidarSiniestroRequest.NumeroSiniestro);
                if (siniestro.StatusCode == StatusCodes.Status200OK)
                {
                    //REGISTRO EVALUACION DEL SINIESTRO
                    foreach (var unReclamante in liquidarSiniestroRequest.Reclamantes)
                    {
                        //REGISTRAR RECLAMANTE x participante => 113       
                        foreach (var unaCobertura in unReclamante.CoberturasSiniestradas)
                        {
                            foreach (var unParticipante in unaCobertura.Participantes)
                            {
                                logger.LogInformation($"ConsultaPoliza => {DateTime.Now.ToString()}");
                                var poliza = ConsultaPoliza(siniestro.PolicyReg.ToString());

                                //DESDE ACA ES POR FACTURAS                            
                                foreach (var unaFactura in unParticipante.Facturas)
                                {
                                    //1-BUSCAMOS SI YA REGISTRAMOS RECLAMANTE EN BD
                                    var reclamanteModelBD = mapper.Map<ReclamanteModel>(unReclamante);
                                    reclamanteModelBD.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;
                                    reclamanteModelBD.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                                    reclamanteModelBD.Cobertura = unaCobertura.Cobertura;

                                    logger.LogInformation($"ObtenerReclamante => {DateTime.Now.ToString()}");
                                    reclamanteModelBD = reclamanteRepository.ObtenerReclamante(reclamanteModelBD);
                                    if (reclamanteModelBD == null)
                                    {
                                        logger.LogInformation($"ConsultaPersona => {DateTime.Now.ToString()}");
                                        var persona = ConsultaPersona(unReclamante.Rut);
                                        if (persona.StatusCode == StatusCodes.Status200OK && persona.TotalRowCount == 0)
                                        {
                                            var creaPersona = CreaPersona(unReclamante);//107
                                            if (creaPersona.StatusCode == StatusCodes.Status200OK)
                                            {
                                                persona = ConsultaPersona(unReclamante.Rut);
                                            }
                                            else
                                            {
                                                RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL CREAR PERSONA (IPC 107)", creaPersona.Errores.FirstOrDefault());
                                                liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                                liquidarSiniestroResult.Errores.Add(creaPersona.Errores.FirstOrDefault());
                                                return liquidarSiniestroResult;
                                            }

                                        }
                                        if (persona.StatusCode != StatusCodes.Status200OK)
                                        {
                                            RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL CONSULTAR PERSONA (IPC 109)", persona.Errores.FirstOrDefault());
                                            liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                            liquidarSiniestroResult.Errores.Add(persona.Errores.FirstOrDefault());
                                            return liquidarSiniestroResult;
                                        }
                                        var participante = ConsultaPersona(unParticipante.Rut);
                                        if (participante.StatusCode == StatusCodes.Status200OK && participante.TotalRowCount == 0)
                                        {
                                            var creaPersona = CreaPersonaParticipante(unParticipante);//107
                                            if (creaPersona.StatusCode == StatusCodes.Status200OK)
                                            {
                                                participante = ConsultaPersona(unParticipante.Rut);
                                            }
                                            else
                                            {
                                                //  RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL CREAR PERSONA (IPC 107)", creaPersona.Errores.FirstOrDefault());
                                                //  liquidarSiniestroRequest.StatusCode = StatusCodes.Status400BadRequest;
                                                //   liquidarSiniestroRequest.Errores.Add(creaPersona.Errores.FirstOrDefault());
                                                // return liquidarSiniestroRequest;
                                            }
                                        }
                                        if (participante.StatusCode != StatusCodes.Status200OK)
                                        {
                                            //    RegistraSiniestroLog(confirmarLiquidacionRequest, "PROBLEMAS AL CONSULTAR PERSONA (IPC 109)", persona.Errores.FirstOrDefault());
                                            //    confirmarLiquidacionResult.StatusCode = StatusCodes.Status400BadRequest;
                                            //    confirmarLiquidacionResult.Errores.Add(persona.Errores.FirstOrDefault());
                                            //    return confirmarLiquidacionResult;
                                        }

                                        //REGISTRAR RECLAMANTE + participante + cobertura => 113
                                        logger.LogInformation($"RegistroReclamante => {DateTime.Now.ToString()}");
                                        var reclamantePrincipal = RegistroReclamante(persona, siniestro, unaCobertura, unReclamante.CodigoTipoReclamante, participante);

                                        if (reclamantePrincipal.StatusCode == StatusCodes.Status200OK)
                                        {
                                            //CONFIRMAR REQUEST => 114
                                            ConfirmarRequest confirmarRequest = new ConfirmarRequest();
                                            confirmarRequest.ClaimId = reclamantePrincipal.ClaimId;
                                            confirmarRequest.ClaimNo = reclamantePrincipal.ClaimId.ToString();
                                            confirmarRequest.RequestNo = reclamantePrincipal.RequestNo;

                                            var confirmar = ConfirmarRequest(confirmarRequest);
                                            if (confirmar.StatusCode == StatusCodes.Status200OK)
                                            {
                                                //RECLAMANTE                        
                                                var reclamanteModel = mapper.Map<ReclamanteModel>(unReclamante);
                                                //reclamanteModel.NumeroPoliza = siniestro.PolicyReg.ToString();
                                                reclamanteModel.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                                                reclamanteModel.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;
                                                reclamanteModel.IdPersona = persona.RowSet[0].ManId.ToString(); ;
                                                reclamanteModel.NumeroSolicitud = Convert.ToInt32(reclamantePrincipal.RequestNo);
                                                reclamanteRepository.CrearReclamante(reclamanteModel);

                                                //PARTICIPANTE
                                                var participanteModel = mapper.Map<ParticipanteModel>(unParticipante);
                                                participanteModel.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                                                participanteModel.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;
                                                participanteModel.NumeroSolicitud = reclamanteModel.NumeroSolicitud;
                                                participanteRepository.CrearParticipante(participanteModel);

                                                //COBERTURA
                                                var coberturaModel = mapper.Map<CoberturaSiniestradaModel>(unaCobertura);
                                                coberturaModel.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                                                coberturaModel.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;
                                                coberturaModel.NumeroSolicitud = reclamanteModel.NumeroSolicitud;
                                                coberturaModel.RutReclamante = unReclamante.Rut;

                                                var cobertura = coberturaSiniestradaRepository.CrearCoberturaSiniestrada(coberturaModel);
                                                var personaReclamante = ConsultaPersona(unReclamante.Rut);
                                                var requestNo = (long)Convert.ToDouble(reclamantePrincipal.RequestNo);
                                                siniestro = ConsultaSiniestro(liquidarSiniestroRequest.NumeroSiniestro);

                                                // se saca del 115 con el claimId por el Request denteo de la lista clainObjects dentro de los claimrequest 
                                                var claimObjectSeq = siniestro.ClaimRequests.Where(c => c.RequestId == requestNo).FirstOrDefault().ClaimObjects.Where(c => c.RequestId == requestNo).FirstOrDefault();

                                                // REGISTRAR EVALUACION => 120
                                                var registroEvaluacion = RegistroEvaluacion(siniestro, requestNo, claimObjectSeq.ClaimObjSeq, unaCobertura, personaReclamante, unaFactura);
                                                if (registroEvaluacion.StatusCode == StatusCodes.Status200OK)
                                                {
                                                    //CONFIRMAR EVALUACION => 121
                                                    var confirmarEvaluacion = ConfirmarEvaluacion(claimObjectSeq.ClaimObjSeq, registroEvaluacion);
                                                    if (confirmarEvaluacion.StatusCode == StatusCodes.Status200OK)
                                                    {
                                                        //REGISTRAR CALCULO => 124
                                                        var registroCalculo = RegistroCalculo(requestNo, claimObjectSeq.ClaimObjSeq, unaCobertura, siniestro, confirmarEvaluacion, unaFactura);
                                                        if (registroCalculo.StatusCode == StatusCodes.Status200OK)
                                                        {
                                                            //CONFIRMAR CALCULO => 125
                                                            var confirmacCalculo = ConfirmarCalculo(registroCalculo);
                                                            if (confirmacCalculo.StatusCode == StatusCodes.Status200OK)
                                                            {
                                                                //REGISTRO PAGO => 122
                                                                var guardaBeneficiarios = GuardarBeneficiarios(unReclamante.Rut, unParticipante.Rut, unaCobertura.Cobertura, liquidarSiniestroRequest, Convert.ToInt32(requestNo), unaFactura.Beneficiarios);


                                                                var registroPago = RegistroPagoNew(requestNo, confirmacCalculo.ClaimDscrSeq, siniestro, unaFactura.Beneficiarios);
                                                                if (registroPago.StatusCode == StatusCodes.Status200OK)
                                                                {
                                                                    //CONFIRMAR  PAGO => 123
                                                                    var confirmaPago = ConfirmarPago(requestNo, registroPago, siniestro);
                                                                    if (confirmaPago.StatusCode == StatusCodes.Status200OK)
                                                                    {
                                                                        //ActualizarBeneficiario
                                                                        ActualizarBeneficiarios(unReclamante.Rut, unParticipante.Rut, unaCobertura.Cobertura, liquidarSiniestroRequest, Convert.ToInt32(requestNo), unaFactura.Beneficiarios, confirmaPago);
                                                                    }
                                                                    else
                                                                    {
                                                                        //LOG
                                                                        RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL CONFIRMAR  PAGO  (IPC 123)", siniestro.Errores.FirstOrDefault());
                                                                        liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                                                        liquidarSiniestroResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                                                                        return liquidarSiniestroResult;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    //LOG
                                                                    RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL REGISTRO PAGO  (IPC 122)", siniestro.Errores.FirstOrDefault());
                                                                    liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                                                    liquidarSiniestroResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                                                                    return liquidarSiniestroResult;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                //LOG
                                                                RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL CONFIRMAR CALCULO  (IPC 125)", siniestro.Errores.FirstOrDefault());
                                                                liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                                                liquidarSiniestroResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                                                                return liquidarSiniestroResult;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            //LOG
                                                            RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL REGISTRAR CALCULO  (IPC 124)", siniestro.Errores.FirstOrDefault());
                                                            liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                                            liquidarSiniestroResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                                                            return liquidarSiniestroResult;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        //LOG
                                                        RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL CONFIRMAR EVALUACION (IPC 121)", siniestro.Errores.FirstOrDefault());
                                                        liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                                        liquidarSiniestroResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                                                        return liquidarSiniestroResult;
                                                    }

                                                }
                                                else
                                                {
                                                    //LOG
                                                    RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL REGISTRAR EVALUACION (IPC 120)", siniestro.Errores.FirstOrDefault());
                                                    liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                                    liquidarSiniestroResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                                                    return liquidarSiniestroResult;
                                                }

                                            }
                                            else
                                            {            //log
                                                RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL CONFIRMAR REQUEST (IPC 114)", confirmar.Errores.FirstOrDefault());
                                                liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                                liquidarSiniestroResult.Errores.Add(reclamantePrincipal.Errores.FirstOrDefault());
                                                return liquidarSiniestroResult;
                                            }
                                        }
                                        else
                                        {
                                            //log
                                            RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL REGISTRAR RECLAMANTE (IPC 113)", reclamantePrincipal.Errores.FirstOrDefault());
                                            liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                                            liquidarSiniestroResult.Errores.Add(reclamantePrincipal.Errores.FirstOrDefault());
                                            return liquidarSiniestroResult;
                                        }
                                    }

                      
                                }
                            }
                        }
                    }
                }
                else
                {
                    //log
                    RegistraSiniestroLog(liquidarSiniestroRequest, "PROBLEMAS AL CONSULTAR SINIESTRO (IPC 115)", siniestro.Errores.FirstOrDefault());
                    liquidarSiniestroResult.StatusCode = StatusCodes.Status400BadRequest;
                    liquidarSiniestroResult.Errores.Add(siniestro.Errores.FirstOrDefault());
                    return liquidarSiniestroResult;
                }

                liquidarSiniestroResult.StatusCode = StatusCodes.Status201Created;

            }
            catch (Exception ex)
            {
                var mensaje = $"ERROR => {DateTime.Now.ToString()}, MENSAJE => {ex.Message}";
                logger.LogError(mensaje);
                throw ex;
            }

            return liquidarSiniestroResult;
        }
        private void RegistraSiniestroLog(LiquidarSiniestroRequest confirmarLiquidacionRequest, string status, string mensajeError)
        {
            SiniestroLogModel siniestroLogRequest = new SiniestroLogModel();
            siniestroLogRequest.Status = status;
            siniestroLogRequest.NumeroSiniestro = confirmarLiquidacionRequest.NumeroSiniestro;
            siniestroLogRequest.NumeroInforme = confirmarLiquidacionRequest.NumeroInforme;
            siniestroLogRequest.MensajeError = mensajeError;
            siniestroLogRepository.CrearSiniestroLog(siniestroLogRequest);
        }


        private bool GuardarBeneficiarios(string rutReclamante, string rutParticipate, string cobertura,LiquidarSiniestroRequest liquidarSiniestroRequest, int numeroSolicitud ,List<CharlesApi.Models.Request.LiquidarSiniestro.Beneficiario> beneficiarios)
        {
            bool respuesta = false;
            try
            {
                //beneficiarios                        
                foreach (var unBeneficiario in beneficiarios)
                {
                    var beneficiarioModel = mapper.Map<BeneficiarioModel>(unBeneficiario);
                    beneficiarioModel.RutReclamante = rutReclamante;
                    beneficiarioModel.RutParticipante = rutParticipate;
                    beneficiarioModel.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                    beneficiarioModel.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;
                    beneficiarioModel.NumeroSolicitud = numeroSolicitud;
                    beneficiarioModel.Cobertura = cobertura;
                    var beneficiario = beneficiarioRepository.CrearBeneficiario(beneficiarioModel);             
                }

            }
            catch (Exception)
            {

                throw;
            }

            return respuesta;
        }

        private bool ActualizarBeneficiarios(string rutReclamante, string rutParticipate, string cobertura, LiquidarSiniestroRequest liquidarSiniestroRequest, int numeroSolicitud, List<CharlesApi.Models.Request.LiquidarSiniestro.Beneficiario> beneficiarios, ConfirmarPagoResult confirmarPagoResult)
        {
            bool respuesta = false;
            try
            {
                //beneficiarios                        
                foreach (var unBeneficiario in beneficiarios)
                {
                    var beneficiarioModel = mapper.Map<BeneficiarioModel>(unBeneficiario);
                    beneficiarioModel.NumeroSiniestro = liquidarSiniestroRequest.NumeroSiniestro;
                    beneficiarioModel.NumeroInforme = liquidarSiniestroRequest.NumeroInforme;
                    beneficiarioModel.Cobertura = cobertura;
                    beneficiarioModel.RutReclamante = rutReclamante;
                    beneficiarioModel.RutParticipante = rutParticipate;
                    beneficiarioModel.DocladId = confirmarPagoResult.DocladId;
                    beneficiarioModel.DocladNo = confirmarPagoResult.DocladNo;
                    beneficiarioModel.DocladState = confirmarPagoResult.DocladState;
                    beneficiarioRepository.ActualizarBeneficiario(beneficiarioModel);
                }

            }
            catch (Exception)
            {

                throw;
            }

            return respuesta;
        }


        private RegistroEvaluacionResult RegistroEvaluacion(ConsultaSiniestroResult consultaSiniestroResult, long requestNo, long claimObjSeq, Models.Request.LiquidarSiniestro.CoberturasSiniestrada coberturasSiniestrada, ConsultaPersonaResult consultaPersonaResult, Factura factura)
        {
            // REGISTRAR EVALUACION => 120
            RegistroEvaluacionResult registroEvaluacionResult = new RegistroEvaluacionResult() { StatusCode = StatusCodes.Status204NoContent };

            try
            {
                RegistroEvaluacionRequest registroEvaluacionRequest = new RegistroEvaluacionRequest();
                registroEvaluacionRequest.ClaimId = consultaSiniestroResult.ClaimId;
                registroEvaluacionRequest.RequestNo = requestNo;

                //"claimObjSeq": 2080002080, se saca del 115 con el claimId por el Request denteo de la lista clainObjects dentro de los claimrequest               
                registroEvaluacionRequest.ClaimObjectSeq = claimObjSeq;


              //  var fecha = coberturasSiniestrada.FechaInformeLiquidador.Split(' ', ':');
               // var fechaConvertida = new DateTime(Convert.ToInt32(fecha[0].Substring(0, 4)), Convert.ToInt32(fecha[0].Substring(4, 2)), Convert.ToInt32(fecha[0].Substring(6, 2)));

                registroEvaluacionRequest.InspectDate = coberturasSiniestrada.FechaInformeLiquidador.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
                registroEvaluacionRequest.ManId = consultaPersonaResult.RowSet[0].ManId;
                registroEvaluacionRequest.ExpertSum = factura.ValorFactura;
                registroEvaluacionRequest.ExpertSumCurrency = factura.Moneda;
                registroEvaluacionRequest.LossSize = 1;
                registroEvaluacionRequest.ActualValue = factura.ValorFactura;
                registroEvaluacionRequest.AvCurrency = factura.Moneda;
                registroEvaluacionRequest.InvoiceNo = factura.NumeroFactura.ToString();

                var client = new RestClient($"{settings.UrlBaseEsoapApi}api/registroEvaluacion/v1/registroEvaluacion");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");

                var body = JsonConvert.SerializeObject(registroEvaluacionRequest);
                request.AddStringBody(body, DataFormat.Json);
                
                var  response = client.Execute<RegistroEvaluacionResult>(request);
                registroEvaluacionResult = response.Data;
                //if (response.IsSuccessStatusCode)
                //{
                //    liquidarSiniestroResult = JsonConvert.DeserializeObject<RegistroEvaluacionResult>(response.Content);
                //}

            }
            catch (Exception)
            {
                throw;
            }

            return registroEvaluacionResult;
        }


        private RegistroCalculoResult RegistroCalculo(long requestNo, long claimObjSeq, Models.Request.LiquidarSiniestro.CoberturasSiniestrada coberturasSiniestrada, ConsultaSiniestroResult consultaSiniestroResult, ConfirmarEvaluacionResult confirmarEvaluacionResult, Factura factura)
        {
            //REGISTRAR CALCULO => 124
            RegistroCalculoResult registroCalculoResutl = new RegistroCalculoResult() { StatusCode = StatusCodes.Status204NoContent };

            try
            {
                RegistroCalculoRequest registroCalculoRequest = new RegistroCalculoRequest();
                registroCalculoRequest.ClaimId = consultaSiniestroResult.ClaimId;
                registroCalculoRequest.RequestNo = requestNo;
                registroCalculoRequest.ClaimObjSeq = claimObjSeq;
                registroCalculoRequest.InspectNum = confirmarEvaluacionResult.InspectNum;
                registroCalculoRequest.RequestedAmount = factura.ValorFactura;
                registroCalculoRequest.RequestedCurrency = factura.Moneda;

                var client = new RestClient($"{settings.UrlBaseEsoapApi}api/registroCalculo/v1/registroCalculo");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");

                var body = JsonConvert.SerializeObject(registroCalculoRequest);
                request.AddStringBody(body, DataFormat.Json);

                var response = client.Execute<RegistroCalculoResult>(request);
                registroCalculoResutl = response.Data;
                //if (response.IsSuccessStatusCode)
                //{
                //    registroCalculoResutl = JsonConvert.DeserializeObject<RegistroCalculoResult>(response.Content);
                //}
            }
            catch (Exception)
            {

                throw;
            }

            return registroCalculoResutl;
        }

        private RegistroPagoResult RegistroPagoNew(long requestNo, long claimDscrSeq, ConsultaSiniestroResult consultaSiniestroResult, List<CharlesApi.Models.Request.LiquidarSiniestro.Beneficiario>  beneficiarios)
        {
            //REGISTRO PAGO => 122
            RegistroPagoResult registroPago = new RegistroPagoResult() { StatusCode = StatusCodes.Status204NoContent };

            try
            {
                RegistroPagoRequest registroPagoRequest = new RegistroPagoRequest();
                registroPagoRequest.ClaimId = consultaSiniestroResult.ClaimId;
                registroPagoRequest.RequestNo = requestNo;
                registroPagoRequest.Beneficiaries = new Beneficiaries();
                registroPagoRequest.Beneficiaries.Beneficiary = new List<Beneficiary>();

                //RECORREMOS BENEFICIARIOS, CONSULTAMOS SI EXISTE; DE LO CONTRARIO SE CREA

                foreach (var unBeneficiario in beneficiarios)
                {
                    var personaBeneficiario = ConsultaPersonaCompleta(unBeneficiario.Rut);
                    if (personaBeneficiario.StatusCode != StatusCodes.Status200OK)
                    {
                        var creaPersona = CreaPersonaBeneficiario(unBeneficiario);
                        personaBeneficiario = ConsultaPersonaCompleta(unBeneficiario.Rut);
                    }

                    Beneficiary beneficiary = new Beneficiary();
                    beneficiary.Pid = personaBeneficiario.Egn.ToString();
                    beneficiary.PaymentWay = "4"; // ES FIJO

                    if (unBeneficiario.Porcentaje > 0)
                    {
                        beneficiary.BenefShare = unBeneficiario.Porcentaje;
                    }

                    beneficiary.Calculations = new Calculations();
                    beneficiary.Calculations.Calculation = new List<Calculation>();
                    Calculation calculation = new Calculation();
                    calculation.ClaimDscrSeq = claimDscrSeq;
                    beneficiary.Calculations.Calculation.Add(calculation);

                    //banco
                    beneficiary.BankAccount = new Models.Request.RegistroPago.BankAccount();
                    Models.Request.RegistroPago.BankAccount bankAccount = new Models.Request.RegistroPago.BankAccount();
                    //"bankAccount": {			=> bankAccounts se sacan del 108 de la persona , en base el rut( "pid":)
                    //    "bankPid": "970300007",  =>   "bankPid": {
                    //        "egn": "970300007",
                    //    "accountNo": "0987654321",  =>    "accountNum": 
                    //    "bankAccId": 6270007153,   =>  "bankAccId"
                    //    "bankName":"Banco del Estado"
                    //}
                    bankAccount.BankPid = personaBeneficiario.BankAccounts[0].PBanks.BankPid.Egn;
                    bankAccount.AccountNo = personaBeneficiario.BankAccounts[0].AccountNum;
                    bankAccount.BankAccId = personaBeneficiario.BankAccounts[0].BankAccId;
                    bankAccount.BankName = personaBeneficiario.BankAccounts[0].PBanks.SwiftCode;
                    beneficiary.BankAccount = bankAccount;

                    registroPagoRequest.Beneficiaries.Beneficiary.Add(beneficiary);
                }

                var client = new RestClient($"{settings.UrlBaseEsoapApi}api/RegistroPago/v1/registroPago");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");

                var body = JsonConvert.SerializeObject(registroPagoRequest);
                request.AddStringBody(body, DataFormat.Json);

                var response = client.Execute<RegistroPagoResult>(request);
                registroPago = response.Data;
                //if (response.IsSuccessStatusCode)
                //{
                //    registroPago = JsonConvert.DeserializeObject<RegistroPagoResult>(response.Content);
                //}
            }
            catch (Exception)
            {
                throw;
            }

            return registroPago;
        }


        private RegistroPagoResult RegistroPago(long requestNo, long claimDscrSeq, ConsultaPersonaCompletaResult beneficiario, ConsultaSiniestroResult consultaSiniestroResult, CharlesApi.Models.Request.LiquidarSiniestro.Beneficiario beneficiarioModel)
        {
            RegistroPagoResult registroPago = new RegistroPagoResult() { StatusCode = StatusCodes.Status204NoContent };

            RegistroPagoRequest registroPagoRequest = new RegistroPagoRequest();

            try
            {
                registroPagoRequest.ClaimId = consultaSiniestroResult.ClaimId;
                registroPagoRequest.RequestNo = requestNo;
                registroPagoRequest.Beneficiaries = new Beneficiaries();
                registroPagoRequest.Beneficiaries.Beneficiary = new List<Beneficiary>();
                Beneficiary beneficiary = new Beneficiary();
                beneficiary.Pid = beneficiario.Egn.ToString();
                beneficiary.PaymentWay = "4"; // ES FIJO

                if (beneficiarioModel.Porcentaje > 0)
                {
                    beneficiary.BenefShare = beneficiarioModel.Porcentaje;
                }


                beneficiary.Calculations = new Calculations();
                beneficiary.Calculations.Calculation = new List<Calculation>();
                Calculation calculation = new Calculation();
                calculation.ClaimDscrSeq = claimDscrSeq;
                beneficiary.Calculations.Calculation.Add(calculation);

                //banco
                beneficiary.BankAccount = new Models.Request.RegistroPago.BankAccount();
                Models.Request.RegistroPago.BankAccount bankAccount = new Models.Request.RegistroPago.BankAccount();



                //"bankAccount": {			=> bankAccounts se sacan del 108 de la persona , en base el rut( "pid":)
                //    "bankPid": "970300007",  =>   "bankPid": {
                //        "egn": "970300007",
                //    "accountNo": "0987654321",  =>    "accountNum": 
                //    "bankAccId": 6270007153,   =>  "bankAccId"
                //    "bankName":"Banco del Estado"
                //}

                bankAccount.BankPid = beneficiario.BankAccounts[0].PBanks.BankPid.Egn;
                bankAccount.AccountNo = beneficiario.BankAccounts[0].AccountNum;
                bankAccount.BankAccId = beneficiario.BankAccounts[0].BankAccId;
                bankAccount.BankName = beneficiario.BankAccounts[0].PBanks.SwiftCode;
                beneficiary.BankAccount = bankAccount;

                registroPagoRequest.Beneficiaries.Beneficiary.Add(beneficiary);


                var client = new RestClient($"{settings.UrlBaseEsoapApi}api/RegistroPago/v1/registroPago");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");

                var body = JsonConvert.SerializeObject(registroPagoRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    registroPago = JsonConvert.DeserializeObject<RegistroPagoResult>(response.Content);
                }

            }
            catch (Exception)
            {

                throw;
            }

            return registroPago;
        }

        private ConsultaSiniestroResult ConsultaSiniestro(string claimNo)
        {
            //115
            ConsultaSiniestroResult consultaPolizaResult = new ConsultaSiniestroResult();
            var options = new RestClientOptions(settings.UrlBaseEsoapApi)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/consultaSiniestro/v1/consultaSiniestro?claimNo={claimNo}", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaSiniestroResult>(request);
            consultaPolizaResult = response.Data;

            logger.LogInformation($"ConsultaSiniestro => {DateTime.Now.ToString()}, JSON => {JsonConvert.SerializeObject(consultaPolizaResult)}");

            //if (response.IsSuccessStatusCode)
            //{
            //    consultaPolizaResult = response.Data;
            //}

            return consultaPolizaResult;
        }


        private ConsultaPersonaResult ConsultaPersona(string egn)
        {
            //109
            ConsultaPersonaResult consultaPersonaResult = new ConsultaPersonaResult();
            var options = new RestClientOptions(settings.UrlBaseEsoapApi)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/persona/v1/persona?egn={egn}", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaPersonaResult>(request);
            consultaPersonaResult = response.Data;

            logger.LogInformation($"ConsultaPersona => {DateTime.Now.ToString()}, JSON => {JsonConvert.SerializeObject(consultaPersonaResult)}");

            //if (response.IsSuccessStatusCode)
            //{
            //    consultaPersonaResult = response.Data;
            //}

            return consultaPersonaResult;
        }

        private ConsultaPersonaCompletaResult ConsultaPersonaCompleta(string egn)
        {
            ConsultaPersonaCompletaResult consultaPersonaResult = new ConsultaPersonaCompletaResult();
            var options = new RestClientOptions(settings.UrlBaseEsoapApi)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/persona/v1/consultaPersonaCompleta?egn={egn}", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaPersonaCompletaResult>(request);
            consultaPersonaResult = response.Data;
            //if (response.IsSuccessStatusCode)
            //{
            //    consultaPersonaResult = response.Data;
            //}

            return consultaPersonaResult;
        }

        private CreaPersonaResult CreaPersona(CharlesApi.Models.Request.LiquidarSiniestro.Reclamante reclamante)
        {
            //107

            CreaPersonaResult creaPersonaResult = new CreaPersonaResult() { StatusCode = StatusCodes.Status400BadRequest };
            var body = string.Empty;

            CreaPersonaRequest creaPersonaRequest = new CreaPersonaRequest();
            CreaPersonaEmpresaRequest creaPersonaEmpresaRequest = new CreaPersonaEmpresaRequest();
            creaPersonaRequest.ManComp = 1;// PERSONA NATURAL 
            creaPersonaRequest.Egn = reclamante.Rut;

            var rutNumerico = Convert.ToInt32(reclamante.Rut.Remove(reclamante.Rut.Length - 1));
            if (rutNumerico > 50000000)
            {

                creaPersonaEmpresaRequest.Egn = reclamante.Rut;
                creaPersonaEmpresaRequest.ManComp = 2;// PERSONA Juridica 
                creaPersonaEmpresaRequest.Name = reclamante.PrimerNombre;
                body = JsonConvert.SerializeObject(creaPersonaEmpresaRequest);
            }
            else
            {
                creaPersonaRequest.BirthDate = reclamante.FechaNacimiento.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"); ;              
                creaPersonaRequest.Gname = reclamante.PrimerNombre;
                creaPersonaRequest.Sname = reclamante.Apellidos;
                creaPersonaRequest.Fname = $"{reclamante.PrimerNombre} {reclamante.SegundoNombre} {reclamante.Apellidos}";
                creaPersonaRequest.Sex = 3;// reclamante.Genero; mapear
                creaPersonaRequest.Addresses = new List<Models.Request.CreaPersona.Address>();
                Models.Request.CreaPersona.Address address = new Models.Request.CreaPersona.Address();
                address.AddressType = "H";
                address.AddressAddress = reclamante.Direccion.Calle;
                address.BlockNumber = reclamante.Direccion.CasaDepto;
                address.City = reclamante.Direccion.Ciudad;
                address.CityCode = "";//MATCH
                address.Country = reclamante.Direccion.Pais;
                address.CountryCode = "";//match
                address.CountryState = "";
                address.EntranceNumber = "";//????
                address.InvoiceYn = "N";
                address.MailYn = "N";
                address.PostCode = "76000";
                address.PrimaryFlag = "Y";
                address.QuarterId = "253";
                address.RegionName = reclamante.Direccion.Region;
                address.StateName = "";
                address.StateRegion = "";
                address.StreetName = reclamante.Direccion.Calle;
                address.StreetNumber = reclamante.Direccion.Numeracion;
                creaPersonaRequest.Addresses.Add(address);

                if (reclamante.ViaContacto != null && reclamante.ViaContacto.InformacionContacto != string.Empty)
                {
                    Models.Request.CreaPersona.Contact contact = new Models.Request.CreaPersona.Contact();
                    contact.ContactType = "EMAIL";
                    contact.Details = reclamante.ViaContacto.InformacionContacto;
                    contact.PrimaryFlag = "N";
                    creaPersonaRequest.Contacts = new List<Models.Request.CreaPersona.Contact>();
                    creaPersonaRequest.Contacts.Add(contact);
                }

                body = JsonConvert.SerializeObject(creaPersonaRequest);
            }

            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/Persona/v1/persona");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

          
            request.AddStringBody(body, DataFormat.Json);
            var response = client.Execute<CreaPersonaResult>(request);
            creaPersonaResult = response.Data;

            //if (response.IsSuccessStatusCode)
            //{
            //    creaPersonaResult = JsonConvert.DeserializeObject<CreaPersonaResult>(response.Content);
            //}

            return creaPersonaResult;
        }

        private CreaPersonaResult CreaPersonaParticipante(CharlesApi.Models.Request.LiquidarSiniestro.Participante participante)
        {
            //107

            CreaPersonaResult creaPersonaResult = new CreaPersonaResult() { StatusCode = StatusCodes.Status400BadRequest };

            CreaPersonaRequest creaPersonaRequest = new CreaPersonaRequest();
            creaPersonaRequest.ManComp = 1;// PERSONA NATURAL 
            creaPersonaRequest.Egn = participante.Rut;

            var rutNumerico = Convert.ToInt32(participante.Rut.Remove(participante.Rut.Length - 1));
            if (rutNumerico > 50000000)
            {
                creaPersonaRequest.ManComp = 2;// PERSONA Juridica 
                creaPersonaRequest.Name = participante.PrimerNombre;
            }
            else
            {
                creaPersonaRequest.BirthDate = participante.FechaNacimiento.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"); ;
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

                //if (participante. != null && participante.ViaContacto.InformacionContacto != string.Empty)
                //{
                //    Models.Request.CreaPersona.Contact contact = new Models.Request.CreaPersona.Contact();
                //    contact.ContactType = "EMAIL";
                //    contact.Details = reclamante.ViaContacto.InformacionContacto;
                //    contact.PrimaryFlag = "N";
                //    creaPersonaRequest.Contacts = new List<Models.Request.CreaPersona.Contact>();
                //    creaPersonaRequest.Contacts.Add(contact);
                //}
            }

            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/Persona/v1/persona");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(creaPersonaRequest);
            request.AddStringBody(body, DataFormat.Json);
            var response = client.Execute<CreaPersonaResult>(request);
            creaPersonaResult = response.Data;

            //if (response.IsSuccessStatusCode)
            //{
            //    creaPersonaResult = JsonConvert.DeserializeObject<CreaPersonaResult>(response.Content);
            //}

            return creaPersonaResult;
        }

        private CreaPersonaResult CreaPersonaBeneficiario(CharlesApi.Models.Request.LiquidarSiniestro.Beneficiario beneficiario)
        {
            CreaPersonaResult creaPersonaResult = new CreaPersonaResult() { StatusCode = StatusCodes.Status400BadRequest };

            CreaPersonaRequest creaPersonaRequest = new CreaPersonaRequest();
            creaPersonaRequest.ManComp = 1;
            creaPersonaRequest.Egn = beneficiario.Rut;

            var rutNumerico = Convert.ToInt32(beneficiario.Rut.Remove(beneficiario.Rut.Length - 1));
            if (rutNumerico > 50000000)
            {
                creaPersonaRequest.ManComp = 2;// PERSONA Juridica 
                creaPersonaRequest.Name = beneficiario.PrimerNombre;
            }
            else
            {
                creaPersonaRequest.BirthDate = beneficiario.FechaNacimiento.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"); ;
                creaPersonaRequest.Egn = beneficiario.Rut;
                creaPersonaRequest.Gname = beneficiario.PrimerNombre;
                creaPersonaRequest.Sname = beneficiario.Apellidos;
                creaPersonaRequest.Fname = $"{beneficiario.PrimerNombre} {beneficiario.SegundoNombre} {beneficiario.Apellidos}";
                creaPersonaRequest.Sex = 3;// reclamante.Genero; mapear
            }


            //ADDRESSES
            creaPersonaRequest.Addresses = new List<Models.Request.CreaPersona.Address>();
            Models.Request.CreaPersona.Address address = new Models.Request.CreaPersona.Address();
            address.AddressType = "H";
            address.AddressAddress = beneficiario.Direccion.Calle;
            address.BlockNumber = beneficiario.Direccion.CasaDepto;
            address.City = beneficiario.Direccion.Ciudad;
            address.CityCode = "";//MATCH
            address.Country = beneficiario.Direccion.Pais;
            address.CountryCode = "";//match
            address.CountryState = "";
            address.EntranceNumber = "";//????
            address.InvoiceYn = "N";
            address.MailYn = "N";
            address.PostCode = "76000";
            address.PrimaryFlag = "Y";
            address.QuarterId = "253";
            address.RegionName = beneficiario.Direccion.Region;
            address.StateName = "";
            address.StateRegion = "";
            address.StreetName = beneficiario.Direccion.Calle;
            address.StreetNumber = beneficiario.Direccion.Numeracion;
            creaPersonaRequest.Addresses.Add(address);

            //CONTACT
            Models.Request.CreaPersona.Contact contact = new Models.Request.CreaPersona.Contact();
            contact.ContactType = "EMAIL";
            contact.Details = beneficiario.ViaContacto.FormaContacto;
            contact.PrimaryFlag = "N";
            creaPersonaRequest.Contacts = new List<Models.Request.CreaPersona.Contact>();
            creaPersonaRequest.Contacts.Add(contact);

            //BANK ACCOUNT
            Models.Request.CreaPersona.BankAccount bankAccount = new Models.Request.CreaPersona.BankAccount();
            bankAccount.AccountCurrency = beneficiario.CuentaBancaria.Moneda;
            bankAccount.AccountNum = beneficiario.CuentaBancaria.NumeroCuenta;
            bankAccount.AccountState = 1;
            bankAccount.PrimaryFlag = "Y";
            bankAccount.BankId = 6250000981;
            creaPersonaRequest.BankAccounts = new List<Models.Request.CreaPersona.BankAccount>();
            creaPersonaRequest.BankAccounts.Add(bankAccount);

            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/Persona/v1/persona");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(creaPersonaRequest);
            request.AddStringBody(body, DataFormat.Json);
            var response = client.Execute<CreaPersonaResult>(request);
            creaPersonaResult = response.Data;

            //if (response.IsSuccessStatusCode)
            //{
            //    creaPersonaResult = JsonConvert.DeserializeObject<CreaPersonaResult>(response.Content);
            //}

            return creaPersonaResult;
        }

        private RegistroReclamanteResult RegistroReclamante(ConsultaPersonaResult consultaPersonaResult, ConsultaSiniestroResult consultaSiniestroResult, Models.Request.LiquidarSiniestro.CoberturasSiniestrada coberturasSiniestrada, string codigoTipoReclamanteCharles, ConsultaPersonaResult participante)
        {
            //113
            RegistroReclamanteResult registroReclamanteResult = new RegistroReclamanteResult() { StatusCode = StatusCodes.Status400BadRequest };

            RegistroReclamanteRequest registroReclamanteRequest = new RegistroReclamanteRequest();
            registroReclamanteRequest.ClaimNo = consultaSiniestroResult.ClaimId.ToString();// "20700001714";
            registroReclamanteRequest.Request = new CharlesApi.Models.Request.RegistroReclamante.Request();
            registroReclamanteRequest.Request.RequestDate = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
            registroReclamanteRequest.Request.ClaimantId = consultaPersonaResult.RowSet[0].ManId;

            var tipoReclamante = tipoReclamanteRepository.ObtenerTipoReclamante(new Entities.TipoReclamante.TipoReclamanteModel() { CodigoTipoReclamanteCharles = codigoTipoReclamanteCharles });

            registroReclamanteRequest.Request.ClaimantType = Convert.ToInt32( tipoReclamante.CodigoTipoReclamanteSura);// 2;
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
            var codigoCoberturaSura = coberturaRepository.ObtenerCobertura(new Entities.Cobertura.CoberturaModel() {CodigoCoberturaCharles = coberturasSiniestrada.Cobertura });

            var covertura = poliza.PolicyAnnexes[0].InsuredObjects[0].Covers.Where(c => c.CoverType == codigoCoberturaSura.CodigoCoberturaSura).FirstOrDefault();

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
            injured.InitialReserve = coberturasSiniestrada.MontoLiquidado;// 99;//variable, por la vista Charles Taylor (reserva Inicial)
            injured.Currency = "UF"; //siempre

            injured.Documents = documents;
            registroReclamanteRequest.Request.InjuredObjects.InjuredObject.Add(injured);

            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/RegistroReclamante/v1/registroReclamante");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(registroReclamanteRequest);
            request.AddStringBody(body, DataFormat.Json);
            var response = client.Execute<RegistroReclamanteResult>(request);
            registroReclamanteResult = response.Data;

            logger.LogInformation($"RegistroReclamante => {DateTime.Now.ToString()}, JSON INPUT => {body}");
            logger.LogInformation($"RegistroReclamante => {DateTime.Now.ToString()}, JSON RESPONSE => {registroReclamanteResult}");



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
            var request = new RestRequest($"{settings.UrlBaseEsoapApi}api/poliza/v1/poliza?policyNo={policyNo}", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute<ConsultaPolizaResult>(request);
            consultaPolizaResult = response.Data;

            logger.LogInformation($"ConsultaPoliza => {DateTime.Now.ToString()}, JSON => {JsonConvert.SerializeObject(consultaPolizaResult)}");


            //if (response.IsSuccessStatusCode)
            //{
            //    consultaPolizaResult = response.Data;
            //}
            return consultaPolizaResult;
        }

        private ConfirmarResult ConfirmarRequest(ConfirmarRequest confirmarRequest)
        {
            ConfirmarResult confirmarResult = new ConfirmarResult() { StatusCode = StatusCodes.Status400BadRequest };

            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/Confirmar/v1/confirmar");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(confirmarRequest);
            request.AddStringBody(body, DataFormat.Json);
            var response = client.Execute<ConfirmarResult>(request);
            confirmarResult = response.Data;

            //if (response.IsSuccessStatusCode)
            //{
            //    confirmarResult = JsonConvert.DeserializeObject<ConfirmarResult>(response.Content);
            //}

            return confirmarResult;
        }


        private ConfirmarEvaluacionResult ConfirmarEvaluacion(long claimObjectSeq, RegistroEvaluacionResult registroEvaluacionResult)
        {
            //CONFIRMAR EVALUACION => 121
            ConfirmarEvaluacionResult confirmarEvaluacionResult = new ConfirmarEvaluacionResult() { StatusCode = StatusCodes.Status400BadRequest };

            ConfirmarEvaluacionRequest confirmarEvaluacionRequest = new ConfirmarEvaluacionRequest();
            confirmarEvaluacionRequest.ClaimObjectSeq = claimObjectSeq;
            confirmarEvaluacionRequest.InspectNum = registroEvaluacionResult.InspectNum;

            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/ConfirmarEvaluacion/v1/confirmarEvaluacion");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(confirmarEvaluacionRequest);
            request.AddStringBody(body, DataFormat.Json);
            var response = client.Execute<ConfirmarEvaluacionResult>(request);
            confirmarEvaluacionResult = response.Data;
            //if (response.IsSuccessStatusCode)
            //{
            //    confirmarEvaluacionResult = JsonConvert.DeserializeObject<ConfirmarEvaluacionResult>(response.Content);
            //}

            return confirmarEvaluacionResult;
        }

        private ConfirmarCalculoResult ConfirmarCalculo(RegistroCalculoResult registroCalculoResult)
        {
            //CONFIRMAR CALCULO => 125
            ConfirmarCalculoResult confirmarCalculo = new ConfirmarCalculoResult() { StatusCode = StatusCodes.Status400BadRequest };

            ConfirmarCalculoRequest confirmarCalculoRequest = new ConfirmarCalculoRequest();
            confirmarCalculoRequest.ClaimDscrSeq = registroCalculoResult.ClaimDscrSeq;
            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/ConfirmarCalculo/v1/confirmarCalculo");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(confirmarCalculoRequest);
            request.AddStringBody(body, DataFormat.Json);

            var  response = client.Execute<ConfirmarCalculoResult>(request);
            confirmarCalculo = response.Data;
            //if (response.IsSuccessStatusCode)
            //{
            //    confirmarCalculo = JsonConvert.DeserializeObject<ConfirmarCalculoResult>(response.Content);
            //}

            return confirmarCalculo;
        }

        private ConfirmarPagoResult ConfirmarPago(long requestNo, RegistroPagoResult registroPagoResult, ConsultaSiniestroResult consultaSiniestroResult)
        {
            //CONFIRMAR  PAGO => 123
            ConfirmarPagoResult confirmarCalculo = new ConfirmarPagoResult() { StatusCode = StatusCodes.Status400BadRequest };

            ConfirmarPagoRequest confirmarCalculoRequest = new ConfirmarPagoRequest();
            confirmarCalculoRequest.ClaimReportGroup = new ClaimReportGroup();
            confirmarCalculoRequest.DocladId = registroPagoResult.ReportId;
            ClaimReportGroup claimReportGroup = new ClaimReportGroup();
            claimReportGroup.ClaimId = consultaSiniestroResult.ClaimId;
            claimReportGroup.RequestNo = requestNo;
            claimReportGroup.DocladNo = registroPagoResult.ReportNo;
            confirmarCalculoRequest.ClaimReportGroup = claimReportGroup;
            
            var client = new RestClient($"{settings.UrlBaseEsoapApi}api/ConfirmarPago/v1/confirmarPago");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(confirmarCalculoRequest);
            request.AddStringBody(body, DataFormat.Json);
            
            var response = client.Execute<ConfirmarPagoResult>(request);
            confirmarCalculo = response.Data;
            //if (response.IsSuccessStatusCode)
            //{
            //    confirmarCalculo = JsonConvert.DeserializeObject<ConfirmarPagoResult>(response.Content);
            //}

            return confirmarCalculo;
        }

    }
}

