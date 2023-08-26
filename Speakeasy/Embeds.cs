
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Embeds
{
    using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Speakeasy.Models.Embeds;
using Speakeasy.Models.Shared;
using Speakeasy.Utils;

    public interface IEmbedsSDK
    {
        Task<GetEmbedAccessTokenResponse> GetEmbedAccessTokenAsync(GetEmbedAccessTokenRequest? request = null);
        Task<GetValidEmbedAccessTokensResponse> GetValidEmbedAccessTokensAsync();
        Task<RevokeEmbedAccessTokenResponse> RevokeEmbedAccessTokenAsync(RevokeEmbedAccessTokenRequest? request = null);
    }

    public class EmbedsSDK: IEmbedsSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.11.0";
        private const string _sdkGenVersion = "2.88.2";
        private const string _openapiDocVersion = "0.3.0";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public EmbedsSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Get an embed access token for the current workspace.
    /// 
    /// <remarks>
    /// Returns an embed access token for the current workspace. This can be used to authenticate access to externally embedded content.
    /// Filters can be applied allowing views to be filtered to things like particular customerIds.
    /// </remarks>
    /// </summary>
    public async Task<GetEmbedAccessTokenResponse> GetEmbedAccessTokenAsync(GetEmbedAccessTokenRequest? request = null)
    {
        string baseUrl = "";
        var message = GetEmbedAccessTokenRequest.BuildHttpRequestMessage("getEmbedAccessToken", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetEmbedAccessTokenResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.EmbedAccessTokenResponse = JsonConvert.DeserializeObject<EmbedAccessTokenResponse>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get all valid embed access tokens for the current workspace.
    /// </summary>
    public async Task<GetValidEmbedAccessTokensResponse> GetValidEmbedAccessTokensAsync()
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/v1/workspace/embed-access-tokens/valid");
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetValidEmbedAccessTokensResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.EmbedTokens = JsonConvert.DeserializeObject<List<EmbedToken>>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Revoke an embed access EmbedToken.
    /// </summary>
    public async Task<RevokeEmbedAccessTokenResponse> RevokeEmbedAccessTokenAsync(RevokeEmbedAccessTokenRequest? request = null)
    {
        string baseUrl = "";
        var message = RevokeEmbedAccessTokenRequest.BuildHttpRequestMessage("revokeEmbedAccessToken", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new RevokeEmbedAccessTokenResponse
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