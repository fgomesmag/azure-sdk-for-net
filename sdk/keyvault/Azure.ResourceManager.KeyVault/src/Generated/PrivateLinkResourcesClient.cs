// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> The PrivateLinkResources service client. </summary>
    public partial class PrivateLinkResourcesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PrivateLinkResourcesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PrivateLinkResourcesClient for mocking. </summary>
        protected PrivateLinkResourcesClient()
        {
        }
        /// <summary> Initializes a new instance of PrivateLinkResourcesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal PrivateLinkResourcesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-09-01")
        {
            RestClient = new PrivateLinkResourcesRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the private link resources supported for the key vault. </summary>
        /// <param name="resourceGroupName"> Name of the resource group that contains the key vault. </param>
        /// <param name="vaultName"> The name of the key vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateLinkResourceListResult>> ListByVaultAsync(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesClient.ListByVault");
            scope.Start();
            try
            {
                return await RestClient.ListByVaultAsync(resourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private link resources supported for the key vault. </summary>
        /// <param name="resourceGroupName"> Name of the resource group that contains the key vault. </param>
        /// <param name="vaultName"> The name of the key vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateLinkResourceListResult> ListByVault(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesClient.ListByVault");
            scope.Start();
            try
            {
                return RestClient.ListByVault(resourceGroupName, vaultName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
