// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace StorageImportExport.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ListLocationsResponse
    {
        /// <summary>
        /// Initializes a new instance of the ListLocationsResponse class.
        /// </summary>
        public ListLocationsResponse() { }

        /// <summary>
        /// Initializes a new instance of the ListLocationsResponse class.
        /// </summary>
        public ListLocationsResponse(string odatametadata = default(string), string odatacount = default(string), IList<ListLocationsResponseValueItem> value = default(IList<ListLocationsResponseValueItem>))
        {
            Odatametadata = odatametadata;
            Odatacount = odatacount;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.metadata")]
        public string Odatametadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.count")]
        public string Odatacount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ListLocationsResponseValueItem> Value { get; set; }

    }
}