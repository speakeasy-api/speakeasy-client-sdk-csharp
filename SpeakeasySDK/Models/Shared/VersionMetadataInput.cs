
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
    
    /// <summary>
    /// A set of keys and associated values, attached to a particular version of an Api.
    /// </summary>
    public class VersionMetadataInput
    {

        /// <summary>
        /// The key for this metadata.
        /// </summary>
        [JsonProperty("meta_key")]
        public string MetaKey { get; set; } = default!;

        /// <summary>
        /// One of the values for this metadata.
        /// </summary>
        [JsonProperty("meta_value")]
        public string MetaValue { get; set; } = default!;
    }
}