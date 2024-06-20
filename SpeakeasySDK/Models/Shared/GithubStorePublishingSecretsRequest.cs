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
    using System.Collections.Generic;
    
    /// <summary>
    /// A request to store publishing secrets for a github target
    /// </summary>
    public class GithubStorePublishingSecretsRequest
    {

        /// <summary>
        /// The generation lock ID
        /// </summary>
        [JsonProperty("generate_gen_lock_id")]
        public string GenerateGenLockId { get; set; } = default!;

        /// <summary>
        /// A map of secrets to store in the GitHub target
        /// </summary>
        [JsonProperty("secrets")]
        public Dictionary<string, string>? Secrets { get; set; }
    }
}