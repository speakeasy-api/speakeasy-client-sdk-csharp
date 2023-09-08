
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Operations
{
    using Speakeasy.Utils;
    
    
    public class GenerateOpenApiSpecForApiEndpointRequest
    {
        /// <summary>
        /// The ID of the ApiEndpoint to generate an OpenAPI specification for.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiEndpointID")]
        public string ApiEndpointID { get; set; } = default!;
        
        /// <summary>
        /// The ID of the Api to generate an OpenAPI specification for.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiID")]
        public string ApiID { get; set; } = default!;
        
        /// <summary>
        /// The version ID of the Api to generate an OpenAPI specification for.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=versionID")]
        public string VersionID { get; set; } = default!;
        
    }
    
}