// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> The response from the List Usages operation. </summary>
    public partial class UsageListResult
    {
        /// <summary> Initializes a new instance of UsageListResult. </summary>
        internal UsageListResult()
        {
        }

        /// <summary> Initializes a new instance of UsageListResult. </summary>
        /// <param name="value"> Gets or sets the list of Storage Resource Usages. </param>
        internal UsageListResult(IReadOnlyList<Usage> value)
        {
            Value = value;
        }

        /// <summary> Gets or sets the list of Storage Resource Usages. </summary>
        public IReadOnlyList<Usage> Value { get; }
    }
}
