
using Cl.Sura.ESoapApi.Models.Entities.ConsultaPersona;
using Cl.Sura.ESoapApi.Models.Entities.ConsultaPersonaCompleta;
using Cl.Sura.ESoapApi.Models.Entities.ConsultaPoliza;
using Cl.Sura.ESoapApi.Models.Entities.CreaPersona;
using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Request.CreaPersona;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.Persona
{
    public class PersonaRepository : IPersonaRepository
    {
        public ConsultaPersonaModel ConsultaPersona(string egn)
        {
            ConsultaPersonaModel consultaPersonaModel = new ConsultaPersonaModel();

            try
            {
                var client = new RestClient($"https://apim-segurossura-preprd.azure-api.net/insis-people/person?egn={egn}");
                var request = new RestRequest("", Method.Get);
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                RestResponse response =  client.Execute(request);

                if(response.IsSuccessStatusCode)
                {
                    consultaPersonaModel = JsonConvert.DeserializeObject<ConsultaPersonaModel>(response.Content);
                }
                else
                {
                    var error = "Problemas al consumir API ConsultaPersona";
                    throw new TechnicalExcepction(error);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return consultaPersonaModel;
        }

        public ConsultaPersonaCompletaModel ConsultaPersonaCompleta(string egn)
        {
            ConsultaPersonaCompletaModel consultaPersonaModel = new ConsultaPersonaCompletaModel();

            try
            {
                var client = new RestClient($"https://apim-segurossura-preprd.azure-api.net/insis-people/person/composite/?pid={egn}");
                var request = new RestRequest("", Method.Get);
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                RestResponse response = client.Execute(request);

                if (response.IsSuccessStatusCode)
                {
                    consultaPersonaModel = JsonConvert.DeserializeObject<ConsultaPersonaCompletaModel>(response.Content);
                }

            }
            catch (Exception ex )
            {

                throw ex;
            }
            return consultaPersonaModel;
        }

        public CreaPersonaModel CreaPersona(CreaPersonaRequest personaRequest)
        {
            //107
            CreaPersonaModel consultaPersonaModel = new CreaPersonaModel();

            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-people/person/composite");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(personaRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response =  client.Execute(request);
                if (response.IsSuccessStatusCode)
                { 
                    consultaPersonaModel = JsonConvert.DeserializeObject<CreaPersonaModel>(response.Content);
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                    throw new TechnicalExcepction(error.Message);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return consultaPersonaModel;
        }
    }
}
