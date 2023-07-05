






/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*13-04-2023,Generador de Código, Clase Inicial 
*/



//using CharlesApi.Data.Base;
using AutoMapper;
using CharlesApi.Entities.TipoReclamante;
using CharlesApi.Helpers.Base;
using CharlesApi.Models.Result.TipoReclamante;
using CharlesApi.Repository.TipoReclamante;
using CharlesApi.Request.TipoReclamante;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace CharlesApi.Data.TipoReclamante
{
    /// <summary>
    /// Esta Clase TipoReclamante  permite gestionar reglas de negocio asociados a la entidad TipoReclamante
    /// </summary>
    public partial class TipoReclamanteService : ITipoReclamanteService
	{	
        private ISettingsConfig settings;
        private ITipoReclamanteRepository tipoReclamanteRepository;
        private IMapper mapper;
        public TipoReclamanteService(ITipoReclamanteRepository tipoReclamanteRepository, IMapper mapper)
        {
            this.tipoReclamanteRepository = tipoReclamanteRepository;
            this.mapper = mapper;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto TipoReclamanteResult con información del resultado de la operación</returns>
		public TipoReclamanteResult ObtenerTipoReclamante(TipoReclamanteRequest tipoReclamanteRequest)
        {
			TipoReclamanteResult tipoReclamanteResult = new TipoReclamanteResult();
            tipoReclamanteResult.StatusCode = StatusCodes.Status202Accepted;
			try
            {
                var tipoReclamanteModel = mapper.Map<TipoReclamanteModel>(tipoReclamanteRequest);
                var tipoReclamante = tipoReclamanteRepository.ObtenerTipoReclamante(tipoReclamanteModel);
                if (tipoReclamante!=null)
                {
                    tipoReclamanteResult = mapper.Map<TipoReclamanteResult>(tipoReclamante);
                    tipoReclamanteResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return tipoReclamanteResult;
        }

		
	}
}

