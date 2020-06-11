// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> The VirtualMachineExtensions service client. </summary>
    public partial class VirtualMachineExtensionsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VirtualMachineExtensionsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of VirtualMachineExtensionsClient for mocking. </summary>
        protected VirtualMachineExtensionsClient()
        {
        }
        /// <summary> Initializes a new instance of VirtualMachineExtensionsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VirtualMachineExtensionsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VirtualMachineExtensionsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> The operation to get the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine containing the extension. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualMachineExtension>> GetAsync(string resourceGroupName, string vmName, string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, vmName, vmExtensionName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine containing the extension. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualMachineExtension> Get(string resourceGroupName, string vmName, string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, vmName, vmExtensionName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all extensions of a Virtual Machine. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine containing the extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualMachineExtensionsListResult>> ListAsync(string resourceGroupName, string vmName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(resourceGroupName, vmName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all extensions of a Virtual Machine. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine containing the extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualMachineExtensionsListResult> List(string resourceGroupName, string vmName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.List");
            scope.Start();
            try
            {
                return RestClient.List(resourceGroupName, vmName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine where the extension should be created or updated. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VirtualMachineExtensionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineExtensionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vmName, vmExtensionName, extensionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine where the extension should be created or updated. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineExtensionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, vmName, vmExtensionName, extensionParameters, cancellationToken);
                return new VirtualMachineExtensionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vmName, vmExtensionName, extensionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to update the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine where the extension should be updated. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VirtualMachineExtensionsUpdateOperation> StartUpdateAsync(string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineExtensionsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, vmName, vmExtensionName, extensionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to update the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine where the extension should be updated. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineExtensionsUpdateOperation StartUpdate(string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, vmName, vmExtensionName, extensionParameters, cancellationToken);
                return new VirtualMachineExtensionsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, vmName, vmExtensionName, extensionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to delete the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine where the extension should be deleted. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VirtualMachineExtensionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string vmName, string vmExtensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, vmName, vmExtensionName, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineExtensionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vmName, vmExtensionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to delete the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine where the extension should be deleted. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineExtensionsDeleteOperation StartDelete(string resourceGroupName, string vmName, string vmExtensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, vmName, vmExtensionName, cancellationToken);
                return new VirtualMachineExtensionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vmName, vmExtensionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
