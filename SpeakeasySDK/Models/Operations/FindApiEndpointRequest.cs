//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Operations
{
    using SpeakeasySDK.Utils;
    
    public class FindApiEndpointRequest
    {

        /// <summary>
        /// The ID of the Api the ApiEndpoint belongs to.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiID")]
        public string ApiID { get; set; } = default!;

        /// <summary>
        /// The displayName of the ApiEndpoint to find (set by operationId from OpenAPI schema).
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=displayName")]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// The version ID of the Api the ApiEndpoint belongs to.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=versionID")]
        public string VersionID { get; set; } = default!;
    }
}