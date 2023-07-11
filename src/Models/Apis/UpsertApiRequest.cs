
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace SDK.Models.Apis
{
    using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using SDK.Models.Shared;
using SDK.Utils;
    
    public class UpsertApiRequest
    {
    /// <summary>
    /// A JSON representation of the Api to upsert
    /// </summary>
        
        [JsonProperty("ApiInput")]
        public ApiInput ApiInput { get; set; }
        
    /// <summary>
    /// The ID of the Api to upsert.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, UpsertApiRequest value, string baseUrl)
        {
            if("upsertApi" == operationId)
            {
                
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                var message = new HttpRequestMessage(HttpMethod.Put, baseUrl + $"/v1/apis/{apiID}");

                string json = JsonConvert.SerializeObject(value.ApiInput, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});
                message.Content = new StringContent(json, Encoding.UTF8, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [UpsertApiRequest]");
        }
    }
}