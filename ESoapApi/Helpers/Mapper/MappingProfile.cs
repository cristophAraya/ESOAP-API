/**
* (c)2013-2023 CodeBase SPA Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*24-01-2023,Generador de Código, Clase Inicial 
*/

using AutoMapper;
using Cl.Sura.ESoapApi.Models.Entities.ConsultaPersona;
using Cl.Sura.ESoapApi.Models.Entities.ConsultaPoliza;
using Cl.Sura.ESoapApi.Models.Entities.CreaPersona;
using Cl.Sura.ESoapApi.Models.Entities.ListaEvento;
using Cl.Sura.ESoapApi.Models.Result.ListaEvento;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPersona;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza;
using Cl.Sura.ESoapApi.Models.Result.CreaPersona;
using Cl.Sura.ESoapApi.Models.Result.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Entities.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Result.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Entities.RegistroReclamante;
using Cl.Sura.ESoapApi.Models.Result.RegistroReclamante;
using Cl.Sura.ESoapApi.Models.Result.ConsultaSiniestro;
using Cl.Sura.ESoapApi.Models.Entities.ConsultaSiniestro;
using Cl.Sura.ESoapApi.Models.Entities.Confirmar;
using Cl.Sura.ESoapApi.Models.Request.Confirmar;
using Cl.Sura.ESoapApi.Models.Result.Confirmar;
using Cl.Sura.ESoapApi.Models.Entities.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Models.Result.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Models.Entities.ConfirmarEvaluacion;
using Cl.Sura.ESoapApi.Models.Entities.RegistroCalculo;
using Cl.Sura.ESoapApi.Models.Result.RegistroCalculo;
using Cl.Sura.ESoapApi.Models.Entities.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Models.Entities.ConfirmarPago;
using Cl.Sura.ESoapApi.Models.Entities.RegistroPago;
using Cl.Sura.ESoapApi.Models.Result.RegistroPago;
using Cl.Sura.ESoapApi.Models.Result.ConfirmarPago;
using Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta;

namespace Cl.Sura.ESoapApi.Helpers.Mapper
{
	/// <summary>
	/// Acá se realizara el mappeo entre los To y los Models de la facade y viceversa.
	/// </summary>
	public class MappingProfile : Profile
	{
		public MappingProfile()
        {
            CreateMap<ConsultaPolizaResult, ConsultaPolizaModel>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PAgents, Models.Entities.ConsultaPoliza.PAgents>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PPeopleComplex, Models.Entities.ConsultaPoliza.PPeopleComplex>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.Address, Models.Entities.ConsultaPoliza.Address>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.Pid, Models.Entities.ConsultaPoliza.Pid>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.BankAccount, Models.Entities.ConsultaPoliza.BankAccount>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PBanks, Models.Entities.ConsultaPoliza.PBanks>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.Contact, Models.Entities.ConsultaPoliza.Contact>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.Document, Models.Entities.ConsultaPoliza.Document>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.Question, Models.Entities.ConsultaPoliza.Question>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PClients, Models.Entities.ConsultaPoliza.PClients>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PolicyAnnex, Models.Entities.ConsultaPoliza.PolicyAnnex>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.Commission, Models.Entities.ConsultaPoliza.Commission>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.Installment, Models.Entities.ConsultaPoliza.Installment>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.InsuredObject, Models.Entities.ConsultaPoliza.InsuredObject>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.Cover, Models.Entities.ConsultaPoliza.Cover>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.InsuredEntity, Models.Entities.ConsultaPoliza.InsuredEntity>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.OCar, Models.Entities.ConsultaPoliza.OCar>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PaymentPlan, Models.Entities.ConsultaPoliza.PaymentPlan>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PolicyAddress, Models.Entities.ConsultaPoliza.PolicyAddress>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PolicyAgent, Models.Entities.ConsultaPoliza.PolicyAgent>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PolicyContact, Models.Entities.ConsultaPoliza.PolicyContact>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PolicyEngBilling, Models.Entities.ConsultaPoliza.PolicyEngBilling>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PolicyParticipant, Models.Entities.ConsultaPoliza.PolicyParticipant>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PolicyParticipantsNames, Models.Entities.ConsultaPoliza.PolicyParticipantsNames>().ReverseMap();
            CreateMap<Models.Result.ConsultaPoliza.PolicyNames, Models.Entities.ConsultaPoliza.PolicyNames>().ReverseMap();

            CreateMap<ConsultaPersonaResult, ConsultaPersonaModel>().ReverseMap();
            CreateMap <Models.Result.ConsultaPersona.RowSet, Models.Entities.ConsultaPersona.RowSet>().ReverseMap();


            CreateMap<CreaPersonaResult, CreaPersonaModel>().ReverseMap();
            CreateMap<Models.Result.CreaPersona.Address, Models.Entities.CreaPersona.Address > ().ReverseMap();
            CreateMap<Models.Result.CreaPersona.Pid, Models.Entities.CreaPersona.Pid>().ReverseMap();
            CreateMap<Models.Result.CreaPersona.BankAccount, Models.Entities.CreaPersona.BankAccount>().ReverseMap();
            CreateMap<Models.Result.CreaPersona.PBanks, Models.Entities.CreaPersona.PBanks>().ReverseMap();
            CreateMap<Models.Result.CreaPersona.Contact, Models.Entities.CreaPersona.Contact>().ReverseMap();

            CreateMap<ListaEventoResult, ListaEventoModel>().ReverseMap();
            CreateMap<Models.Result.ListaEvento.RowSet, Models.Entities.ListaEvento.RowSet> ().ReverseMap();
            CreateMap<Models.Result.ListaEvento.Row, Models.Entities.ListaEvento.Row> ().ReverseMap();
            CreateMap<Models.Result.ListaEvento.Column, Models.Entities.ListaEvento.Column > ().ReverseMap();

            CreateMap<RegistroDenuncioResult, RegistroDenuncioModel>().ReverseMap();
            CreateMap< Models.Result.RegistroDenuncio.ReturningMessages, Models.Entities.RegistroDenuncio.ReturningMessages>().ReverseMap();

            CreateMap<RegistroReclamanteResult, RegistroReclamanteModel>().ReverseMap();
            CreateMap<Models.Result.RegistroReclamante.ReturningMessages, Models.Entities.RegistroReclamante.ReturningMessages>().ReverseMap();

            CreateMap<ConsultaSiniestroResult, ConsultaSiniestroModel>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Result.ConsultaSiniestro.ClaimRequest, Cl.Sura.ESoapApi.Models.Entities.ConsultaSiniestro.ClaimRequest>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Result.ConsultaSiniestro.ClaimObject, Cl.Sura.ESoapApi.Models.Entities.ConsultaSiniestro.ClaimObject>().ReverseMap();

            //CreateMap<ConfirmarModel, ConfirmarRequest>().ReverseMap();
            CreateMap<ConfirmarModel, ConfirmarResult>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Entities.Confirmar.Requests, Cl.Sura.ESoapApi.Models.Result.Confirmar.Requests>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Entities.Confirmar.Request, Cl.Sura.ESoapApi.Models.Result.Confirmar.Request>().ReverseMap();


            CreateMap<RegistroEvaluacionModel, RegistroEvaluacionResult>().ReverseMap();
            CreateMap<ConfirmarEvaluacionModel,Cl.Sura.ESoapApi.Models.Result.ConfirmarEvaluacion.ConfirmarEvaluacionResult>().ReverseMap();

            CreateMap<RegistroCalculoModel, RegistroCalculoResult>().ReverseMap();

            CreateMap<ConfirmarCalculoModel, ConfirmarCalculoResult>().ReverseMap();


            CreateMap<RegistroPagoModel, RegistroPagoResult>().ReverseMap();
            CreateMap<ConfirmarPagoModel, ConfirmarPagoResult>().ReverseMap();

            CreateMap<ConsultaPersonaCompletaModel, ConsultaPersonaCompletaResult>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta.Address, Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta.Address>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta.BankAccount, Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta.BankAccount>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta.PBanks, Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta.PBanks>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta.Pid, Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta.Pid>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta.Contact, Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta.Contact>().ReverseMap();
            CreateMap<Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta.Contact, Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta.Contact>().ReverseMap();
        }
        
    }
}      
