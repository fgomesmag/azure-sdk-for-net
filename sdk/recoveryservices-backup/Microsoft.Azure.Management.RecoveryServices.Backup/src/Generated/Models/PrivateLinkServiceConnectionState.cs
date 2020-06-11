// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Private Link Service Connection State
    /// </summary>
    public partial class PrivateLinkServiceConnectionState
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnectionState
        /// class.
        /// </summary>
        public PrivateLinkServiceConnectionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnectionState
        /// class.
        /// </summary>
        /// <param name="status">Gets or sets the status. Possible values
        /// include: 'Pending', 'Approved', 'Rejected', 'Disconnected'</param>
        /// <param name="description">Gets or sets description</param>
        /// <param name="actionRequired">Gets or sets actions required</param>
        public PrivateLinkServiceConnectionState(string status = default(string), string description = default(string), string actionRequired = default(string))
        {
            Status = status;
            Description = description;
            ActionRequired = actionRequired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status. Possible values include: 'Pending',
        /// 'Approved', 'Rejected', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets actions required
        /// </summary>
        [JsonProperty(PropertyName = "actionRequired")]
        public string ActionRequired { get; set; }

    }
}
