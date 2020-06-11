// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class CaptureDescription : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Enabled != null)
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Encoding != null)
            {
                writer.WritePropertyName("encoding");
                writer.WriteStringValue(Encoding.Value.ToSerialString());
            }
            if (IntervalInSeconds != null)
            {
                writer.WritePropertyName("intervalInSeconds");
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (SizeLimitInBytes != null)
            {
                writer.WritePropertyName("sizeLimitInBytes");
                writer.WriteNumberValue(SizeLimitInBytes.Value);
            }
            if (Destination != null)
            {
                writer.WritePropertyName("destination");
                writer.WriteObjectValue(Destination);
            }
            if (SkipEmptyArchives != null)
            {
                writer.WritePropertyName("skipEmptyArchives");
                writer.WriteBooleanValue(SkipEmptyArchives.Value);
            }
            writer.WriteEndObject();
        }

        internal static CaptureDescription DeserializeCaptureDescription(JsonElement element)
        {
            bool? enabled = default;
            EncodingCaptureDescription? encoding = default;
            int? intervalInSeconds = default;
            int? sizeLimitInBytes = default;
            Destination destination = default;
            bool? skipEmptyArchives = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encoding"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encoding = property.Value.GetString().ToEncodingCaptureDescription();
                    continue;
                }
                if (property.NameEquals("intervalInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sizeLimitInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeLimitInBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("destination"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destination = Destination.DeserializeDestination(property.Value);
                    continue;
                }
                if (property.NameEquals("skipEmptyArchives"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipEmptyArchives = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CaptureDescription(enabled, encoding, intervalInSeconds, sizeLimitInBytes, destination, skipEmptyArchives);
        }
    }
}
