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
    using SpeakeasySDK.Utils;
    
    public class ShortURL
    {

        [JsonProperty("full_url")]
        public string FullUrl { get; set; } = default!;

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; } = default!;
    }
}