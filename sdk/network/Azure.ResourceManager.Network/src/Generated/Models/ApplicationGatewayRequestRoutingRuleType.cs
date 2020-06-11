// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Rule type. </summary>
    public readonly partial struct ApplicationGatewayRequestRoutingRuleType : IEquatable<ApplicationGatewayRequestRoutingRuleType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ApplicationGatewayRequestRoutingRuleType"/> values are the same. </summary>
        public ApplicationGatewayRequestRoutingRuleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string PathBasedRoutingValue = "PathBasedRouting";

        /// <summary> Basic. </summary>
        public static ApplicationGatewayRequestRoutingRuleType Basic { get; } = new ApplicationGatewayRequestRoutingRuleType(BasicValue);
        /// <summary> PathBasedRouting. </summary>
        public static ApplicationGatewayRequestRoutingRuleType PathBasedRouting { get; } = new ApplicationGatewayRequestRoutingRuleType(PathBasedRoutingValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayRequestRoutingRuleType"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayRequestRoutingRuleType left, ApplicationGatewayRequestRoutingRuleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayRequestRoutingRuleType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayRequestRoutingRuleType left, ApplicationGatewayRequestRoutingRuleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayRequestRoutingRuleType"/>. </summary>
        public static implicit operator ApplicationGatewayRequestRoutingRuleType(string value) => new ApplicationGatewayRequestRoutingRuleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayRequestRoutingRuleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayRequestRoutingRuleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
