// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list WebApplicationFirewallPolicies. It contains a list of WebApplicationFirewallPolicy objects and a URL link to get the next set of results. </summary>
    public partial class WebApplicationFirewallPolicyListResult
    {
        /// <summary> Initializes a new instance of WebApplicationFirewallPolicyListResult. </summary>
        internal WebApplicationFirewallPolicyListResult()
        {
        }

        /// <summary> Initializes a new instance of WebApplicationFirewallPolicyListResult. </summary>
        /// <param name="value"> List of WebApplicationFirewallPolicies within a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of WebApplicationFirewallPolicy objects if there are any. </param>
        internal WebApplicationFirewallPolicyListResult(IReadOnlyList<WebApplicationFirewallPolicy> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of WebApplicationFirewallPolicies within a resource group. </summary>
        public IReadOnlyList<WebApplicationFirewallPolicy> Value { get; }
        /// <summary> URL to get the next set of WebApplicationFirewallPolicy objects if there are any. </summary>
        public string NextLink { get; }
    }
}
