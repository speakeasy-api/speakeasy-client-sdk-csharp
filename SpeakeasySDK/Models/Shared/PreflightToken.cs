//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Shared
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Utils;
    
    /// <summary>
    /// A PreflightToken is a token that allows access to the OCI distribution endpoints.
    /// </summary>
    public class PreflightToken
    {

        [JsonProperty("auth_token")]
        public string? AuthToken { get; set; }
    }
}