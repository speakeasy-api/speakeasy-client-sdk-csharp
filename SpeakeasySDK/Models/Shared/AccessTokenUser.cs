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
    using System;
    
    public class AccessTokenUser
    {

        [JsonProperty("admin")]
        public bool? Admin { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("email_verified")]
        public bool? EmailVerified { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }
    }
}