
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
    
    public class GenerateOpenApiSpecDiff
    {

        [JsonProperty("current_schema")]
        public string CurrentSchema { get; set; } = default!;

        [JsonProperty("new_schema")]
        public string NewSchema { get; set; } = default!;
    }
}