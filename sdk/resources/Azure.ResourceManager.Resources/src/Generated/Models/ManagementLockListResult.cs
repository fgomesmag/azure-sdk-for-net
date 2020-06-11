// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The list of locks. </summary>
    public partial class ManagementLockListResult
    {
        /// <summary> Initializes a new instance of ManagementLockListResult. </summary>
        internal ManagementLockListResult()
        {
        }

        /// <summary> Initializes a new instance of ManagementLockListResult. </summary>
        /// <param name="value"> The list of locks. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ManagementLockListResult(IReadOnlyList<ManagementLockObject> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of locks. </summary>
        public IReadOnlyList<ManagementLockObject> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
