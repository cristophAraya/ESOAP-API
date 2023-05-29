
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Entities.ConsultaPoliza;
using Cl.Sura.ESoapApi.Models.Entities.Error;
using Dapper;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RestSharp;
using System.Data;
using System.Data.SqlClient;

namespace Cl.Sura.ESoapApi.Data.Poliza
{
    public class PolizaRepository : DBBaseHelper, IPolizaRepository
    {
        public PolizaRepository(ISettingsConfig settings) : base(settings)
        {
            this.settingsConfig = settings;
        }

        public ConsultaPolizaModel ConsultaPoliza(string numeroPoliza)
        {
            //101
            ConsultaPolizaModel result = null;

            try
            {
                var client = new RestClient($"https://apim-segurossura-preprd.azure-api.net/insis-policies/policy/composite?policyNo={numeroPoliza}");//100036986
                var request = new RestRequest("", Method.Get);
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = @"";
                request.AddParameter("text/plain", body, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<ConsultaPolizaModel>(response.Content);
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

            return result;
        }

    }
}
