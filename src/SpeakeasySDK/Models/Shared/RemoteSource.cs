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
    using System.Collections.Generic;
    
    /// <summary>
    /// Remote source configuration
    /// </summary>
    public class RemoteSource
    {

        [JsonProperty("inputs")]
        public List<RemoteDocument> Inputs { get; set; } = default!;

        /// <summary>
        /// A document hosted in the registry
        /// </summary>
        [JsonProperty("output")]
        public RemoteDocument Output { get; set; } = default!;

        [JsonProperty("overlays")]
        public List<RemoteDocument>? Overlays { get; set; }
    }
}