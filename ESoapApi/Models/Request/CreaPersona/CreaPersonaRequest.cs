using Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza;
using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Request.CreaPersona
{
    public class CreaPersonaRequest
    {
        [JsonProperty("manComp")]
        public int ManComp { get; set; }

       
        [JsonProperty("birthDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("egn")]
        public string Egn { get; set; }
       
        [JsonProperty("gname", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Gname { get; set; }
         
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
       
        [JsonProperty("sname", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Sname { get; set; }
       
        [JsonProperty("fname", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Fname { get; set; }
       
        [JsonProperty("sex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Sex { get; set; }
       
        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Address[] Addresses { get; set; }
       
        [JsonProperty("contacts", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Contact[] Contacts { get; set; }
       
        [JsonProperty("bankAccounts", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BankAccountPersona[] BankAccounts { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("addressType")]
        public string AddressType { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string AddressAddress { get; set; }

        [JsonProperty("blockNumber")]
        public string BlockNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cityCode")]
        public string CityCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryState")]

        public string CountryState { get; set; }

        [JsonProperty("entranceNumber")]

        public string EntranceNumber { get; set; }

        [JsonProperty("invoiceYn")]
        public string InvoiceYn { get; set; }

        [JsonProperty("mailYn")]
        public string MailYn { get; set; }

        [JsonProperty("postCode")]

        public string PostCode { get; set; }

        [JsonProperty("primaryFlag")]
        public string PrimaryFlag { get; set; }

        [JsonProperty("quarterId")]
        public string QuarterId { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("stateRegion")]
        public string StateRegion { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("streetNumber")]
        public string StreetNumber { get; set; }
    }

    public partial class BankAccountPersona
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
