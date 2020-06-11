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
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> The Queue service client. </summary>
    public partial class QueueClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal QueueRestClient RestClient { get; }
        /// <summary> Initializes a new instance of QueueClient for mocking. </summary>
        protected QueueClient()
        {
        }
        /// <summary> Initializes a new instance of QueueClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal QueueClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-06-01")
        {
            RestClient = new QueueRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates a new queue with the specified queue name, under the specified account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="queue"> Queue properties and metadata to be created with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageQueue>> CreateAsync(string resourceGroupName, string accountName, string queueName, StorageQueue queue, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(resourceGroupName, accountName, queueName, queue, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new queue with the specified queue name, under the specified account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="queue"> Queue properties and metadata to be created with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageQueue> Create(string resourceGroupName, string accountName, string queueName, StorageQueue queue, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(resourceGroupName, accountName, queueName, queue, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new queue with the specified queue name, under the specified account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="queue"> Queue properties and metadata to be created with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageQueue>> UpdateAsync(string resourceGroupName, string accountName, string queueName, StorageQueue queue, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, accountName, queueName, queue, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new queue with the specified queue name, under the specified account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="queue"> Queue properties and metadata to be created with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageQueue> Update(string resourceGroupName, string accountName, string queueName, StorageQueue queue, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, accountName, queueName, queue, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the queue with the specified queue name, under the specified account if it exists. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageQueue>> GetAsync(string resourceGroupName, string accountName, string queueName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, accountName, queueName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the queue with the specified queue name, under the specified account if it exists. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageQueue> Get(string resourceGroupName, string accountName, string queueName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, accountName, queueName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the queue with the specified queue name, under the specified account if it exists. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string accountName, string queueName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, accountName, queueName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the queue with the specified queue name, under the specified account if it exists. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string accountName, string queueName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, accountName, queueName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all the queues under the specified storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, a maximum number of queues that should be included in a list queue response. </param>
        /// <param name="filter"> Optional, When specified, only the queues with a name starting with the given filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ListQueue> ListAsync(string resourceGroupName, string accountName, string maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            async Task<Page<ListQueue>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("QueueClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, accountName, maxpagesize, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ListQueue>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("QueueClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, accountName, maxpagesize, filter, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets a list of all the queues under the specified storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, a maximum number of queues that should be included in a list queue response. </param>
        /// <param name="filter"> Optional, When specified, only the queues with a name starting with the given filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ListQueue> List(string resourceGroupName, string accountName, string maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            Page<ListQueue> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("QueueClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, accountName, maxpagesize, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ListQueue> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("QueueClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, accountName, maxpagesize, filter, cancellationToken);
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
