// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Response body structure of data flow query for data preview, statistics or expression preview. </summary>
    internal partial class DataFlowDebugQueryResponse
    {
        /// <summary> Initializes a new instance of DataFlowDebugQueryResponse. </summary>
        internal DataFlowDebugQueryResponse()
        {
        }

        /// <summary> Initializes a new instance of DataFlowDebugQueryResponse. </summary>
        /// <param name="runId"> The run ID of data flow debug session. </param>
        internal DataFlowDebugQueryResponse(string runId)
        {
            RunId = runId;
        }

        /// <summary> The run ID of data flow debug session. </summary>
        public string RunId { get; set; }
    }
}
