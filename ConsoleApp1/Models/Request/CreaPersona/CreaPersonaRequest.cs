
using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Request.CreaPersona
{
    public class CreaPersonaRequest
    {
        [JsonProperty("manComp")]
        public int ManComp { get; set; }

        [JsonProperty("birthDate")]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("egn")]
        public string Egn { get; set; }

        [JsonProperty("gname")]
        public string Gname { get; set; }

        [JsonProperty("sname")]
        public string Sname { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("sex")]
        public int Sex { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("bankAccounts")]
        public BankAccount[] BankAccounts { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("addressType")]
        public string AddressType { get; set; }

        [JsonProperty("address")]
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
