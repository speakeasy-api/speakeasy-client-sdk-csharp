//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Shared
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    using System.Collections.Generic;
    
    /// <summary>
    /// An AccessToken is a token that can be used to authenticate with the Speakeasy API.
    /// </summary>
    public class AccessToken
    {

        [JsonProperty("access_token")]
        public string AccessTokenValue { get; set; } = default!;

        [JsonProperty("claims")]
        public Claims Claims { get; set; } = default!;

        [JsonProperty("feature_flags")]
        public List<FeatureFlag>? FeatureFlags { get; set; }

        [JsonProperty("user")]
        public AccessTokenUser User { get; set; } = default!;

        [JsonProperty("workspaces")]
        public List<Workspaces>? Workspaces { get; set; }
    }
}