
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy
{
    using Newtonsoft.Json;
    using Speakeasy.Models.Operations;
    using Speakeasy.Models.Shared;
    using Speakeasy.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Speakeasy API: The Speakeasy API allows teams to manage common operations with their APIs
    /// 
    /// <see>https://speakeasyapi.dev/docs/} - The Speakeasy Platform Documentation</see>
    /// </summary>
    public interface ISpeakeasySDK
    {

        /// <summary>
        /// REST APIs for managing ApiEndpoint entities
        /// </summary>
        public IApiEndpointsSDK ApiEndpoints { get; }

        /// <summary>
        /// REST APIs for managing Api entities
        /// </summary>
        public IApisSDK Apis { get; }

        /// <summary>
        /// REST APIs for managing embeds
        /// </summary>
        public IEmbedsSDK Embeds { get; }

        /// <summary>
        /// REST APIs for managing Version Metadata entities
        /// </summary>
        public IMetadataSDK Metadata { get; }

        /// <summary>
        /// REST APIs for managing and running plugins
        /// </summary>
        public IPluginsSDK Plugins { get; }

        /// <summary>
        /// REST APIs for retrieving request information
        /// </summary>
        public IRequestsSDK Requests { get; }

        /// <summary>
        /// REST APIs for managing Schema entities
        /// </summary>
        public ISchemasSDK Schemas { get; }

        /// <summary>
        /// Validate the current api key.
        /// </summary>
        Task<ValidateApiKeyResponse> ValidateApiKeyAsync();
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// Speakeasy API: The Speakeasy API allows teams to manage common operations with their APIs
    /// 
    /// <see>https://speakeasyapi.dev/docs/} - The Speakeasy Platform Documentation</see>
    /// </summary>
    public class SpeakeasySDK: ISpeakeasySDK
    {
        public SDKConfig Config { get; private set; }
        public static Dictionary<string, string> ServerList = new Dictionary<string, string>()
        {
            {"Serverprod", "https://api.prod.speakeasyapi.dev" },
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "1.14.0";
        private const string _sdkGenVersion = "2.129.1";
        private const string _openapiDocVersion = "0.3.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IApiEndpointsSDK ApiEndpoints { get; private set; }
        public IApisSDK Apis { get; private set; }
        public IEmbedsSDK Embeds { get; private set; }
        public IMetadataSDK Metadata { get; private set; }
        public IPluginsSDK Plugins { get; private set; }
        public IRequestsSDK Requests { get; private set; }
        public ISchemasSDK Schemas { get; private set; }

        public SpeakeasySDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? SpeakeasySDK.ServerList["Serverprod"];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            ApiEndpoints = new ApiEndpointsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Apis = new ApisSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Embeds = new EmbedsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Metadata = new MetadataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Plugins = new PluginsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Requests = new RequestsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Schemas = new SchemasSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }

        public async Task<ValidateApiKeyResponse> ValidateApiKeyAsync()
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = baseUrl + "/v1/auth/validate";
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
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