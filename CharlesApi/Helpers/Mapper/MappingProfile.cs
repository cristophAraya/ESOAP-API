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
using CharlesApi.Entities.Beneficiario;
using CharlesApi.Entities.Cobertura;
using CharlesApi.Entities.CoberturaSiniestrada;
using CharlesApi.Entities.Participante;
using CharlesApi.Entities.Reclamante;
using CharlesApi.Entities.Siniestro;
using CharlesApi.Entities.SiniestroLog;
using CharlesApi.Entities.TipoEvento;
using CharlesApi.Entities.TipoReclamante;
using CharlesApi.Models.Request.DeclararSiniestro;
using CharlesApi.Models.Request.ReclamantePrincipal;
using CharlesApi.Models.Result.LiquidarSiniestro;
using CharlesApi.Request.Cobertura;
using CharlesApi.Request.CoberturaSiniestrada;
using CharlesApi.Request.Participante;
using CharlesApi.Request.Reclamante;
using CharlesApi.Request.Siniestro;
using CharlesApi.Request.SiniestroLog;
using CharlesApi.Request.TipoEvento;
using CharlesApi.Request.TipoReclamante;
using CharlesApi.Result.Cobertura;
using CharlesApi.Result.CoberturaSiniestrada;
using CharlesApi.Result.Participante;
using CharlesApi.Result.Reclamante;
using CharlesApi.Result.Siniestro;
using CharlesApi.Result.SiniestroLog;
using CharlesApi.Result.TipoEvento;
using CharlesApi.Result.TipoReclamante;

namespace CharlesApi.Helpers.Mapper
{
    /// <summary>
    /// Acá se realizara el mappeo entre los To y los Models de la facade y viceversa.
    /// </summary>
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
            CreateMap<DeclararSiniestroRequest, SiniestroRequest>().ReverseMap();
            CreateMap<SiniestroModel, SiniestroRequest>().ReverseMap();
            CreateMap<SiniestroModel, SiniestroResult>().ReverseMap();

            CreateMap<ReclamantePrincipalResquest, ReclamanteRequest>()
                .ForMember(a => a.CodigoTipoReclamante, b => b.MapFrom(u => u.Reclamante.CodigoTipoReclamante))
                .ForMember(a => a.TipoReclamante, b => b.MapFrom(u => u.Reclamante.TipoReclamante))
                .ForMember(a => a.Rut, b => b.MapFrom(u => u.Reclamante.Rut))
                .ForMember(a => a.PrimerNombre, b => b.MapFrom(u => u.Reclamante.PrimerNombre))
                .ForMember(a => a.SegundoNombre, b => b.MapFrom(u => u.Reclamante.SegundoNombre))
                .ForMember(a => a.Apellidos, b => b.MapFrom(u => u.Reclamante.Apellidos))
                .ForMember(a => a.FechaNacimiento, b => b.MapFrom(u => u.Reclamante.FechaNacimiento))
                .ForMember(a => a.SegundoNombre, b => b.MapFrom(u => u.Reclamante.SegundoNombre))
                .ForMember(a => a.Genero, b => b.MapFrom(u => u.Reclamante.Genero))
                .ForMember(a => a.Pais, b => b.MapFrom(u => u.Reclamante.Direccion.Pais))
                 .ForMember(a => a.Region, b => b.MapFrom(u => u.Reclamante.Direccion.Region))
                .ForMember(a => a.Ciudad, b => b.MapFrom(u => u.Reclamante.Direccion.Ciudad))
                .ForMember(a => a.Comuna, b => b.MapFrom(u => u.Reclamante.Direccion.Comuna))
                .ForMember(a => a.Calle, b => b.MapFrom(u => u.Reclamante.Direccion.Calle))
                .ForMember(a => a.CasaDepto, b => b.MapFrom(u => u.Reclamante.Direccion.CasaDepto))
                .ForMember(a => a.Numeracion, b => b.MapFrom(u => u.Reclamante.Direccion.Numeracion))
                .ForMember(a => a.TipoContacto, b => b.MapFrom(u => u.Reclamante.ViaContacto.TipoContacto))
                .ForMember(a => a.FormaContacto, b => b.MapFrom(u => u.Reclamante.ViaContacto.FormaContacto)).ReverseMap();

            CreateMap<ReclamanteModel, ReclamanteRequest>().ReverseMap();
            CreateMap<ReclamanteModel, ReclamanteResult>().ReverseMap();

            CreateMap<CharlesApi.Models.Request.LiquidarSiniestro.Reclamante, ReclamanteModel>()
             
                .ForMember(a => a.Rut, b => b.MapFrom(u => u.Rut))
               .ForMember(a => a.PrimerNombre, b => b.MapFrom(u => u.PrimerNombre))
               .ForMember(a => a.NumeroSolicitud, b => b.MapFrom(u => u.NumeroSolicitud))
                .ForMember(a => a.SegundoNombre, b => b.MapFrom(u => u.SegundoNombre))
                .ForMember(a => a.Apellidos, b => b.MapFrom(u => u.Apellidos))
                .ForMember(a => a.FechaNacimiento, b => b.MapFrom(u => u.FechaNacimiento))
                .ForMember(a => a.SegundoNombre, b => b.MapFrom(u => u.SegundoNombre))
                .ForMember(a => a.Genero, b => b.MapFrom(u => u.Genero))
                .ForMember(a => a.Pais, b => b.MapFrom(u => u.Direccion.Pais))
                .ForMember(a => a.Region, b => b.MapFrom(u => u.Direccion.Region))
                .ForMember(a => a.Ciudad, b => b.MapFrom(u => u.Direccion.Ciudad))
                .ForMember(a => a.Comuna, b => b.MapFrom(u => u.Direccion.Comuna))
                .ForMember(a => a.Calle, b => b.MapFrom(u => u.Direccion.Calle))
                .ForMember(a => a.CasaDepto, b => b.MapFrom(u => u.Direccion.CasaDepto))
                .ForMember(a => a.Numeracion, b => b.MapFrom(u => u.Direccion.Numeracion))
                .ForMember(a => a.TipoContacto, b => b.MapFrom(u => u.ViaContacto.TipoContacto))
                .ForMember(a => a.FormaContacto, b => b.MapFrom(u => u.ViaContacto.InformacionContacto)).ReverseMap();

            CreateMap<CharlesApi.Models.Request.LiquidarSiniestro.Beneficiario, BeneficiarioModel>()
                 .ForMember(a => a.Rut, b => b.MapFrom(u => u.Rut))
               .ForMember(a => a.PrimerNombre, b => b.MapFrom(u => u.PrimerNombre))
                .ForMember(a => a.SegundoNombre, b => b.MapFrom(u => u.SegundoNombre))
                .ForMember(a => a.Apellidos, b => b.MapFrom(u => u.Apellidos))
                .ForMember(a => a.FechaNacimiento, b => b.MapFrom(u => u.FechaNacimiento))
                .ForMember(a => a.SegundoNombre, b => b.MapFrom(u => u.SegundoNombre))
                .ForMember(a => a.Genero, b => b.MapFrom(u => u.Genero))
                .ForMember(a => a.Pais, b => b.MapFrom(u => u.Direccion.Pais))
                 .ForMember(a => a.Region, b => b.MapFrom(u => u.Direccion.Region))
                .ForMember(a => a.Ciudad, b => b.MapFrom(u => u.Direccion.Ciudad))
                .ForMember(a => a.Comuna, b => b.MapFrom(u => u.Direccion.Comuna))
                .ForMember(a => a.Calle, b => b.MapFrom(u => u.Direccion.Calle))
                .ForMember(a => a.CasaDepto, b => b.MapFrom(u => u.Direccion.CasaDepto))
                .ForMember(a => a.Numeracion, b => b.MapFrom(u => u.Direccion.Numeracion))
                .ForMember(a => a.TipoContacto, b => b.MapFrom(u => u.ViaContacto.TipoContacto))
                .ForMember(a => a.FormaContacto, b => b.MapFrom(u => u.ViaContacto.InformacionContacto))
                .ForMember(a => a.Moneda, b => b.MapFrom(u => u.CuentaBancaria.Moneda))
                .ForMember(a => a.NumeroCuenta, b => b.MapFrom(u => u.CuentaBancaria.NumeroCuenta))
                .ForMember(a => a.Banco, b => b.MapFrom(u => u.CuentaBancaria.Banco)).ReverseMap();

            CreateMap<CharlesApi.Models.Request.LiquidarSiniestro.CoberturasSiniestrada, CoberturaSiniestradaModel>().ReverseMap();

            CreateMap<CoberturaRequest, CoberturaModel>().ReverseMap();
            CreateMap<CoberturaResult, CoberturaModel>().ReverseMap();
            CreateMap<TipoEventoRequest, TipoEventoModel>().ReverseMap();
            CreateMap<TipoEventoResult, TipoEventoModel>().ReverseMap();
            CreateMap<TipoReclamanteRequest, TipoReclamanteModel>().ReverseMap();
            CreateMap<TipoReclamanteResult, TipoReclamanteModel>().ReverseMap();
            CreateMap<SiniestroLogRequest, SiniestroLogModel>().ReverseMap();
            CreateMap<SiniestroLogResult, SiniestroLogModel>().ReverseMap();

            CreateMap<CharlesApi.Models.Request.LiquidarSiniestro.Participante, ParticipanteModel>()
                   .ForMember(a => a.Pais, b => b.MapFrom(u => u.Direccion.Pais))
                 .ForMember(a => a.Region, b => b.MapFrom(u => u.Direccion.Region))
                .ForMember(a => a.Ciudad, b => b.MapFrom(u => u.Direccion.Ciudad))
                .ForMember(a => a.Comuna, b => b.MapFrom(u => u.Direccion.Comuna))
                .ForMember(a => a.Calle, b => b.MapFrom(u => u.Direccion.Calle))
                .ForMember(a => a.CasaDepto, b => b.MapFrom(u => u.Direccion.CasaDepto))
                .ForMember(a => a.Numeracion, b => b.MapFrom(u => u.Direccion.Numeracion)).ReverseMap();

            CreateMap<ParticipanteRequest, ParticipanteModel>().ReverseMap();
            CreateMap<ParticipanteResult, ParticipanteModel>().ReverseMap();

            CreateMap<CoberturaSiniestradaRequest, CoberturaSiniestradaModel>().ReverseMap();
            CreateMap<CoberturaSiniestradaResult, CoberturaSiniestradaModel>().ReverseMap();            

            CreateMap<CharlesApi.Models.Request.ReclamantePrincipal.ParticipantePrincipal, ParticipanteRequest>()
                .ForMember(a => a.Pais, b => b.MapFrom(u => u.Direccion.Pais))
                .ForMember(a => a.Ciudad, b => b.MapFrom(u => u.Direccion.Ciudad))
                .ForMember(a => a.Region, b => b.MapFrom(u => u.Direccion.Region))
                .ForMember(a => a.Comuna, b => b.MapFrom(u => u.Direccion.Comuna))
                .ForMember(a => a.Calle, b => b.MapFrom(u => u.Direccion.Calle))
                .ForMember(a => a.CasaDepto, b => b.MapFrom(u => u.Direccion.CasaDepto))
                .ForMember(a => a.Numeracion, b => b.MapFrom(u => u.Direccion.Numeracion)).ReverseMap();
        }
    }
}      
