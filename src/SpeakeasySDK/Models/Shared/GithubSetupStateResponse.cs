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
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    
    /// <summary>
    /// The state of a particular SDK targets github setup
    /// </summary>
    public class GithubSetupStateResponse
    {

        [JsonProperty("actions")]
        public Actions Actions { get; set; } = default!;

        [JsonProperty("app_installed")]
        public bool AppInstalled { get; set; } = default!;

        [JsonProperty("secrets")]
        public Secrets Secrets { get; set; } = default!;
    }
}