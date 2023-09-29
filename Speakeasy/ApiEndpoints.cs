
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
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// REST APIs for managing ApiEndpoint entities
    /// </summary>
    public interface IApiEndpointsSDK
    {

        /// <summary>
        /// Delete an ApiEndpoint.
        /// 
        /// <remarks>
        /// Delete an ApiEndpoint. This will also delete all associated Request Logs (if using a Postgres datastore).
        /// </remarks>
        /// </summary>
        Task<DeleteApiEndpointResponse> DeleteApiEndpointAsync(DeleteApiEndpointRequest? request = null);

        /// <summary>
        /// Find an ApiEndpoint via its displayName.
        /// 
        /// <remarks>
        /// Find an ApiEndpoint via its displayName (set by operationId from a registered OpenAPI schema).<br/>
        /// This is useful for finding the ID of an ApiEndpoint to use in the /v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID} endpoints.
        /// </remarks>
        /// </summary>
        Task<FindApiEndpointResponse> FindApiEndpointAsync(FindApiEndpointRequest? request = null);

        /// <summary>
        /// Generate an OpenAPI specification for a particular ApiEndpoint.
        /// 
        /// <remarks>
        /// This endpoint will generate a new operation in any registered OpenAPI document if the operation does not already exist in the document.<br/>
        /// Returns the original document and the newly generated document allowing a diff to be performed to see what has changed.
        /// </remarks>
        /// </summary>
        Task<GenerateOpenApiSpecForApiEndpointResponse> GenerateOpenApiSpecForApiEndpointAsync(GenerateOpenApiSpecForApiEndpointRequest? request = null);

        /// <summary>
        /// Generate a Postman collection for a particular ApiEndpoint.
        /// 
        /// <remarks>
        /// Generates a postman collection that allows the endpoint to be called from postman variables produced for any path/query/header parameters included in the OpenAPI document.
        /// </remarks>
        /// </summary>
        Task<GeneratePostmanCollectionForApiEndpointResponse> GeneratePostmanCollectionForApiEndpointAsync(GeneratePostmanCollectionForApiEndpointRequest? request = null);

        /// <summary>
        /// Get all Api endpoints for a particular apiID.
        /// </summary>
        Task<GetAllApiEndpointsResponse> GetAllApiEndpointsAsync(GetAllApiEndpointsRequest? request = null);

        /// <summary>
        /// Get all ApiEndpoints for a particular apiID and versionID.
        /// </summary>
        Task<GetAllForVersionApiEndpointsResponse> GetAllForVersionApiEndpointsAsync(GetAllForVersionApiEndpointsRequest? request = null);

        /// <summary>
        /// Get an ApiEndpoint.
        /// </summary>
        Task<GetApiEndpointResponse> GetApiEndpointAsync(GetApiEndpointRequest? request = null);

        /// <summary>
        /// Upsert an ApiEndpoint.
        /// 
        /// <remarks>
        /// Upsert an ApiEndpoint. If the ApiEndpoint does not exist it will be created, otherwise it will be updated.
        /// </remarks>
        /// </summary>
        Task<UpsertApiEndpointResponse> UpsertApiEndpointAsync(UpsertApiEndpointRequest request);
    }

    /// <summary>
    /// REST APIs for managing ApiEndpoint entities
    /// </summary>
    public class ApiEndpointsSDK: IApiEndpointsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.15.0";
        private const string _sdkGenVersion = "2.139.1";
        private const string _openapiDocVersion = "0.3.0";
        private const string _userAgent = "speakeasy-sdk/csharp 1.15.0 2.139.1 0.3.0 SpeakeasySDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public ApiEndpointsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<DeleteApiEndpointResponse> DeleteApiEndpointAsync(DeleteApiEndpointRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new DeleteApiEndpointResponse
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
        

        public async Task<FindApiEndpointResponse> FindApiEndpointAsync(FindApiEndpointRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/v1/apis/{apiID}/version/{versionID}/api_endpoints/find/{displayName}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new FindApiEndpointResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiEndpoint = JsonConvert.DeserializeObject<ApiEndpoint>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        

        public async Task<GenerateOpenApiSpecForApiEndpointResponse> GenerateOpenApiSpecForApiEndpointAsync(GenerateOpenApiSpecForApiEndpointRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}/generate/openapi", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GenerateOpenApiSpecForApiEndpointResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.GenerateOpenApiSpecDiff = JsonConvert.DeserializeObject<GenerateOpenApiSpecDiff>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        

        public async Task<GeneratePostmanCollectionForApiEndpointResponse> GeneratePostmanCollectionForApiEndpointAsync(GeneratePostmanCollectionForApiEndpointRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}/generate/postman", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GeneratePostmanCollectionForApiEndpointResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/octet-stream",response.ContentType))
                {
                    response.PostmanCollection = await httpResponse.Content.ReadAsByteArrayAsync();
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        

        public async Task<GetAllApiEndpointsResponse> GetAllApiEndpointsAsync(GetAllApiEndpointsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/v1/apis/{apiID}/api_endpoints", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetAllApiEndpointsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiEndpoints = JsonConvert.DeserializeObject<List<ApiEndpoint>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        

        public async Task<GetAllForVersionApiEndpointsResponse> GetAllForVersionApiEndpointsAsync(GetAllForVersionApiEndpointsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/v1/apis/{apiID}/version/{versionID}/api_endpoints", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetAllForVersionApiEndpointsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiEndpoints = JsonConvert.DeserializeObject<List<ApiEndpoint>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        

        public async Task<GetApiEndpointResponse> GetApiEndpointAsync(GetApiEndpointRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetApiEndpointResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiEndpoint = JsonConvert.DeserializeObject<ApiEndpoint>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        

        public async Task<UpsertApiEndpointResponse> UpsertApiEndpointAsync(UpsertApiEndpointRequest request)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "ApiEndpointInput", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpsertApiEndpointResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiEndpoint = JsonConvert.DeserializeObject<ApiEndpoint>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        
    }
}