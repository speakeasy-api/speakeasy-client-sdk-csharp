
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace SDK.Models.Requests
{
    using System;
using System.Net.Http;
using Newtonsoft.Json;
using SDK.Utils;
    
    public class GetRequestFromEventLogRequest
    {
    /// <summary>
    /// The ID of the request to retrieve.
    /// </summary>
        
        [JsonProperty("requestID")]
        public string RequestID { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetRequestFromEventLogRequest value, string baseUrl)
        {
            if("getRequestFromEventLog" == operationId)
            {
                
                var requestID = PathParamSerializer.Serialize("simple", false, value.RequestID);
                var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/v1/eventlog/{requestID}");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetRequestFromEventLogRequest]");
        }
    }
}