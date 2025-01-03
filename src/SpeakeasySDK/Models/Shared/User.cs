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
    
    public class User
    {

        /// <summary>
        /// Indicates whether the user is an admin.
        /// </summary>
        [JsonProperty("admin")]
        public bool Admin { get; set; } = default!;

        /// <summary>
        /// Indicates whether the user has been confirmed.
        /// </summary>
        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; } = default!;

        /// <summary>
        /// Timestamp of the user&apos;s creation.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Identifier of the default workspace.
        /// </summary>
        [JsonProperty("default_workspace_id")]
        public string? DefaultWorkspaceId { get; set; } = null;

        /// <summary>
        /// Display name of the user.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// Email address of the user.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Indicates whether the email address has been verified.
        /// </summary>
        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; } = default!;

        /// <summary>
        /// GitHub handle of the user.
        /// </summary>
        [JsonProperty("github_handle")]
        public string? GithubHandle { get; set; } = null;

        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Indicates whether the user is internal.
        /// </summary>
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        /// <summary>
        /// Timestamp of the last login.
        /// </summary>
        [JsonProperty("last_login_at")]
        public DateTime? LastLoginAt { get; set; } = null;

        /// <summary>
        /// URL of the user&apos;s photo.
        /// </summary>
        [JsonProperty("photo_url")]
        public string? PhotoUrl { get; set; } = null;

        /// <summary>
        /// Timestamp of the user&apos;s last update.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Indicates whether the user has been whitelisted.
        /// </summary>
        [JsonProperty("whitelisted")]
        public bool Whitelisted { get; set; } = default!;
    }
}