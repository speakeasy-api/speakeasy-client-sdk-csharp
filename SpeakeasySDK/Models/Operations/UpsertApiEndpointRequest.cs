
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Operations
{
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    
    public class UpsertApiEndpointRequest
    {

        /// <summary>
        /// A JSON representation of the ApiEndpoint to upsert.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public ApiEndpointInput ApiEndpoint { get; set; } = default!;

        /// <summary>
        /// The ID of the ApiEndpoint to upsert.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiEndpointID")]
        public string ApiEndpointID { get; set; } = default!;

        /// <summary>
        /// The ID of the Api the ApiEndpoint belongs to.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiID")]
        public string ApiID { get; set; } = default!;

        /// <summary>
        /// The version ID of the Api the ApiEndpoint belongs to.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=versionID")]
        public string VersionID { get; set; } = default!;
    }
}