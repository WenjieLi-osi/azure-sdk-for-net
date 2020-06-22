// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Quota counter value details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class QuotaCounterValueUpdateContract
    {
        /// <summary>
        /// Initializes a new instance of the QuotaCounterValueUpdateContract
        /// class.
        /// </summary>
        public QuotaCounterValueUpdateContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaCounterValueUpdateContract
        /// class.
        /// </summary>
        /// <param name="callsCount">Number of times Counter was
        /// called.</param>
        /// <param name="kbTransferred">Data Transferred in KiloBytes.</param>
        public QuotaCounterValueUpdateContract(int? callsCount = default(int?), double? kbTransferred = default(double?))
        {
            CallsCount = callsCount;
            KbTransferred = kbTransferred;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of times Counter was called.
        /// </summary>
        [JsonProperty(PropertyName = "properties.callsCount")]
        public int? CallsCount { get; set; }

        /// <summary>
        /// Gets or sets data Transferred in KiloBytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kbTransferred")]
        public double? KbTransferred { get; set; }

    }
}