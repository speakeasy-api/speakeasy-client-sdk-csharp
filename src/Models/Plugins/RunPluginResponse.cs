
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
    using System.Collections.Generic;
using System.Net.Http;
using SDK.Models.Shared;
    
    public class RunPluginResponse {
    /// <summary>
    /// OK
    /// </summary>
        public List<BoundedRequest>? BoundedRequests { get; set; }
        
        public string? ContentType { get; set; }
        
    /// <summary>
    /// Default error response
    /// </summary>
        public Error? Error { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
}