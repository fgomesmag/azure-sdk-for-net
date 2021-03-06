// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Purview.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Account access keys.
    /// </summary>
    public partial class AccessKeys
    {
        /// <summary>
        /// Initializes a new instance of the AccessKeys class.
        /// </summary>
        public AccessKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessKeys class.
        /// </summary>
        /// <param name="atlasKafkaPrimaryEndpoint">Gets or sets the primary
        /// connection string.</param>
        /// <param name="atlasKafkaSecondaryEndpoint">Gets or sets the
        /// secondary connection string.</param>
        public AccessKeys(string atlasKafkaPrimaryEndpoint = default(string), string atlasKafkaSecondaryEndpoint = default(string))
        {
            AtlasKafkaPrimaryEndpoint = atlasKafkaPrimaryEndpoint;
            AtlasKafkaSecondaryEndpoint = atlasKafkaSecondaryEndpoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary connection string.
        /// </summary>
        [JsonProperty(PropertyName = "atlasKafkaPrimaryEndpoint")]
        public string AtlasKafkaPrimaryEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the secondary connection string.
        /// </summary>
        [JsonProperty(PropertyName = "atlasKafkaSecondaryEndpoint")]
        public string AtlasKafkaSecondaryEndpoint { get; set; }

    }
}
