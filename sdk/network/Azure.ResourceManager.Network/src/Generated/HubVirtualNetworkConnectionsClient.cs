// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The HubVirtualNetworkConnections service client. </summary>
    public partial class HubVirtualNetworkConnectionsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal HubVirtualNetworkConnectionsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of HubVirtualNetworkConnectionsClient for mocking. </summary>
        protected HubVirtualNetworkConnectionsClient()
        {
        }
        /// <summary> Initializes a new instance of HubVirtualNetworkConnectionsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal HubVirtualNetworkConnectionsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new HubVirtualNetworkConnectionsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the details of a HubVirtualNetworkConnection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HubVirtualNetworkConnection>> GetAsync(string resourceGroupName, string virtualHubName, string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, virtualHubName, connectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a HubVirtualNetworkConnection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HubVirtualNetworkConnection> Get(string resourceGroupName, string virtualHubName, string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, virtualHubName, connectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of all HubVirtualNetworkConnections. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<HubVirtualNetworkConnection> ListAsync(string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            async Task<Page<HubVirtualNetworkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, virtualHubName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HubVirtualNetworkConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, virtualHubName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves the details of all HubVirtualNetworkConnections. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<HubVirtualNetworkConnection> List(string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            Page<HubVirtualNetworkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, virtualHubName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HubVirtualNetworkConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, virtualHubName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
