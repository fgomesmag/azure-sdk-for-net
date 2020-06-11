// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyNatRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Action != null)
            {
                writer.WritePropertyName("action");
                writer.WriteObjectValue(Action);
            }
            if (TranslatedAddress != null)
            {
                writer.WritePropertyName("translatedAddress");
                writer.WriteStringValue(TranslatedAddress);
            }
            if (TranslatedPort != null)
            {
                writer.WritePropertyName("translatedPort");
                writer.WriteStringValue(TranslatedPort);
            }
            if (RuleCondition != null)
            {
                writer.WritePropertyName("ruleCondition");
                writer.WriteObjectValue(RuleCondition);
            }
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Priority != null)
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyNatRule DeserializeFirewallPolicyNatRule(JsonElement element)
        {
            FirewallPolicyNatRuleAction action = default;
            string translatedAddress = default;
            string translatedPort = default;
            FirewallPolicyRuleCondition ruleCondition = default;
            FirewallPolicyRuleType ruleType = default;
            string name = default;
            int? priority = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = FirewallPolicyNatRuleAction.DeserializeFirewallPolicyNatRuleAction(property.Value);
                    continue;
                }
                if (property.NameEquals("translatedAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    translatedAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translatedPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    translatedPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCondition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ruleCondition = FirewallPolicyRuleCondition.DeserializeFirewallPolicyRuleCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = new FirewallPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
            }
            return new FirewallPolicyNatRule(ruleType, name, priority, action, translatedAddress, translatedPort, ruleCondition);
        }
    }
}
