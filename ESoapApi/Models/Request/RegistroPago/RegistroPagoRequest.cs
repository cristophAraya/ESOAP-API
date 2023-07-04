using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Request.RegistroPago
{
    public class RegistroPagoRequest
    {
        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requestNo")]
        public long RequestNo { get; set; }

        [JsonProperty("beneficiaries")]
        public Beneficiaries Beneficiaries { get; set; }
    }

    public partial class Beneficiaries
    {
        [JsonProperty("beneficiary")]
        public List<Beneficiary> Beneficiary { get; set; }
    }

    public partial class Beneficiary
    {
        [JsonProperty("pid")]

        public string Pid { get; set; }

        [JsonProperty("paymentWay")]
        public string PaymentWay { get; set; }

        [JsonProperty("benefShare", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? BenefShare { get; set; }

        [JsonProperty("calculations")]
        public Calculations Calculations { get; set; }

        [JsonProperty("bankAccount")]
        public BankAccount BankAccount { get; set; }
    }

    public partial class BankAccount
    {
        [JsonProperty("bankPid")]

        public string BankPid { get; set; }

        [JsonProperty("accountNo")]
        public string AccountNo { get; set; }

        [JsonProperty("bankAccId")]
        public long BankAccId { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }
    }

    public partial class Calculations
    {
        [JsonProperty("calculation")]
        public List<Calculation> Calculation { get; set; }
    }

    public partial class Calculation
    {
        [JsonProperty("claimDscrSeq")]
        public long ClaimDscrSeq { get; set; }
    }
}
