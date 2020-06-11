// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> List of vaults. </summary>
    public partial class VaultListResult
    {
        /// <summary> Initializes a new instance of VaultListResult. </summary>
        internal VaultListResult()
        {
        }

        /// <summary> Initializes a new instance of VaultListResult. </summary>
        /// <param name="value"> The list of vaults. </param>
        /// <param name="nextLink"> The URL to get the next set of vaults. </param>
        internal VaultListResult(IReadOnlyList<Vault> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of vaults. </summary>
        public IReadOnlyList<Vault> Value { get; }
        /// <summary> The URL to get the next set of vaults. </summary>
        public string NextLink { get; }
    }
}
