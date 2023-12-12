
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
    using SpeakeasySDK.Models.Operations;
    using SpeakeasySDK.Models.Shared;
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

        /// <summary>
        /// REST APIs for retrieving request information
        /// </summary>
        public IRequests Requests { get; }

        /// <summary>
        /// REST APIs for managing and running plugins
        /// </summary>
        public IPlugins Plugins { get; }

        /// <summary>
        /// REST APIs for managing embeds
        /// </summary>
        public IEmbeds Embeds { get; }

        /// <summary>
        /// Validate the current api key.
        /// </summary>
        Task<ValidateApiKeyResponse> ValidateApiKeyAsync();
    }
    
    public class SDKConfig
    {
        public static Dictionary<string, string> ServerList = new Dictionary<string, string>()
        {
            {"Serverprod", "https://api.prod.speakeasyapi.dev" },
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public string server = "";

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            if (!String.IsNullOrEmpty(this.server))
            {
                this.server = "Serverprod";
            }
            Dictionary<string, string> serverDefault = new Dictionary<string, string>();
            

            return Utilities.TemplateUrl(SDKConfig.ServerList[this.server], serverDefault);
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
        private const string _sdkVersion = "2.3.0";
        private const string _sdkGenVersion = "2.213.3";
        private const string _openapiDocVersion = "0.3.0";
        private const string _userAgent = "speakeasy-sdk/csharp 2.3.0 2.213.3 0.3.0 SpeakeasySDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IApis Apis { get; private set; }
        public IApiEndpoints ApiEndpoints { get; private set; }
        public IMetadata Metadata { get; private set; }
        public ISchemas Schemas { get; private set; }
        public IRequests Requests { get; private set; }
        public IPlugins Plugins { get; private set; }
        public IEmbeds Embeds { get; private set; }

        public Speakeasy(Security? security = null, string? server = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverUrl != null) {
                if (urlParams != null) {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            SDKConfiguration = new SDKConfig()
            {
                serverUrl = _serverUrl
            };

            Apis = new Apis(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            ApiEndpoints = new ApiEndpoints(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Metadata = new Metadata(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Schemas = new Schemas(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Requests = new Requests(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Plugins = new Plugins(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Embeds = new Embeds(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }

        public async Task<ValidateApiKeyResponse> ValidateApiKeyAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/v1/auth/validate";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ValidateApiKeyResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
    }
}