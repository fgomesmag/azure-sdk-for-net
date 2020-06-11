// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Outbound rule of the load balancer. </summary>
    public partial class OutboundRule : SubResource
    {
        /// <summary> Initializes a new instance of OutboundRule. </summary>
        public OutboundRule()
        {
        }

        /// <summary> Initializes a new instance of OutboundRule. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within the set of outbound rules used by the load balancer. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="allocatedOutboundPorts"> The number of outbound ports to be used for NAT. </param>
        /// <param name="frontendIPConfigurations"> The Frontend IP addresses of the load balancer. </param>
        /// <param name="backendAddressPool"> A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend IPs. </param>
        /// <param name="provisioningState"> The provisioning state of the outbound rule resource. </param>
        /// <param name="protocol"> The protocol for the outbound rule in load balancer. </param>
        /// <param name="enableTcpReset"> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </param>
        /// <param name="idleTimeoutInMinutes"> The timeout for the TCP idle connection. </param>
        internal OutboundRule(string id, string name, string etag, string type, int? allocatedOutboundPorts, IList<SubResource> frontendIPConfigurations, SubResource backendAddressPool, ProvisioningState? provisioningState, LoadBalancerOutboundRuleProtocol? protocol, bool? enableTcpReset, int? idleTimeoutInMinutes) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            AllocatedOutboundPorts = allocatedOutboundPorts;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPool = backendAddressPool;
            ProvisioningState = provisioningState;
            Protocol = protocol;
            EnableTcpReset = enableTcpReset;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
        }

        /// <summary> The name of the resource that is unique within the set of outbound rules used by the load balancer. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> The number of outbound ports to be used for NAT. </summary>
        public int? AllocatedOutboundPorts { get; set; }
        /// <summary> The Frontend IP addresses of the load balancer. </summary>
        public IList<SubResource> FrontendIPConfigurations { get; set; }
        /// <summary> A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend IPs. </summary>
        public SubResource BackendAddressPool { get; set; }
        /// <summary> The provisioning state of the outbound rule resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The protocol for the outbound rule in load balancer. </summary>
        public LoadBalancerOutboundRuleProtocol? Protocol { get; set; }
        /// <summary> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </summary>
        public bool? EnableTcpReset { get; set; }
        /// <summary> The timeout for the TCP idle connection. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
    }
}
