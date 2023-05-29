﻿using Newtonsoft.Json;

namespace Cl.Sura.ESoapApi.Models.Request.RegistroEvaluacion
{
    public class RegistroEvaluacionRequest
    {
        [JsonProperty("claimId")]
        public long ClaimId { get; set; }

        [JsonProperty("requestNo")]
        public long RequestNo { get; set; }

        [JsonProperty("claimObjectSeq")]
        public long ClaimObjectSeq { get; set; }

        [JsonProperty("inspectDate")]
        public DateTimeOffset InspectDate { get; set; }

        [JsonProperty("manId")]
        public long ManId { get; set; }

        [JsonProperty("expertSum")]
        public long ExpertSum { get; set; }

        [JsonProperty("expertSumCurrency")]
        public string ExpertSumCurrency { get; set; }

        [JsonProperty("lossSize")]

        public long LossSize { get; set; }

        [JsonProperty("actualValue")]
        public long ActualValue { get; set; }

        [JsonProperty("avCurrency")]
        public string AvCurrency { get; set; }

        [JsonProperty("invoiceNo")]

        public long InvoiceNo { get; set; }
    }
}
