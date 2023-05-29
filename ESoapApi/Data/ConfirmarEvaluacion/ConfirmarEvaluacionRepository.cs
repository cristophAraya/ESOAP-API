using Cl.Sura.ESoapApi.Models.Entities.ConfirmarEvaluacion;
using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarEvaluacion;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.ConfirmarEvaluacion
{
    public class ConfirmarEvaluacionRepository : IConfirmarEvaluacionRepository
    {
        public ConfirmarEvaluacionModel ConfirmarEvaluacion(ConfirmarEvaluacionRequest listaConfirmarEvaluacionRequest)
        { 
            //CONFIRMAR EVALUACION => 121
            ConfirmarEvaluacionModel listaConfirmarEvaluacionModel = null;

            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-claim-cst/claim/evaluation-confirmation");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(listaConfirmarEvaluacionRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    listaConfirmarEvaluacionModel = JsonConvert.DeserializeObject<ConfirmarEvaluacionModel>(response.Content);
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                    throw new TechnicalExcepction(error.Message);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return listaConfirmarEvaluacionModel;
        }
    }
}
