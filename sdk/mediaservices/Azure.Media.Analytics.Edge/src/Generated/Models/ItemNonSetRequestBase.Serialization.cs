// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class ItemNonSetRequestBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion");
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static ItemNonSetRequestBase DeserializeItemNonSetRequestBase(JsonElement element)
        {
            if (element.TryGetProperty("methodName", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "GraphInstanceActivate": return MediaGraphInstanceActivateRequest.DeserializeMediaGraphInstanceActivateRequest(element);
                    case "GraphInstanceDeactivate": return MediaGraphInstanceDeActivateRequest.DeserializeMediaGraphInstanceDeActivateRequest(element);
                    case "GraphInstanceDelete": return MediaGraphInstanceDeleteRequest.DeserializeMediaGraphInstanceDeleteRequest(element);
                    case "GraphInstanceGet": return MediaGraphInstanceGetRequest.DeserializeMediaGraphInstanceGetRequest(element);
                    case "GraphTopologyDelete": return MediaGraphTopologyDeleteRequest.DeserializeMediaGraphTopologyDeleteRequest(element);
                    case "GraphTopologyGet": return MediaGraphTopologyGetRequest.DeserializeMediaGraphTopologyGetRequest(element);
                }
            }
            string name = default;
            string methodName = default;
            Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("methodName"))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ItemNonSetRequestBase(methodName, apiVersion.Value, name);
        }
    }
}
