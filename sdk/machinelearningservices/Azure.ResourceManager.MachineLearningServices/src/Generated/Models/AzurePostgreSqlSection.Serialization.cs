// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class AzurePostgreSqlSection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableSSL))
            {
                writer.WritePropertyName("enableSSL");
                writer.WriteBooleanValue(EnableSSL.Value);
            }
            writer.WritePropertyName("credentials");
            writer.WriteObjectValue(Credentials);
            writer.WritePropertyName("databaseName");
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("endpoint");
            writer.WriteStringValue(Endpoint);
            writer.WritePropertyName("portNumber");
            writer.WriteNumberValue(PortNumber);
            writer.WritePropertyName("serverName");
            writer.WriteStringValue(ServerName);
            writer.WriteEndObject();
        }

        internal static AzurePostgreSqlSection DeserializeAzurePostgreSqlSection(JsonElement element)
        {
            Optional<bool> enableSSL = default;
            DatastoreCredentials credentials = default;
            string databaseName = default;
            string endpoint = default;
            int portNumber = default;
            string serverName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableSSL"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableSSL = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    credentials = DatastoreCredentials.DeserializeDatastoreCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("portNumber"))
                {
                    portNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serverName"))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
            }
            return new AzurePostgreSqlSection(Optional.ToNullable(enableSSL), credentials, databaseName, endpoint, portNumber, serverName);
        }
    }
}
