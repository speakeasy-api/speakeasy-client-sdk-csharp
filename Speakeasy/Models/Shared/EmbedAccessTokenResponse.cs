
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Shared
{
    using Newtonsoft.Json;
    
/// <summary>
/// An EmbedAccessTokenResponse contains a token that can be used to embed a Speakeasy dashboard.
/// </summary>
    public class EmbedAccessTokenResponse
    {
        
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        
    }
}