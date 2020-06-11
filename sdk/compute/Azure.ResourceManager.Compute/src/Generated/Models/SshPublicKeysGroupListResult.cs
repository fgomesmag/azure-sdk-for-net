// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The list SSH public keys operation response. </summary>
    public partial class SshPublicKeysGroupListResult
    {
        /// <summary> Initializes a new instance of SshPublicKeysGroupListResult. </summary>
        /// <param name="value"> The list of SSH public keys. </param>
        internal SshPublicKeysGroupListResult(IEnumerable<SshPublicKeyResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of SshPublicKeysGroupListResult. </summary>
        /// <param name="value"> The list of SSH public keys. </param>
        /// <param name="nextLink"> The URI to fetch the next page of SSH public keys. Call ListNext() with this URI to fetch the next page of SSH public keys. </param>
        internal SshPublicKeysGroupListResult(IReadOnlyList<SshPublicKeyResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of SSH public keys. </summary>
        public IReadOnlyList<SshPublicKeyResource> Value { get; }
        /// <summary> The URI to fetch the next page of SSH public keys. Call ListNext() with this URI to fetch the next page of SSH public keys. </summary>
        public string NextLink { get; }
    }
}
