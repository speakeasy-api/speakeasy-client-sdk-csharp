//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Hooks;
    using SpeakeasySDK.Models.Errors;
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils.Retries;
    using SpeakeasySDK.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Speakeasy API: The Speakeasy API allows teams to manage common operations with their APIs
    /// 
    /// <see>/docs} - The Speakeasy Platform Documentation</see>
    /// </summary>
    public interface ISpeakeasy
    {

        /// <summary>
        /// REST APIs for managing Api entities
        /// </summary>
        public IApis Apis { get; }

        /// <summary>
        /// REST APIs for managing ApiEndpoint entities
        /// </summary>
        public IApiEndpoints ApiEndpoints { get; }

        /// <summary>
        /// REST APIs for managing Version Metadata entities
        /// </summary>
        public IMetadata Metadata { get; }

        /// <summary>
        /// REST APIs for managing Schema entities
        /// </summary>
        public ISchemas Schemas { get; }
        public IArtifacts Artifacts { get; }

        /// <summary>
        /// REST APIs for managing Authentication
        /// </summary>
        public IAuth Auth { get; }

        /// <summary>
        /// REST APIs for retrieving request information
        /// </summary>
        public IRequests Requests { get; }
        public IGithub Github { get; }
        public IOrganizations Organizations { get; }

        /// <summary>
        /// REST APIs for managing reports
        /// </summary>
        public IReports Reports { get; }

        /// <summary>
        /// REST APIs for managing embeds
        /// </summary>
        public IEmbeds Embeds { get; }

        /// <summary>
        /// REST APIs for capturing event data
        /// </summary>
        public IEvents Events { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// Server identifiers available to the SDK.
        /// </summary>
        public enum Server {
        Prod,
        }

        /// <summary>
        /// Server URLs available to the SDK.
        /// </summary>
        public static readonly Dictionary<Server, string> ServerMap = new Dictionary<Server, string>()
        {
            { Server.Prod, "https://api.prod.speakeasyapi.dev" },
        };

        public string ServerUrl = "";
        public Server? ServerName = null;
        public string? WorkspaceID;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            if (this.ServerName is null)
            {
                this.ServerName = SDKConfig.Server.Prod;
            }
            else if (!SDKConfig.ServerMap.ContainsKey(this.ServerName.Value))
            {
                throw new Exception($"Invalid server \"{this.ServerName.Value}\"");
            }

            Dictionary<string, string> serverDefault = new Dictionary<string, string>();

            return Utilities.TemplateUrl(SDKConfig.ServerMap[this.ServerName.Value], serverDefault);
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Speakeasy API: The Speakeasy API allows teams to manage common operations with their APIs
    /// 
    /// <see>/docs} - The Speakeasy Platform Documentation</see>
    /// </summary>
    public class Speakeasy: ISpeakeasy
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "5.8.3";
        private const string _sdkGenVersion = "2.335.5";
        private const string _openapiDocVersion = "0.4.0 .";
        private const string _userAgent = "speakeasy-sdk/csharp 5.8.3 2.335.5 0.4.0 . SpeakeasySDK";
        private string _serverUrl = "";
        private SDKConfig.Server? _server = null;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public IApis Apis { get; private set; }
        public IApiEndpoints ApiEndpoints { get; private set; }
        public IMetadata Metadata { get; private set; }
        public ISchemas Schemas { get; private set; }
        public IArtifacts Artifacts { get; private set; }
        public IAuth Auth { get; private set; }
        public IRequests Requests { get; private set; }
        public IGithub Github { get; private set; }
        public IOrganizations Organizations { get; private set; }
        public IReports Reports { get; private set; }
        public IEmbeds Embeds { get; private set; }
        public IEvents Events { get; private set; }

        public Speakeasy(Security? security = null, Func<Security>? securitySource = null, string? workspaceID = null, SDKConfig.Server? server = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (server != null)
            {
              _server = server;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }

            SDKConfiguration = new SDKConfig()
            {
                WorkspaceID = workspaceID,
                ServerName = _server,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _defaultClient = SDKConfiguration.InitHooks(_defaultClient);


            Apis = new Apis(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            ApiEndpoints = new ApiEndpoints(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Metadata = new Metadata(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Schemas = new Schemas(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Artifacts = new Artifacts(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Auth = new Auth(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Requests = new Requests(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Github = new Github(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Organizations = new Organizations(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Reports = new Reports(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Embeds = new Embeds(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Events = new Events(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}