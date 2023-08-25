
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
    using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Speakeasy.ApiEndpoints;
using Speakeasy.Apis;
using Speakeasy.Embeds;
using Speakeasy.Metadata;
using Speakeasy.Plugins;
using Speakeasy.Requests;
using Speakeasy.Schemas;
using Speakeasy.Models.Operations;
using Speakeasy.Models.Shared;
using Speakeasy.Models.Security;
using Speakeasy.Utils;

    public interface ISpeakeasySDK
    {
        public IApiEndpointsSDK ApiEndpoints { get; }
        public IApisSDK Apis { get; }
        public IEmbedsSDK Embeds { get; }
        public IMetadataSDK Metadata { get; }
        public IPluginsSDK Plugins { get; }
        public IRequestsSDK Requests { get; }
        public ISchemasSDK Schemas { get; }
    }public class SDKConfig
    {
    }

    public class SpeakeasySDK: ISpeakeasySDK
    {
        public SDKConfig Config { get; private set; }
        public static Dictionary<string, string> ServerList = new Dictionary<string, string>()
        {
            {"Serverprod", "https://api.prod.speakeasyapi.dev" },
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "1.10.1";
        private const string _sdkGenVersion = "2.87.1";
        private const string _openapiDocVersion = "0.3.0";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;
        public IApiEndpointsSDK ApiEndpoints { get; private set; }
        public IApisSDK Apis { get; private set; }
        public IEmbedsSDK Embeds { get; private set; }
        public IMetadataSDK Metadata { get; private set; }
        public IPluginsSDK Plugins { get; private set; }
        public IRequestsSDK Requests { get; private set; }
        public ISchemasSDK Schemas { get; private set; }

        public SpeakeasySDK(HttpClient? client = null, string? serverUrl = null, Security? security = null)
        {
            _defaultClient = new SpeakeasyHttpClient(client);
            if(client == null)
            {
                var _serverUrl = serverUrl ?? SpeakeasySDK.ServerList["Serverprod"];

                _defaultClient.SetBaseUrl(_serverUrl);
            }
            _securityClient = new SpeakeasyHttpClient(_defaultClient.Client);
            if(security != null)
            {
                Security.Apply(security, _securityClient);
            }

            Config = new SDKConfig()
            {
            };
            ApiEndpoints = new ApiEndpointsSDK(_defaultClient, _securityClient, Config);
            Apis = new ApisSDK(_defaultClient, _securityClient, Config);
            Embeds = new EmbedsSDK(_defaultClient, _securityClient, Config);
            Metadata = new MetadataSDK(_defaultClient, _securityClient, Config);
            Plugins = new PluginsSDK(_defaultClient, _securityClient, Config);
            Requests = new RequestsSDK(_defaultClient, _securityClient, Config);
            Schemas = new SchemasSDK(_defaultClient, _securityClient, Config);
        }
        
    /// <summary>
    /// Validate the current api key.
    /// </summary>
    public async Task<ValidateApiKeyResponse> ValidateApiKeyAsync()
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/v1/auth/validate");
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new ValidateApiKeyResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }
    }
}