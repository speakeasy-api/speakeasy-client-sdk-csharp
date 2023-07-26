
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Schemas
{
    using System;
using System.Net.Http;
using Newtonsoft.Json;
using Speakeasy.Utils;
    
    public class DownloadSchemaRequest
    {
    /// <summary>
    /// The ID of the Api to download the schema for.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
    /// <summary>
    /// The version ID of the Api to delete metadata for.
    /// </summary>
        
        [JsonProperty("versionID")]
        public string VersionID { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, DownloadSchemaRequest value, string baseUrl)
        {
            if("downloadSchema" == operationId)
            {
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var versionID = PathParamSerializer.Serialize("simple", false, value.VersionID);
                var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/v1/apis/{apiID}/version/{versionID}/schema/download");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [DownloadSchemaRequest]");
        }
    }
}