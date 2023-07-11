
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace SDK.Models.Metadata
{
    using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using SDK.Models.Shared;
using SDK.Utils;
    
    public class InsertVersionMetadataRequest
    {
    /// <summary>
    /// A JSON representation of the metadata to insert.
    /// </summary>
        
        [JsonProperty("VersionMetadataInput")]
        public VersionMetadataInput VersionMetadataInput { get; set; }
        
    /// <summary>
    /// The ID of the Api to insert metadata for.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
    /// <summary>
    /// The version ID of the Api to insert metadata for.
    /// </summary>
        
        [JsonProperty("versionID")]
        public string VersionID { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, InsertVersionMetadataRequest value, string baseUrl)
        {
            if("insertVersionMetadata" == operationId)
            {
                
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var versionID = PathParamSerializer.Serialize("simple", false, value.VersionID);
                var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/v1/apis/{apiID}/version/{versionID}/metadata");

                string json = JsonConvert.SerializeObject(value.VersionMetadataInput, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});
                message.Content = new StringContent(json, Encoding.UTF8, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [InsertVersionMetadataRequest]");
        }
    }
}