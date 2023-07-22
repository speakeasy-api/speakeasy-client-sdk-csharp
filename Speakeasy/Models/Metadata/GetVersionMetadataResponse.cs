
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Metadata
{
    using System.Collections.Generic;
using System.Net.Http;
using Speakeasy.Models.Shared;
    
    public class GetVersionMetadataResponse {
        public string? ContentType { get; set; }
        
    /// <summary>
    /// Default error response
    /// </summary>
        public Error? Error { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    /// <summary>
    /// OK
    /// </summary>
        public List<VersionMetadata>? VersionMetadata { get; set; }
        
    }
}