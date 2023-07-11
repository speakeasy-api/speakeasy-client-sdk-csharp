
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace SDK.Models.Plugins
{
    using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using SDK.Models.Shared;
using SDK.Utils;
    
    public class RunPluginRequest
    {
    /// <summary>
    /// The filter to apply to the query.
    /// </summary>
        
        [JsonProperty("filters")]
        public Filters? Filters { get; set; }
        
    /// <summary>
    /// The ID of the plugin to run.
    /// </summary>
        
        [JsonProperty("pluginID")]
        public string PluginID { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, RunPluginRequest value, string baseUrl)
        {
            if("runPlugin" == operationId)
            {
                var queryParams = new List<string>();
                
                queryParams.Add($"filters={JsonConvert.SerializeObject(value.Filters, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }})}");
                
                var queryParamString = $"?{String.Join("&", queryParams)}";
                
                
                var pluginID = PathParamSerializer.Serialize("simple", false, value.PluginID);
                var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/v1/plugins/{pluginID}" + queryParamString);
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [RunPluginRequest]");
        }
    }
}