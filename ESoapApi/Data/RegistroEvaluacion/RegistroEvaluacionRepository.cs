using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Entities.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Models.Request.RegistroEvaluacion;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.RegistroEvaluacion
{
    public class RegistroEvaluacionRepository : IRegistroEvaluacionRepository
    {
        public RegistroEvaluacionModel RegistroEvaluacion(RegistroEvaluacionRequest registroEvaluacionRequest)
        {  
            // REGISTRAR EVALUACION => 120
            RegistroEvaluacionModel listaRegistroEvaluacionModel = null;

            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-claim-cst/claim/evaluation");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(registroEvaluacionRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    listaRegistroEvaluacionModel = JsonConvert.DeserializeObject<RegistroEvaluacionModel>(response.Content);
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                    throw new TechnicalExcepction(error.Message);
                }
            }
            catch (Exception ex )
            {

                throw ex;
            }
            return listaRegistroEvaluacionModel;
        }
    }
}
