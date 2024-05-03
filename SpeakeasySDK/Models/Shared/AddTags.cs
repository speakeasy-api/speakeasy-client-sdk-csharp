
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
    /// Request body of tags to add to a revision
    /// </summary>
    public class AddTags
    {

        /// <summary>
        /// revision digest to add tags too sha256:...
        /// </summary>
        [JsonProperty("revision_digest")]
        public string RevisionDigest { get; set; } = default!;

        /// <summary>
        /// string tags to add to the revision
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = default!;
    }
}