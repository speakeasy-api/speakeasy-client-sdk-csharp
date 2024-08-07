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
    using SpeakeasySDK.Models.Operations;
    using SpeakeasySDK.Utils;
    
    public class RegisterSchemaRequest
    {

        /// <summary>
        /// The schema file to upload provided as a multipart/form-data file segment.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=multipart/form-data")]
        public RegisterSchemaRequestBody RequestBody { get; set; } = default!;

        /// <summary>
        /// The ID of the Api to get the schema for.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiID")]
        public string ApiID { get; set; } = default!;

        /// <summary>
        /// The version ID of the Api to delete metadata for.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=versionID")]
        public string VersionID { get; set; } = default!;
    }
}