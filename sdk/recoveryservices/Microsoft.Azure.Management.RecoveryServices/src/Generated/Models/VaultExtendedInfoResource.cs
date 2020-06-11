// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Vault extended information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VaultExtendedInfoResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VaultExtendedInfoResource class.
        /// </summary>
        public VaultExtendedInfoResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultExtendedInfoResource class.
        /// </summary>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        /// <param name="eTag">Optional ETag.</param>
        /// <param name="integrityKey">Integrity key.</param>
        /// <param name="encryptionKey">Encryption key.</param>
        /// <param name="encryptionKeyThumbprint">Encryption key
        /// thumbprint.</param>
        /// <param name="algorithm">Algorithm for Vault ExtendedInfo</param>
        public VaultExtendedInfoResource(string id = default(string), string name = default(string), string type = default(string), string eTag = default(string), string integrityKey = default(string), string encryptionKey = default(string), string encryptionKeyThumbprint = default(string), string algorithm = default(string))
            : base(id, name, type, eTag)
        {
            IntegrityKey = integrityKey;
            EncryptionKey = encryptionKey;
            EncryptionKeyThumbprint = encryptionKeyThumbprint;
            Algorithm = algorithm;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets integrity key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.integrityKey")]
        public string IntegrityKey { get; set; }

        /// <summary>
        /// Gets or sets encryption key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionKey")]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Gets or sets encryption key thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionKeyThumbprint")]
        public string EncryptionKeyThumbprint { get; set; }

        /// <summary>
        /// Gets or sets algorithm for Vault ExtendedInfo
        /// </summary>
        [JsonProperty(PropertyName = "properties.algorithm")]
        public string Algorithm { get; set; }

    }
}
