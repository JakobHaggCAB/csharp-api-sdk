using System;
using Fortnox.SDK.Serialization;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global

namespace Fortnox.SDK.Entities
{
    /// <remarks/>
    [Entity(SingularName = "InvoiceAccrual", PluralName = "InvoiceAccruals")]
    public class InvoiceAccrualSubset
    {
        ///<summary> Direct URL to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public Uri Url { get; private set; }

        ///<summary> Description of the accrual </summary>
        [JsonProperty]
        public string Description { get; set; }

        ///<summary> Invoice number </summary>
        [JsonProperty]
        public long? InvoiceNumber { get; set; }

        ///<summary> Type of period </summary>
        [JsonProperty]
        public string Period { get; set; }
    }
}
