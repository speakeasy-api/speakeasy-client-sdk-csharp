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
    using SpeakeasySDK.Utils;
    
    public class DownloadSchemaRevisionRequest
    {

        /// <summary>
        /// The ID of the Api to retrieve schemas for.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiID")]
        public string ApiID { get; set; } = default!;

        /// <summary>
        /// The revision ID of the schema to retrieve.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=revisionID")]
        public string RevisionID { get; set; } = default!;

        /// <summary>
        /// The version ID of the Api to delete metadata for.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=versionID")]
        public string VersionID { get; set; } = default!;
    }
}