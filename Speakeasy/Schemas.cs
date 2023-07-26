
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Schemas
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Speakeasy.Models.Schemas;
using Speakeasy.Models.Shared;
using Speakeasy.Utils;

    public interface ISchemasSDK
    {
        Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest? request = null);
        Task<DownloadSchemaResponse> DownloadSchemaAsync(DownloadSchemaRequest? request = null);
        Task<DownloadSchemaRevisionResponse> DownloadSchemaRevisionAsync(DownloadSchemaRevisionRequest? request = null);
        Task<GetSchemaResponse> GetSchemaAsync(GetSchemaRequest? request = null);
        Task<GetSchemaDiffResponse> GetSchemaDiffAsync(GetSchemaDiffRequest? request = null);
        Task<GetSchemaRevisionResponse> GetSchemaRevisionAsync(GetSchemaRevisionRequest? request = null);
        Task<GetSchemasResponse> GetSchemasAsync(GetSchemasRequest? request = null);
        Task<RegisterSchemaResponse> RegisterSchemaAsync(RegisterSchemaRequest request);
    }

    public class SchemasSDK: ISchemasSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.5.0";
        private const string _sdkGenVersion = "2.73.0";
        private const string _openapiDocVersion = "0.3.0";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public SchemasSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Delete a particular schema revision for an Api.
    /// </summary>
    public async Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest? request = null)
    {
        string baseUrl = "";
        var message = DeleteSchemaRequest.BuildHttpRequestMessage("deleteSchema", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new DeleteSchemaResponse
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

        
    /// <summary>
    /// Download the latest schema for a particular apiID.
    /// </summary>
    public async Task<DownloadSchemaResponse> DownloadSchemaAsync(DownloadSchemaRequest? request = null)
    {
        string baseUrl = "";
        var message = DownloadSchemaRequest.BuildHttpRequestMessage("downloadSchema", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new DownloadSchemaResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = await response.RawResponse.Content.ReadAsByteArrayAsync();
            }
            if(Utilities.IsContentTypeMatch("application/x-yaml",response.ContentType))
            {
                response.Schema = await response.RawResponse.Content.ReadAsByteArrayAsync();
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Download a particular schema revision for an Api.
    /// </summary>
    public async Task<DownloadSchemaRevisionResponse> DownloadSchemaRevisionAsync(DownloadSchemaRevisionRequest? request = null)
    {
        string baseUrl = "";
        var message = DownloadSchemaRevisionRequest.BuildHttpRequestMessage("downloadSchemaRevision", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new DownloadSchemaRevisionResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = await response.RawResponse.Content.ReadAsByteArrayAsync();
            }
            if(Utilities.IsContentTypeMatch("application/x-yaml",response.ContentType))
            {
                response.Schema = await response.RawResponse.Content.ReadAsByteArrayAsync();
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get information about the latest schema.
    /// 
    /// <remarks>
    /// Returns information about the last uploaded schema for a particular API version. 
    /// This won't include the schema itself, that can be retrieved via the downloadSchema operation.
    /// </remarks>
    /// </summary>
    public async Task<GetSchemaResponse> GetSchemaAsync(GetSchemaRequest? request = null)
    {
        string baseUrl = "";
        var message = GetSchemaRequest.BuildHttpRequestMessage("getSchema", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetSchemaResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get a diff of two schema revisions for an Api.
    /// </summary>
    public async Task<GetSchemaDiffResponse> GetSchemaDiffAsync(GetSchemaDiffRequest? request = null)
    {
        string baseUrl = "";
        var message = GetSchemaDiffRequest.BuildHttpRequestMessage("getSchemaDiff", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetSchemaDiffResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.SchemaDiff = JsonConvert.DeserializeObject<SchemaDiff>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get information about a particular schema revision for an Api.
    /// 
    /// <remarks>
    /// Returns information about the last uploaded schema for a particular schema revision. 
    /// This won't include the schema itself, that can be retrieved via the downloadSchema operation.
    /// </remarks>
    /// </summary>
    public async Task<GetSchemaRevisionResponse> GetSchemaRevisionAsync(GetSchemaRevisionRequest? request = null)
    {
        string baseUrl = "";
        var message = GetSchemaRevisionRequest.BuildHttpRequestMessage("getSchemaRevision", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetSchemaRevisionResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get information about all schemas associated with a particular apiID.
    /// 
    /// <remarks>
    /// Returns information the schemas associated with a particular apiID. 
    /// This won't include the schemas themselves, they can be retrieved via the downloadSchema operation.
    /// </remarks>
    /// </summary>
    public async Task<GetSchemasResponse> GetSchemasAsync(GetSchemasRequest? request = null)
    {
        string baseUrl = "";
        var message = GetSchemasRequest.BuildHttpRequestMessage("getSchemas", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetSchemasResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schemata = JsonConvert.DeserializeObject<List<Schema>>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Register a schema.
    /// 
    /// <remarks>
    /// Allows uploading a schema for a particular API version.
    /// This will be used to populate ApiEndpoints and used as a base for any schema generation if present.
    /// </remarks>
    /// </summary>
    public async Task<RegisterSchemaResponse> RegisterSchemaAsync(RegisterSchemaRequest request)
    {
        string baseUrl = "";
        var message = RegisterSchemaRequest.BuildHttpRequestMessage("registerSchema", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new RegisterSchemaResponse
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