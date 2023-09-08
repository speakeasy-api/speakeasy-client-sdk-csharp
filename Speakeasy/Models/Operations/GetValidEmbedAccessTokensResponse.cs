
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Operations
{
    using Speakeasy.Models.Shared;
    using System.Collections.Generic;
    using System.Net.Http;
    using System;
    
    
    public class GetValidEmbedAccessTokensResponse
    {
        
        public string? ContentType { get; set; } = default!;
        
        /// <summary>
        /// OK
        /// </summary>
        
        public List<EmbedToken>? EmbedTokens { get; set; }
        
        /// <summary>
        /// Default error response
        /// </summary>
        
        public Error? Error { get; set; }
        
        
        public int StatusCode { get; set; } = default!;
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
    
}