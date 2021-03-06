// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Origin properties needed for origin update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OriginUpdateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the OriginUpdateParameters class.
        /// </summary>
        public OriginUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OriginUpdateParameters class.
        /// </summary>
        /// <param name="hostName">The address of the origin. Domain names,
        /// IPv4 addresses, and IPv6 addresses are supported.This should be
        /// unique across all origins in an endpoint.</param>
        /// <param name="httpPort">The value of the HTTP port. Must be between
        /// 1 and 65535.</param>
        /// <param name="httpsPort">The value of the HTTPS port. Must be
        /// between 1 and 65535.</param>
        /// <param name="originHostHeader">The host header value sent to the
        /// origin with each request. If you leave this blank, the request
        /// hostname determines this value. Azure CDN origins, such as Web
        /// Apps, Blob Storage, and Cloud Services require this host header
        /// value to match the origin hostname by default. This overrides the
        /// host header defined at Endpoint</param>
        /// <param name="priority">Priority of origin in given origin group for
        /// load balancing. Higher priorities will not be used for load
        /// balancing if any lower priority origin is healthy.Must be between 1
        /// and 5</param>
        /// <param name="weight">Weight of the origin in given origin group for
        /// load balancing. Must be between 1 and 1000</param>
        /// <param name="enabled">Origin is enabled for load balancing or
        /// not</param>
        /// <param name="privateLinkAlias">The Alias of the Private Link
        /// resource. Populating this optional field indicates that this origin
        /// is 'Private'</param>
        /// <param name="privateLinkResourceId">The Resource Id of the Private
        /// Link resource. Populating this optional field indicates that this
        /// backend is 'Private'</param>
        /// <param name="privateLinkLocation">The location of the Private Link
        /// resource. Required only if 'privateLinkResourceId' is
        /// populated</param>
        /// <param name="privateLinkApprovalMessage">A custom message to be
        /// included in the approval request to connect to the Private
        /// Link.</param>
        public OriginUpdateParameters(string hostName = default(string), int? httpPort = default(int?), int? httpsPort = default(int?), string originHostHeader = default(string), int? priority = default(int?), int? weight = default(int?), bool? enabled = default(bool?), string privateLinkAlias = default(string), string privateLinkResourceId = default(string), string privateLinkLocation = default(string), string privateLinkApprovalMessage = default(string))
        {
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            OriginHostHeader = originHostHeader;
            Priority = priority;
            Weight = weight;
            Enabled = enabled;
            PrivateLinkAlias = privateLinkAlias;
            PrivateLinkResourceId = privateLinkResourceId;
            PrivateLinkLocation = privateLinkLocation;
            PrivateLinkApprovalMessage = privateLinkApprovalMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the address of the origin. Domain names, IPv4
        /// addresses, and IPv6 addresses are supported.This should be unique
        /// across all origins in an endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTP port. Must be between 1 and
        /// 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpPort")]
        public int? HttpPort { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTPS port. Must be between 1 and
        /// 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpsPort")]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// Gets or sets the host header value sent to the origin with each
        /// request. If you leave this blank, the request hostname determines
        /// this value. Azure CDN origins, such as Web Apps, Blob Storage, and
        /// Cloud Services require this host header value to match the origin
        /// hostname by default. This overrides the host header defined at
        /// Endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.originHostHeader")]
        public string OriginHostHeader { get; set; }

        /// <summary>
        /// Gets or sets priority of origin in given origin group for load
        /// balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets weight of the origin in given origin group for load
        /// balancing. Must be between 1 and 1000
        /// </summary>
        [JsonProperty(PropertyName = "properties.weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets origin is enabled for load balancing or not
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the Alias of the Private Link resource. Populating
        /// this optional field indicates that this origin is 'Private'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkAlias")]
        public string PrivateLinkAlias { get; set; }

        /// <summary>
        /// Gets or sets the Resource Id of the Private Link resource.
        /// Populating this optional field indicates that this backend is
        /// 'Private'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkResourceId")]
        public string PrivateLinkResourceId { get; set; }

        /// <summary>
        /// Gets or sets the location of the Private Link resource. Required
        /// only if 'privateLinkResourceId' is populated
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkLocation")]
        public string PrivateLinkLocation { get; set; }

        /// <summary>
        /// Gets or sets a custom message to be included in the approval
        /// request to connect to the Private Link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkApprovalMessage")]
        public string PrivateLinkApprovalMessage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HttpPort > 65535)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpPort", 65535);
            }
            if (HttpPort < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpPort", 1);
            }
            if (HttpsPort > 65535)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpsPort", 65535);
            }
            if (HttpsPort < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpsPort", 1);
            }
            if (Priority > 5)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 5);
            }
            if (Priority < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 1);
            }
            if (Weight > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Weight", 1000);
            }
            if (Weight < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Weight", 1);
            }
        }
    }
}
