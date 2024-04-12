
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
    using System;
    
    /// <summary>
    /// An Api is representation of a API (a collection of API Endpoints) within the Speakeasy Platform.
    /// </summary>
    public class Api
    {

        /// <summary>
        /// The ID of this Api. This is a human-readable name (subject to change).
        /// </summary>
        [JsonProperty("api_id")]
        public string ApiId { get; set; } = default!;

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// A detailed description of the Api.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Determines if all the endpoints within the Api are found in the OpenAPI spec associated with the Api.
        /// </summary>
        [JsonProperty("matched")]
        public bool? Matched { get; set; }

        /// <summary>
        /// A set of values associated with a meta_data key. This field is only set on get requests.
        /// </summary>
        [JsonProperty("meta_data")]
        public Dictionary<string, List<string>>? MetaData { get; set; }

        /// <summary>
        /// Last update timestamp.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The version ID of this Api. This is semantic version identifier.
        /// </summary>
        [JsonProperty("version_id")]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// The workspace ID this Api belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}