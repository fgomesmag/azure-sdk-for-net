// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Post request for all the Bastion Shareable Link endpoints. </summary>
    public partial class BastionShareableLinkListRequest
    {
        /// <summary> Initializes a new instance of BastionShareableLinkListRequest. </summary>
        public BastionShareableLinkListRequest()
        {
        }

        /// <summary> Initializes a new instance of BastionShareableLinkListRequest. </summary>
        /// <param name="vms"> List of VM references. </param>
        internal BastionShareableLinkListRequest(IList<BastionShareableLink> vms)
        {
            Vms = vms;
        }

        /// <summary> List of VM references. </summary>
        public IList<BastionShareableLink> Vms { get; set; }
    }
}
