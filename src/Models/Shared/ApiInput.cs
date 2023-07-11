
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace SDK.Models.Shared
{
    using System.Collections.Generic;
using Newtonsoft.Json;
    
/// <summary>
/// An Api is representation of a API (a collection of API Endpoints) within the Speakeasy Platform.
/// </summary>
    public class ApiInput
    {
    /// <summary>
    /// The ID of this Api. This is a human-readable name (subject to change).
    /// </summary>
        
        [JsonProperty("api_id")]
        public string ApiId { get; set; }
        
    /// <summary>
    /// A detailed description of the Api.
    /// </summary>
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
    /// <summary>
    /// A set of values associated with a meta_data key. This field is only set on get requests.
    /// </summary>
        
        [JsonProperty("meta_data")]
        public Dictionary<string, List<string>>? MetaData { get; set; }
        
    /// <summary>
    /// The version ID of this Api. This is semantic version identifier.
    /// </summary>
        
        [JsonProperty("version_id")]
        public string VersionId { get; set; }
        
    }
}