// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the regional replication state. </summary>
    public readonly partial struct ReplicationState : IEquatable<ReplicationState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ReplicationState"/> values are the same. </summary>
        public ReplicationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ReplicatingValue = "Replicating";
        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";

        /// <summary> Unknown. </summary>
        public static ReplicationState Unknown { get; } = new ReplicationState(UnknownValue);
        /// <summary> Replicating. </summary>
        public static ReplicationState Replicating { get; } = new ReplicationState(ReplicatingValue);
        /// <summary> Completed. </summary>
        public static ReplicationState Completed { get; } = new ReplicationState(CompletedValue);
        /// <summary> Failed. </summary>
        public static ReplicationState Failed { get; } = new ReplicationState(FailedValue);
        /// <summary> Determines if two <see cref="ReplicationState"/> values are the same. </summary>
        public static bool operator ==(ReplicationState left, ReplicationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicationState"/> values are not the same. </summary>
        public static bool operator !=(ReplicationState left, ReplicationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReplicationState"/>. </summary>
        public static implicit operator ReplicationState(string value) => new ReplicationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
