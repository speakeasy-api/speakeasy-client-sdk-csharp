
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Apis
{
    using Newtonsoft.Json;
    
/// <summary>
/// Configuration for filter operations
/// </summary>
    public class GetAllApiVersionsOp
    {
    /// <summary>
    /// Whether to AND or OR the filters
    /// </summary>
        
        [JsonProperty("and")]
        public bool And { get; set; }
        
    }
}