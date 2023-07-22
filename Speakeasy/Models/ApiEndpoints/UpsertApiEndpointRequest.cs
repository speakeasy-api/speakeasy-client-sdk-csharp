
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.ApiEndpoints
{
    using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Speakeasy.Models.Shared;
using Speakeasy.Utils;
    
    public class UpsertApiEndpointRequest
    {
    /// <summary>
    /// A JSON representation of the ApiEndpoint to upsert.
    /// </summary>
        
        [JsonProperty("ApiEndpointInput")]
        public ApiEndpointInput ApiEndpointInput { get; set; }
        
    /// <summary>
    /// The ID of the ApiEndpoint to upsert.
    /// </summary>
        
        [JsonProperty("apiEndpointID")]
        public string ApiEndpointID { get; set; }
        
    /// <summary>
    /// The ID of the Api the ApiEndpoint belongs to.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
    /// <summary>
    /// The version ID of the Api the ApiEndpoint belongs to.
    /// </summary>
        
        [JsonProperty("versionID")]
        public string VersionID { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, UpsertApiEndpointRequest value, string baseUrl)
        {
            if("upsertApiEndpoint" == operationId)
            {
                
                
                var apiEndpointID = PathParamSerializer.Serialize("simple", false, value.ApiEndpointID);
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var versionID = PathParamSerializer.Serialize("simple", false, value.VersionID);
                var message = new HttpRequestMessage(HttpMethod.Put, baseUrl + $"/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}");

                string json = JsonConvert.SerializeObject(value.ApiEndpointInput, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});
                message.Content = new StringContent(json, Encoding.UTF8, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [UpsertApiEndpointRequest]");
        }
    }
}