
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
using Newtonsoft.Json;
using Speakeasy.Utils;
    
    public class DeleteApiEndpointRequest
    {
    /// <summary>
    /// The ID of the ApiEndpoint to delete.
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
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, DeleteApiEndpointRequest value, string baseUrl)
        {
            if("deleteApiEndpoint" == operationId)
            {
                
                var apiEndpointID = PathParamSerializer.Serialize("simple", false, value.ApiEndpointID);
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var versionID = PathParamSerializer.Serialize("simple", false, value.VersionID);
                var message = new HttpRequestMessage(HttpMethod.Delete, baseUrl + $"/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [DeleteApiEndpointRequest]");
        }
    }
}