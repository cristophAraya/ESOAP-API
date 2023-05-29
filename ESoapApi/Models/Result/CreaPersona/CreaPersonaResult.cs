using Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza;
using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Result.CreaPersona
{
    public class CreaPersonaResult
    {
        [JsonProperty("errores")]
        public List<string> Errores { get; set; } = new List<string>();
        public int StatusCode { get; set; }

        [JsonProperty("documents")]
        public object[] Documents { get; set; }

        [JsonProperty("egn")]
        
        public long Egn { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("registrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("sex")]
        public long Sex { get; set; }

        [JsonProperty("manComp")]
        public long ManComp { get; set; }

        [JsonProperty("gname")]
        public string Gname { get; set; }

        [JsonProperty("sname")]
        public string Sname { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("birthDate")]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("questions")]
        public object[] Questions { get; set; }

        [JsonProperty("peopleGroups")]
        public object[] PeopleGroups { get; set; }

        [JsonProperty("contactPersons")]
        public object[] ContactPersons { get; set; }

        [JsonProperty("relations1")]
        public object[] Relations1 { get; set; }

        [JsonProperty("relations2")]
        public object[] Relations2 { get; set; }

        [JsonProperty("bankAccounts")]
        public BankAccount[] BankAccounts { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("addressId")]
        public long AddressId { get; set; }

        [JsonProperty("addressType")]
        public string AddressType { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("address")]
        public string AddressAddress { get; set; }

        [JsonProperty("apartmentNumber")]
        public object ApartmentNumber { get; set; }

        [JsonProperty("blockNumber")]
        
        public long BlockNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cityCode")]
        
        public long CityCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryState")]
        
        public long CountryState { get; set; }

        [JsonProperty("entranceNumber")]
        
        public long EntranceNumber { get; set; }

        [JsonProperty("floorNumber")]
        public object FloorNumber { get; set; }

        [JsonProperty("invoiceYn")]
        public string InvoiceYn { get; set; }

        [JsonProperty("mailYn")]
        public string MailYn { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("postCode")]
        
        public long PostCode { get; set; }

        [JsonProperty("primaryFlag")]
        public string PrimaryFlag { get; set; }

        [JsonProperty("quarterId")]
        
        public long QuarterId { get; set; }

        [JsonProperty("quarterName")]
        public object QuarterName { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("stateRegion")]
        
        public long StateRegion { get; set; }

        [JsonProperty("streetId")]
        public object StreetId { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("streetNumber")]
        
        public long StreetNumber { get; set; }

        [JsonProperty("territoryClassification")]
        public object TerritoryClassification { get; set; }

        [JsonProperty("usageDateFrom")]
        public object UsageDateFrom { get; set; }

        [JsonProperty("usageDateTo")]
        public object UsageDateTo { get; set; }

        [JsonProperty("validFrom")]
        public object ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

        [JsonProperty("personPid")]
        public Pid PersonPid { get; set; }
    }

    public partial class Pid
    {
        [JsonProperty("egn")]
        
        public long Egn { get; set; }

        [JsonProperty("manComp")]
        public long ManComp { get; set; }
    }

    public partial class BankAccount
    {
        [JsonProperty("accountCurrency")]
        public string AccountCurrency { get; set; }

        [JsonProperty("accountNum")]
        public string AccountNum { get; set; }

        [JsonProperty("accountState")]
        public long AccountState { get; set; }

        [JsonProperty("bankAccId")]
        public long BankAccId { get; set; }

        [JsonProperty("bankId")]
        public long BankId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("primaryFlag")]
        public string PrimaryFlag { get; set; }

        [JsonProperty("validFrom")]
        public object ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

        [JsonProperty("personPid")]
        public Pid PersonPid { get; set; }

        [JsonProperty("pBanks")]
        public PBanks PBanks { get; set; }
    }

    public partial class PBanks
    {
        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("bankId")]
        public long BankId { get; set; }

        [JsonProperty("mainBankId")]
        public object MainBankId { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("swiftCode")]
        public string SwiftCode { get; set; }

        [JsonProperty("bankPid")]
        public Pid BankPid { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("contactId")]
        public long ContactId { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("language")]
        public object Language { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("primaryFlag")]
        public string PrimaryFlag { get; set; }

        [JsonProperty("validFrom")]
        public object ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public object ValidTo { get; set; }

        [JsonProperty("personPid")]
        public Pid PersonPid { get; set; }
    }
}

