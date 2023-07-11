
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace SDK.Models.Embeds
{
    using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using SDK.Models.Shared;
using SDK.Utils;
    
    public class GetEmbedAccessTokenRequest
    {
    /// <summary>
    /// The description of the embed access token.
    /// </summary>
        
        [JsonProperty("description")]
        public string? Description { get; set; }
        
    /// <summary>
    /// The duration (in minutes) of the embed access token.
    /// </summary>
        
        [JsonProperty("duration")]
        public int? Duration { get; set; }
        
    /// <summary>
    /// The filter to apply to the query.
    /// </summary>
        
        [JsonProperty("filters")]
        public Filters? Filters { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetEmbedAccessTokenRequest value, string baseUrl)
        {
            if("getEmbedAccessToken" == operationId)
            {
                var queryParams = new List<string>();
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "description", "", value.Description));
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "duration", "", value.Duration));
                
                queryParams.Add($"filters={JsonConvert.SerializeObject(value.Filters, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }})}");
                var queryParamString = $"?{String.Join("&", queryParams)}";
                var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/v1/workspace/embed-access-token" + queryParamString);
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetEmbedAccessTokenRequest]");
        }
    }
}