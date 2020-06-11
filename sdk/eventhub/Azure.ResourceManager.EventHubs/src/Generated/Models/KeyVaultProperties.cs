// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties to configure keyVault Properties. </summary>
    public partial class KeyVaultProperties
    {
        /// <summary> Initializes a new instance of KeyVaultProperties. </summary>
        public KeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of KeyVaultProperties. </summary>
        /// <param name="keyName"> Name of the Key from KeyVault. </param>
        /// <param name="keyVaultUri"> Uri of KeyVault. </param>
        /// <param name="keyVersion"> Key Version. </param>
        internal KeyVaultProperties(string keyName, string keyVaultUri, string keyVersion)
        {
            KeyName = keyName;
            KeyVaultUri = keyVaultUri;
            KeyVersion = keyVersion;
        }

        /// <summary> Name of the Key from KeyVault. </summary>
        public string KeyName { get; set; }
        /// <summary> Uri of KeyVault. </summary>
        public string KeyVaultUri { get; set; }
        /// <summary> Key Version. </summary>
        public string KeyVersion { get; set; }
    }
}
