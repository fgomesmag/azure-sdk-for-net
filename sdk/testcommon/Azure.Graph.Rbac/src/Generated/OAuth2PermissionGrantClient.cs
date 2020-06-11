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
using Azure.Graph.Rbac.Models;

namespace Azure.Graph.Rbac
{
    /// <summary> The OAuth2PermissionGrant service client. </summary>
    public partial class OAuth2PermissionGrantClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal OAuth2PermissionGrantRestClient RestClient { get; }
        /// <summary> Initializes a new instance of OAuth2PermissionGrantClient for mocking. </summary>
        protected OAuth2PermissionGrantClient()
        {
        }
        /// <summary> Initializes a new instance of OAuth2PermissionGrantClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tenantID"> The tenant ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal OAuth2PermissionGrantClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string tenantID, Uri endpoint = null, string apiVersion = "1.6")
        {
            RestClient = new OAuth2PermissionGrantRestClient(clientDiagnostics, pipeline, tenantID, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Grants OAuth2 permissions for the relevant resource Ids of an app. </summary>
        /// <param name="body"> The relevant app Service Principal Object Id and the Service Principal Object Id you want to grant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OAuth2PermissionGrant>> CreateAsync(OAuth2PermissionGrant body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Grants OAuth2 permissions for the relevant resource Ids of an app. </summary>
        /// <param name="body"> The relevant app Service Principal Object Id and the Service Principal Object Id you want to grant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OAuth2PermissionGrant> Create(OAuth2PermissionGrant body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a OAuth2 permission grant for the relevant resource Ids of an app. </summary>
        /// <param name="objectId"> The object ID of a permission grant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string objectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(objectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a OAuth2 permission grant for the relevant resource Ids of an app. </summary>
        /// <param name="objectId"> The object ID of a permission grant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string objectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(objectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Queries OAuth2 permissions grants for the relevant SP ObjectId of an app. </summary>
        /// <param name="filter"> This is the Service Principal ObjectId associated with the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<OAuth2PermissionGrant> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OAuth2PermissionGrant>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OAuth2PermissionGrant>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Queries OAuth2 permissions grants for the relevant SP ObjectId of an app. </summary>
        /// <param name="filter"> This is the Service Principal ObjectId associated with the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<OAuth2PermissionGrant> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<OAuth2PermissionGrant> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OAuth2PermissionGrant> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the next page of OAuth2 permission grants. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<OAuth2PermissionGrant> ListNextAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            async Task<Page<OAuth2PermissionGrant>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.ListNext");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OAuth2PermissionGrant>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.ListNext");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the next page of OAuth2 permission grants. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<OAuth2PermissionGrant> ListNext(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Page<OAuth2PermissionGrant> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.ListNext");
                scope.Start();
                try
                {
                    var response = RestClient.ListNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OAuth2PermissionGrant> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OAuth2PermissionGrantClient.ListNext");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
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
