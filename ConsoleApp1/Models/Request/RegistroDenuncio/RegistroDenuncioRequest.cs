
using Newtonsoft.Json;

namespace Cl.Sura.QuartzESoap.Models.Request.RegistroDenuncio
{
    public class RegistroDenuncioRequest { 
   [JsonProperty("claimGroup")]
    public ClaimGroup ClaimGroup { get; set; }
}

public partial class ClaimGroup
{
    [JsonProperty("policyNo")]
    
    public string PolicyNo { get; set; }

    [JsonProperty("causeId")]
    public long CauseId { get; set; }

    [JsonProperty("claimCategory")]
    public string ClaimCategory { get; set; }

    [JsonProperty("eventType")]
    public long EventType { get; set; }

    [JsonProperty("eventDate")]
    public string EventDate { get; set; }

    [JsonProperty("eventDescription")]
    public string EventDescription { get; set; }

    [JsonProperty("eventCountry")]
    public string EventCountry { get; set; }

    [JsonProperty("eventPlace")]
    public string EventPlace { get; set; }

    [JsonProperty("claimComment")]
    public string ClaimComment { get; set; }
}
}
