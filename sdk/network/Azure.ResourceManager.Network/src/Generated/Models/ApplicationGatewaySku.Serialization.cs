// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewaySku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name.Value.ToString());
            }
            if (Tier != null)
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier.Value.ToString());
            }
            if (Capacity != null)
            {
                writer.WritePropertyName("capacity");
                writer.WriteNumberValue(Capacity.Value);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewaySku DeserializeApplicationGatewaySku(JsonElement element)
        {
            ApplicationGatewaySkuName? name = default;
            ApplicationGatewayTier? tier = default;
            int? capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new ApplicationGatewaySkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new ApplicationGatewayTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
            }
            return new ApplicationGatewaySku(name, tier, capacity);
        }
    }
}
