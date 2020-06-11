// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class NetworkWatcherListResult
    {
        internal static NetworkWatcherListResult DeserializeNetworkWatcherListResult(JsonElement element)
        {
            IReadOnlyList<NetworkWatcher> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkWatcher> array = new List<NetworkWatcher>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(NetworkWatcher.DeserializeNetworkWatcher(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new NetworkWatcherListResult(value);
        }
    }
}
