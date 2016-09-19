// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for postAsyncRelativeRetryInvalidHeader operation.
    /// </summary>
    public partial class LROSADsPostAsyncRelativeRetryInvalidHeaderHeadersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LROSADsPostAsyncRelativeRetryInvalidHeaderHeadersInner class.
        /// </summary>
        public LROSADsPostAsyncRelativeRetryInvalidHeaderHeadersInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// LROSADsPostAsyncRelativeRetryInvalidHeaderHeadersInner class.
        /// </summary>
        /// <param name="azureAsyncOperation">Location to poll for result
        /// status: will be set to foo</param>
        /// <param name="location">Location to poll for result status: will be
        /// set to foo</param>
        /// <param name="retryAfter">Number of milliseconds until the next
        /// poll should be sent, will be set to /bar</param>
        public LROSADsPostAsyncRelativeRetryInvalidHeaderHeadersInner(string azureAsyncOperation = default(string), string location = default(string), int? retryAfter = default(int?))
        {
            AzureAsyncOperation = azureAsyncOperation;
            Location = location;
            RetryAfter = retryAfter;
        }

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to foo
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to foo
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets number of milliseconds until the next poll should be
        /// sent, will be set to /bar
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}
