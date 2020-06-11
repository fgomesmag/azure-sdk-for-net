// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The type of the region. </summary>
    public readonly partial struct RegionType : IEquatable<RegionType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="RegionType"/> values are the same. </summary>
        public RegionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PhysicalValue = "Physical";
        private const string LogicalValue = "Logical";

        /// <summary> Physical. </summary>
        public static RegionType Physical { get; } = new RegionType(PhysicalValue);
        /// <summary> Logical. </summary>
        public static RegionType Logical { get; } = new RegionType(LogicalValue);
        /// <summary> Determines if two <see cref="RegionType"/> values are the same. </summary>
        public static bool operator ==(RegionType left, RegionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RegionType"/> values are not the same. </summary>
        public static bool operator !=(RegionType left, RegionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RegionType"/>. </summary>
        public static implicit operator RegionType(string value) => new RegionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RegionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RegionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
