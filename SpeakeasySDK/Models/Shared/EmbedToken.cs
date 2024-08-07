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
    
    /// <summary>
    /// A representation of an embed token granted for working with Speakeasy components.
    /// </summary>
    public class EmbedToken
    {

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The ID of the user that created this token.
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// A detailed description of the EmbedToken.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The time this token expires.
        /// </summary>
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The filters applied to this token.
        /// </summary>
        [JsonProperty("filters")]
        public string Filters { get; set; } = default!;

        /// <summary>
        /// The ID of this EmbedToken.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The last time this token was used.
        /// </summary>
        [JsonProperty("last_used")]
        public DateTime? LastUsed { get; set; }

        /// <summary>
        /// The time this token was revoked.
        /// </summary>
        [JsonProperty("revoked_at")]
        public DateTime? RevokedAt { get; set; }

        /// <summary>
        /// The ID of the user that revoked this token.
        /// </summary>
        [JsonProperty("revoked_by")]
        public string? RevokedBy { get; set; }

        /// <summary>
        /// The workspace ID this token belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}