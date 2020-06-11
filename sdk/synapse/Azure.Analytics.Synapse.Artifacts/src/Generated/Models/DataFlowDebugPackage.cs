// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for starting data flow debug session. </summary>
    public partial class DataFlowDebugPackage : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of DataFlowDebugPackage. </summary>
        public DataFlowDebugPackage()
        {
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary> Initializes a new instance of DataFlowDebugPackage. </summary>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="dataFlow"> Data flow instance. </param>
        /// <param name="datasets"> List of datasets. </param>
        /// <param name="linkedServices"> List of linked services. </param>
        /// <param name="staging"> Staging info for debug session. </param>
        /// <param name="debugSettings"> Data flow debug settings. </param>
        /// <param name="additionalProperties"> . </param>
        internal DataFlowDebugPackage(string sessionId, DataFlowDebugResource dataFlow, IList<DatasetDebugResource> datasets, IList<LinkedServiceDebugResource> linkedServices, DataFlowStagingInfo staging, DataFlowDebugPackageDebugSettings debugSettings, IDictionary<string, object> additionalProperties)
        {
            SessionId = sessionId;
            DataFlow = dataFlow;
            Datasets = datasets;
            LinkedServices = linkedServices;
            Staging = staging;
            DebugSettings = debugSettings;
            AdditionalProperties = additionalProperties ?? new Dictionary<string, object>();
        }

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; set; }
        /// <summary> Data flow instance. </summary>
        public DataFlowDebugResource DataFlow { get; set; }
        /// <summary> List of datasets. </summary>
        public IList<DatasetDebugResource> Datasets { get; set; }
        /// <summary> List of linked services. </summary>
        public IList<LinkedServiceDebugResource> LinkedServices { get; set; }
        /// <summary> Staging info for debug session. </summary>
        public DataFlowStagingInfo Staging { get; set; }
        /// <summary> Data flow debug settings. </summary>
        public DataFlowDebugPackageDebugSettings DebugSettings { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
