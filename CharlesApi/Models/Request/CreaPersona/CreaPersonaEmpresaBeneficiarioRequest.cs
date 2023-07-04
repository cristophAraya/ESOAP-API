using Newtonsoft.Json;

namespace CharlesApi.Models.Request.CreaPersonaEmpresaBeneficiario
{
    public class CreaPersonaEmpresaBeneficiarioRequest
    {
        [JsonProperty("manComp")]
        public int ManComp { get; set; }

        [JsonProperty("egn")]
        
        public string Egn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }

        [JsonProperty("bankAccounts")]
        public List<BankAccount> BankAccounts { get; set; }
    }

    public partial class BankAccount
    {
        [JsonProperty("accountCurrency")]
        public string AccountCurrency { get; set; }

        [JsonProperty("accountNum")]
        
        public string AccountNum { get; set; }

        [JsonProperty("accountState")]
        public int AccountState { get; set; }

        [JsonProperty("bankId")]
        public long BankId { get; set; }

        [JsonProperty("primaryFlag")]
        public string PrimaryFlag { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("primaryFlag")]
        public string PrimaryFlag { get; set; }
    }
}

