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
    /// A request to trigger an action on a GitHub target
    /// </summary>
    public class GithubTriggerActionRequest
    {

        /// <summary>
        /// The generation lock ID
        /// </summary>
        [JsonProperty("gen_lock_id")]
        public string GenLockId { get; set; } = default!;

        /// <summary>
        /// The GitHub organization name
        /// </summary>
        [JsonProperty("org")]
        public string Org { get; set; } = default!;

        /// <summary>
        /// The GitHub repository name
        /// </summary>
        [JsonProperty("repo_name")]
        public string RepoName { get; set; } = default!;

        /// <summary>
        /// Force an SDK generation
        /// </summary>
        [JsonProperty("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// A version to override the SDK too in workflow dispatch
        /// </summary>
        [JsonProperty("set_version")]
        public string? SetVersion { get; set; }

        /// <summary>
        /// The target name for the action
        /// </summary>
        [JsonProperty("target_name")]
        public string? TargetName { get; set; }
    }
}