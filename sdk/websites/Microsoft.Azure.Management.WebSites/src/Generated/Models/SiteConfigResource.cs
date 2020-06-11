// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Web app configuration ARM resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SiteConfigResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SiteConfigResource class.
        /// </summary>
        public SiteConfigResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteConfigResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="numberOfWorkers">Number of workers.</param>
        /// <param name="defaultDocuments">Default documents.</param>
        /// <param name="netFrameworkVersion">.NET Framework version.</param>
        /// <param name="phpVersion">Version of PHP.</param>
        /// <param name="pythonVersion">Version of Python.</param>
        /// <param name="nodeVersion">Version of Node.js.</param>
        /// <param name="powerShellVersion">Version of PowerShell.</param>
        /// <param name="linuxFxVersion">Linux App Framework and
        /// version</param>
        /// <param name="windowsFxVersion">Xenon App Framework and
        /// version</param>
        /// <param name="requestTracingEnabled">&lt;code&gt;true&lt;/code&gt;
        /// if request tracing is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="requestTracingExpirationTime">Request tracing
        /// expiration time.</param>
        /// <param name="remoteDebuggingEnabled">&lt;code&gt;true&lt;/code&gt;
        /// if remote debugging is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="remoteDebuggingVersion">Remote debugging
        /// version.</param>
        /// <param name="httpLoggingEnabled">&lt;code&gt;true&lt;/code&gt; if
        /// HTTP logging is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="logsDirectorySizeLimit">HTTP logs directory size
        /// limit.</param>
        /// <param
        /// name="detailedErrorLoggingEnabled">&lt;code&gt;true&lt;/code&gt; if
        /// detailed error logging is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="publishingUsername">Publishing user name.</param>
        /// <param name="appSettings">Application settings.</param>
        /// <param name="connectionStrings">Connection strings.</param>
        /// <param name="machineKey">Site MachineKey.</param>
        /// <param name="handlerMappings">Handler mappings.</param>
        /// <param name="documentRoot">Document root.</param>
        /// <param name="scmType">SCM type. Possible values include: 'None',
        /// 'Dropbox', 'Tfs', 'LocalGit', 'GitHub', 'CodePlexGit',
        /// 'CodePlexHg', 'BitbucketGit', 'BitbucketHg', 'ExternalGit',
        /// 'ExternalHg', 'OneDrive', 'VSO', 'VSTSRM'</param>
        /// <param name="use32BitWorkerProcess">&lt;code&gt;true&lt;/code&gt;
        /// to use 32-bit worker process; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="webSocketsEnabled">&lt;code&gt;true&lt;/code&gt; if
        /// WebSocket is enabled; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="alwaysOn">&lt;code&gt;true&lt;/code&gt; if Always On
        /// is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="javaVersion">Java version.</param>
        /// <param name="javaContainer">Java container.</param>
        /// <param name="javaContainerVersion">Java container version.</param>
        /// <param name="appCommandLine">App command line to launch.</param>
        /// <param name="managedPipelineMode">Managed pipeline mode. Possible
        /// values include: 'Integrated', 'Classic'</param>
        /// <param name="virtualApplications">Virtual applications.</param>
        /// <param name="loadBalancing">Site load balancing. Possible values
        /// include: 'WeightedRoundRobin', 'LeastRequests',
        /// 'LeastResponseTime', 'WeightedTotalTraffic', 'RequestHash'</param>
        /// <param name="experiments">This is work around for polymorphic
        /// types.</param>
        /// <param name="limits">Site limits.</param>
        /// <param name="autoHealEnabled">&lt;code&gt;true&lt;/code&gt; if Auto
        /// Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="autoHealRules">Auto Heal rules.</param>
        /// <param name="tracingOptions">Tracing options.</param>
        /// <param name="vnetName">Virtual Network name.</param>
        /// <param name="cors">Cross-Origin Resource Sharing (CORS)
        /// settings.</param>
        /// <param name="push">Push endpoint settings.</param>
        /// <param name="apiDefinition">Information about the formal API
        /// definition for the app.</param>
        /// <param name="apiManagementConfig">Azure API management settings
        /// linked to the app.</param>
        /// <param name="autoSwapSlotName">Auto-swap slot name.</param>
        /// <param name="localMySqlEnabled">&lt;code&gt;true&lt;/code&gt; to
        /// enable local MySQL; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="managedServiceIdentityId">Managed Service Identity
        /// Id</param>
        /// <param name="xManagedServiceIdentityId">Explicit Managed Service
        /// Identity Id</param>
        /// <param name="ipSecurityRestrictions">IP security restrictions for
        /// main.</param>
        /// <param name="scmIpSecurityRestrictions">IP security restrictions
        /// for scm.</param>
        /// <param name="scmIpSecurityRestrictionsUseMain">IP security
        /// restrictions for scm to use main.</param>
        /// <param name="http20Enabled">Http20Enabled: configures a web site to
        /// allow clients to connect over http2.0</param>
        /// <param name="minTlsVersion">MinTlsVersion: configures the minimum
        /// version of TLS required for SSL requests. Possible values include:
        /// '1.0', '1.1', '1.2'</param>
        /// <param name="ftpsState">State of FTP / FTPS service. Possible
        /// values include: 'AllAllowed', 'FtpsOnly', 'Disabled'</param>
        /// <param name="preWarmedInstanceCount">Number of preWarmed instances.
        /// This setting only applies to the Consumption and Elastic
        /// Plans</param>
        /// <param name="healthCheckPath">Health check path</param>
        public SiteConfigResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), int? numberOfWorkers = default(int?), IList<string> defaultDocuments = default(IList<string>), string netFrameworkVersion = default(string), string phpVersion = default(string), string pythonVersion = default(string), string nodeVersion = default(string), string powerShellVersion = default(string), string linuxFxVersion = default(string), string windowsFxVersion = default(string), bool? requestTracingEnabled = default(bool?), System.DateTime? requestTracingExpirationTime = default(System.DateTime?), bool? remoteDebuggingEnabled = default(bool?), string remoteDebuggingVersion = default(string), bool? httpLoggingEnabled = default(bool?), int? logsDirectorySizeLimit = default(int?), bool? detailedErrorLoggingEnabled = default(bool?), string publishingUsername = default(string), IList<NameValuePair> appSettings = default(IList<NameValuePair>), IList<ConnStringInfo> connectionStrings = default(IList<ConnStringInfo>), SiteMachineKey machineKey = default(SiteMachineKey), IList<HandlerMapping> handlerMappings = default(IList<HandlerMapping>), string documentRoot = default(string), string scmType = default(string), bool? use32BitWorkerProcess = default(bool?), bool? webSocketsEnabled = default(bool?), bool? alwaysOn = default(bool?), string javaVersion = default(string), string javaContainer = default(string), string javaContainerVersion = default(string), string appCommandLine = default(string), ManagedPipelineMode? managedPipelineMode = default(ManagedPipelineMode?), IList<VirtualApplication> virtualApplications = default(IList<VirtualApplication>), SiteLoadBalancing? loadBalancing = default(SiteLoadBalancing?), Experiments experiments = default(Experiments), SiteLimits limits = default(SiteLimits), bool? autoHealEnabled = default(bool?), AutoHealRules autoHealRules = default(AutoHealRules), string tracingOptions = default(string), string vnetName = default(string), CorsSettings cors = default(CorsSettings), PushSettings push = default(PushSettings), ApiDefinitionInfo apiDefinition = default(ApiDefinitionInfo), ApiManagementConfig apiManagementConfig = default(ApiManagementConfig), string autoSwapSlotName = default(string), bool? localMySqlEnabled = default(bool?), int? managedServiceIdentityId = default(int?), int? xManagedServiceIdentityId = default(int?), IList<IpSecurityRestriction> ipSecurityRestrictions = default(IList<IpSecurityRestriction>), IList<IpSecurityRestriction> scmIpSecurityRestrictions = default(IList<IpSecurityRestriction>), bool? scmIpSecurityRestrictionsUseMain = default(bool?), bool? http20Enabled = default(bool?), string minTlsVersion = default(string), string ftpsState = default(string), int? preWarmedInstanceCount = default(int?), string healthCheckPath = default(string))
            : base(id, name, kind, type)
        {
            NumberOfWorkers = numberOfWorkers;
            DefaultDocuments = defaultDocuments;
            NetFrameworkVersion = netFrameworkVersion;
            PhpVersion = phpVersion;
            PythonVersion = pythonVersion;
            NodeVersion = nodeVersion;
            PowerShellVersion = powerShellVersion;
            LinuxFxVersion = linuxFxVersion;
            WindowsFxVersion = windowsFxVersion;
            RequestTracingEnabled = requestTracingEnabled;
            RequestTracingExpirationTime = requestTracingExpirationTime;
            RemoteDebuggingEnabled = remoteDebuggingEnabled;
            RemoteDebuggingVersion = remoteDebuggingVersion;
            HttpLoggingEnabled = httpLoggingEnabled;
            LogsDirectorySizeLimit = logsDirectorySizeLimit;
            DetailedErrorLoggingEnabled = detailedErrorLoggingEnabled;
            PublishingUsername = publishingUsername;
            AppSettings = appSettings;
            ConnectionStrings = connectionStrings;
            MachineKey = machineKey;
            HandlerMappings = handlerMappings;
            DocumentRoot = documentRoot;
            ScmType = scmType;
            Use32BitWorkerProcess = use32BitWorkerProcess;
            WebSocketsEnabled = webSocketsEnabled;
            AlwaysOn = alwaysOn;
            JavaVersion = javaVersion;
            JavaContainer = javaContainer;
            JavaContainerVersion = javaContainerVersion;
            AppCommandLine = appCommandLine;
            ManagedPipelineMode = managedPipelineMode;
            VirtualApplications = virtualApplications;
            LoadBalancing = loadBalancing;
            Experiments = experiments;
            Limits = limits;
            AutoHealEnabled = autoHealEnabled;
            AutoHealRules = autoHealRules;
            TracingOptions = tracingOptions;
            VnetName = vnetName;
            Cors = cors;
            Push = push;
            ApiDefinition = apiDefinition;
            ApiManagementConfig = apiManagementConfig;
            AutoSwapSlotName = autoSwapSlotName;
            LocalMySqlEnabled = localMySqlEnabled;
            ManagedServiceIdentityId = managedServiceIdentityId;
            XManagedServiceIdentityId = xManagedServiceIdentityId;
            IpSecurityRestrictions = ipSecurityRestrictions;
            ScmIpSecurityRestrictions = scmIpSecurityRestrictions;
            ScmIpSecurityRestrictionsUseMain = scmIpSecurityRestrictionsUseMain;
            Http20Enabled = http20Enabled;
            MinTlsVersion = minTlsVersion;
            FtpsState = ftpsState;
            PreWarmedInstanceCount = preWarmedInstanceCount;
            HealthCheckPath = healthCheckPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of workers.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfWorkers")]
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Gets or sets default documents.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDocuments")]
        public IList<string> DefaultDocuments { get; set; }

        /// <summary>
        /// Gets or sets .NET Framework version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.netFrameworkVersion")]
        public string NetFrameworkVersion { get; set; }

        /// <summary>
        /// Gets or sets version of PHP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.phpVersion")]
        public string PhpVersion { get; set; }

        /// <summary>
        /// Gets or sets version of Python.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pythonVersion")]
        public string PythonVersion { get; set; }

        /// <summary>
        /// Gets or sets version of Node.js.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeVersion")]
        public string NodeVersion { get; set; }

        /// <summary>
        /// Gets or sets version of PowerShell.
        /// </summary>
        [JsonProperty(PropertyName = "properties.powerShellVersion")]
        public string PowerShellVersion { get; set; }

        /// <summary>
        /// Gets or sets linux App Framework and version
        /// </summary>
        [JsonProperty(PropertyName = "properties.linuxFxVersion")]
        public string LinuxFxVersion { get; set; }

        /// <summary>
        /// Gets or sets xenon App Framework and version
        /// </summary>
        [JsonProperty(PropertyName = "properties.windowsFxVersion")]
        public string WindowsFxVersion { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// request tracing is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestTracingEnabled")]
        public bool? RequestTracingEnabled { get; set; }

        /// <summary>
        /// Gets or sets request tracing expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestTracingExpirationTime")]
        public System.DateTime? RequestTracingExpirationTime { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// remote debugging is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remoteDebuggingEnabled")]
        public bool? RemoteDebuggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets remote debugging version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remoteDebuggingVersion")]
        public string RemoteDebuggingVersion { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if HTTP
        /// logging is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpLoggingEnabled")]
        public bool? HttpLoggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets HTTP logs directory size limit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logsDirectorySizeLimit")]
        public int? LogsDirectorySizeLimit { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// detailed error logging is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.detailedErrorLoggingEnabled")]
        public bool? DetailedErrorLoggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets publishing user name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingUsername")]
        public string PublishingUsername { get; set; }

        /// <summary>
        /// Gets or sets application settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appSettings")]
        public IList<NameValuePair> AppSettings { get; set; }

        /// <summary>
        /// Gets or sets connection strings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStrings")]
        public IList<ConnStringInfo> ConnectionStrings { get; set; }

        /// <summary>
        /// Gets site MachineKey.
        /// </summary>
        [JsonProperty(PropertyName = "properties.machineKey")]
        public SiteMachineKey MachineKey { get; private set; }

        /// <summary>
        /// Gets or sets handler mappings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.handlerMappings")]
        public IList<HandlerMapping> HandlerMappings { get; set; }

        /// <summary>
        /// Gets or sets document root.
        /// </summary>
        [JsonProperty(PropertyName = "properties.documentRoot")]
        public string DocumentRoot { get; set; }

        /// <summary>
        /// Gets or sets SCM type. Possible values include: 'None', 'Dropbox',
        /// 'Tfs', 'LocalGit', 'GitHub', 'CodePlexGit', 'CodePlexHg',
        /// 'BitbucketGit', 'BitbucketHg', 'ExternalGit', 'ExternalHg',
        /// 'OneDrive', 'VSO', 'VSTSRM'
        /// </summary>
        [JsonProperty(PropertyName = "properties.scmType")]
        public string ScmType { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to use
        /// 32-bit worker process; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.use32BitWorkerProcess")]
        public bool? Use32BitWorkerProcess { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// WebSocket is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webSocketsEnabled")]
        public bool? WebSocketsEnabled { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// Always On is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alwaysOn")]
        public bool? AlwaysOn { get; set; }

        /// <summary>
        /// Gets or sets java version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.javaVersion")]
        public string JavaVersion { get; set; }

        /// <summary>
        /// Gets or sets java container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.javaContainer")]
        public string JavaContainer { get; set; }

        /// <summary>
        /// Gets or sets java container version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.javaContainerVersion")]
        public string JavaContainerVersion { get; set; }

        /// <summary>
        /// Gets or sets app command line to launch.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appCommandLine")]
        public string AppCommandLine { get; set; }

        /// <summary>
        /// Gets or sets managed pipeline mode. Possible values include:
        /// 'Integrated', 'Classic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedPipelineMode")]
        public ManagedPipelineMode? ManagedPipelineMode { get; set; }

        /// <summary>
        /// Gets or sets virtual applications.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualApplications")]
        public IList<VirtualApplication> VirtualApplications { get; set; }

        /// <summary>
        /// Gets or sets site load balancing. Possible values include:
        /// 'WeightedRoundRobin', 'LeastRequests', 'LeastResponseTime',
        /// 'WeightedTotalTraffic', 'RequestHash'
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancing")]
        public SiteLoadBalancing? LoadBalancing { get; set; }

        /// <summary>
        /// Gets or sets this is work around for polymorphic types.
        /// </summary>
        [JsonProperty(PropertyName = "properties.experiments")]
        public Experiments Experiments { get; set; }

        /// <summary>
        /// Gets or sets site limits.
        /// </summary>
        [JsonProperty(PropertyName = "properties.limits")]
        public SiteLimits Limits { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if Auto
        /// Heal is enabled; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoHealEnabled")]
        public bool? AutoHealEnabled { get; set; }

        /// <summary>
        /// Gets or sets auto Heal rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoHealRules")]
        public AutoHealRules AutoHealRules { get; set; }

        /// <summary>
        /// Gets or sets tracing options.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tracingOptions")]
        public string TracingOptions { get; set; }

        /// <summary>
        /// Gets or sets virtual Network name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// Gets or sets cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cors")]
        public CorsSettings Cors { get; set; }

        /// <summary>
        /// Gets or sets push endpoint settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.push")]
        public PushSettings Push { get; set; }

        /// <summary>
        /// Gets or sets information about the formal API definition for the
        /// app.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiDefinition")]
        public ApiDefinitionInfo ApiDefinition { get; set; }

        /// <summary>
        /// Gets or sets azure API management settings linked to the app.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiManagementConfig")]
        public ApiManagementConfig ApiManagementConfig { get; set; }

        /// <summary>
        /// Gets or sets auto-swap slot name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoSwapSlotName")]
        public string AutoSwapSlotName { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to
        /// enable local MySQL; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localMySqlEnabled")]
        public bool? LocalMySqlEnabled { get; set; }

        /// <summary>
        /// Gets or sets managed Service Identity Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedServiceIdentityId")]
        public int? ManagedServiceIdentityId { get; set; }

        /// <summary>
        /// Gets or sets explicit Managed Service Identity Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.xManagedServiceIdentityId")]
        public int? XManagedServiceIdentityId { get; set; }

        /// <summary>
        /// Gets or sets IP security restrictions for main.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipSecurityRestrictions")]
        public IList<IpSecurityRestriction> IpSecurityRestrictions { get; set; }

        /// <summary>
        /// Gets or sets IP security restrictions for scm.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scmIpSecurityRestrictions")]
        public IList<IpSecurityRestriction> ScmIpSecurityRestrictions { get; set; }

        /// <summary>
        /// Gets or sets IP security restrictions for scm to use main.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scmIpSecurityRestrictionsUseMain")]
        public bool? ScmIpSecurityRestrictionsUseMain { get; set; }

        /// <summary>
        /// Gets or sets http20Enabled: configures a web site to allow clients
        /// to connect over http2.0
        /// </summary>
        [JsonProperty(PropertyName = "properties.http20Enabled")]
        public bool? Http20Enabled { get; set; }

        /// <summary>
        /// Gets or sets minTlsVersion: configures the minimum version of TLS
        /// required for SSL requests. Possible values include: '1.0', '1.1',
        /// '1.2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.minTlsVersion")]
        public string MinTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets state of FTP / FTPS service. Possible values include:
        /// 'AllAllowed', 'FtpsOnly', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.ftpsState")]
        public string FtpsState { get; set; }

        /// <summary>
        /// Gets or sets number of preWarmed instances.
        /// This setting only applies to the Consumption and Elastic Plans
        /// </summary>
        [JsonProperty(PropertyName = "properties.preWarmedInstanceCount")]
        public int? PreWarmedInstanceCount { get; set; }

        /// <summary>
        /// Gets or sets health check path
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthCheckPath")]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Push != null)
            {
                Push.Validate();
            }
            if (PreWarmedInstanceCount > 10)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PreWarmedInstanceCount", 10);
            }
            if (PreWarmedInstanceCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PreWarmedInstanceCount", 0);
            }
        }
    }
}
