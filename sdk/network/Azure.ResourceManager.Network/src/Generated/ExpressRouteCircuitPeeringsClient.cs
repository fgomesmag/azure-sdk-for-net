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
    /// <summary> The ExpressRouteCircuitPeerings service client. </summary>
    public partial class ExpressRouteCircuitPeeringsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExpressRouteCircuitPeeringsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringsClient for mocking. </summary>
        protected ExpressRouteCircuitPeeringsClient()
        {
        }
        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ExpressRouteCircuitPeeringsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ExpressRouteCircuitPeeringsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified peering for the express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCircuitPeering>> GetAsync(string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, circuitName, peeringName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified peering for the express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitPeering> Get(string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, circuitName, peeringName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all peerings in a specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRouteCircuitPeering> ListAsync(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            async Task<Page<ExpressRouteCircuitPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, circuitName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCircuitPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, circuitName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all peerings in a specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRouteCircuitPeering> List(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            Page<ExpressRouteCircuitPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, circuitName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCircuitPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, circuitName, cancellationToken);
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

        /// <summary> Deletes the specified peering from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ExpressRouteCircuitPeeringsDeleteOperation> StartDeleteAsync(string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, circuitName, peeringName, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCircuitPeeringsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, circuitName, peeringName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified peering from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCircuitPeeringsDeleteOperation StartDelete(string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, circuitName, peeringName, cancellationToken);
                return new ExpressRouteCircuitPeeringsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, circuitName, peeringName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a peering in the specified express route circuits. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update express route circuit peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ExpressRouteCircuitPeeringsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, circuitName, peeringName, peeringParameters, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCircuitPeeringsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, circuitName, peeringName, peeringParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a peering in the specified express route circuits. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update express route circuit peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCircuitPeeringsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, circuitName, peeringName, peeringParameters, cancellationToken);
                return new ExpressRouteCircuitPeeringsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, circuitName, peeringName, peeringParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
