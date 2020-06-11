// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListServiceEndpointPolicyDefinition API service call. Retrieves all service endpoint policy definition that belongs to a service endpoint policy. </summary>
    public partial class ServiceEndpointPolicyDefinitionListResult
    {
        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionListResult. </summary>
        internal ServiceEndpointPolicyDefinitionListResult()
        {
        }

        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionListResult. </summary>
        /// <param name="value"> The service endpoint policy definition in a service endpoint policy. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ServiceEndpointPolicyDefinitionListResult(IReadOnlyList<ServiceEndpointPolicyDefinition> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The service endpoint policy definition in a service endpoint policy. </summary>
        public IReadOnlyList<ServiceEndpointPolicyDefinition> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
