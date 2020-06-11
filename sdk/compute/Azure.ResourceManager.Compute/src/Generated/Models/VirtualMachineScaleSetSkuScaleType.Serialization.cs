// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    internal static class VirtualMachineScaleSetSkuScaleTypeExtensions
    {
        public static string ToSerialString(this VirtualMachineScaleSetSkuScaleType value) => value switch
        {
            VirtualMachineScaleSetSkuScaleType.Automatic => "Automatic",
            VirtualMachineScaleSetSkuScaleType.None => "None",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VirtualMachineScaleSetSkuScaleType value.")
        };

        public static VirtualMachineScaleSetSkuScaleType ToVirtualMachineScaleSetSkuScaleType(this string value)
        {
            if (string.Equals(value, "Automatic", StringComparison.InvariantCultureIgnoreCase)) return VirtualMachineScaleSetSkuScaleType.Automatic;
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return VirtualMachineScaleSetSkuScaleType.None;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VirtualMachineScaleSetSkuScaleType value.");
        }
    }
}
