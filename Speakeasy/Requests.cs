
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Requests
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Speakeasy.Models.Requests;
using Speakeasy.Models.Shared;
using Speakeasy.Utils;

    public interface IRequestsSDK
    {
        Task<GenerateRequestPostmanCollectionResponse> GenerateRequestPostmanCollectionAsync(GenerateRequestPostmanCollectionRequest? request = null);
        Task<GetRequestFromEventLogResponse> GetRequestFromEventLogAsync(GetRequestFromEventLogRequest? request = null);
        Task<QueryEventLogResponse> QueryEventLogAsync(QueryEventLogRequest? request = null);
    }

    public class RequestsSDK: IRequestsSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.3.1";
        private const string _sdkGenVersion = "2.70.2";
        private const string _openapiDocVersion = "0.3.0";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public RequestsSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Generate a Postman collection for a particular request.
    /// 
    /// <remarks>
    /// Generates a Postman collection for a particular request. 
    /// Allowing it to be replayed with the same inputs that were captured by the SDK.
    /// </remarks>
    /// </summary>
    public async Task<GenerateRequestPostmanCollectionResponse> GenerateRequestPostmanCollectionAsync(GenerateRequestPostmanCollectionRequest? request = null)
    {
        string baseUrl = "";
        var message = GenerateRequestPostmanCollectionRequest.BuildHttpRequestMessage("generateRequestPostmanCollection", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GenerateRequestPostmanCollectionResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/octet-stream",response.ContentType))
            {
                response.PostmanCollection = await response.RawResponse.Content.ReadAsByteArrayAsync();
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get information about a particular request.
    /// </summary>
    public async Task<GetRequestFromEventLogResponse> GetRequestFromEventLogAsync(GetRequestFromEventLogRequest? request = null)
    {
        string baseUrl = "";
        var message = GetRequestFromEventLogRequest.BuildHttpRequestMessage("getRequestFromEventLog", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetRequestFromEventLogResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.UnboundedRequest = JsonConvert.DeserializeObject<UnboundedRequest>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Query the event log to retrieve a list of requests.
    /// 
    /// <remarks>
    /// Supports retrieving a list of request captured by the SDK for this workspace.
    /// Allows the filtering of requests on a number of criteria such as ApiID, VersionID, Path, Method, etc.
    /// </remarks>
    /// </summary>
    public async Task<QueryEventLogResponse> QueryEventLogAsync(QueryEventLogRequest? request = null)
    {
        string baseUrl = "";
        var message = QueryEventLogRequest.BuildHttpRequestMessage("queryEventLog", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new QueryEventLogResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.BoundedRequests = JsonConvert.DeserializeObject<List<BoundedRequest>>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    }
}