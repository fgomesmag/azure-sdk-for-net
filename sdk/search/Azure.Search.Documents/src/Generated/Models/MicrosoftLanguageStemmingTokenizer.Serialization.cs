// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class MicrosoftLanguageStemmingTokenizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MaxTokenLength != null)
            {
                writer.WritePropertyName("maxTokenLength");
                writer.WriteNumberValue(MaxTokenLength.Value);
            }
            if (IsSearchTokenizer != null)
            {
                writer.WritePropertyName("isSearchTokenizer");
                writer.WriteBooleanValue(IsSearchTokenizer.Value);
            }
            if (Language != null)
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(Language.Value.ToSerialString());
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static MicrosoftLanguageStemmingTokenizer DeserializeMicrosoftLanguageStemmingTokenizer(JsonElement element)
        {
            int? maxTokenLength = default;
            bool? isSearchTokenizer = default;
            MicrosoftStemmingTokenizerLanguage? language = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxTokenLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTokenLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isSearchTokenizer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSearchTokenizer = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    language = property.Value.GetString().ToMicrosoftStemmingTokenizerLanguage();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new MicrosoftLanguageStemmingTokenizer(odataType, name, maxTokenLength, isSearchTokenizer, language);
        }
    }
}
