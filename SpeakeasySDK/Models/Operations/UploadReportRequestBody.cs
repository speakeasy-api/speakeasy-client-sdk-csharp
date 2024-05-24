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
    using SpeakeasySDK.Models.Operations;
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    
    /// <summary>
    /// The report file to upload provided as a multipart/form-data file segment.
    /// </summary>
    public class UploadReportRequestBody
    {

        [SpeakeasyMetadata("multipartForm:name=data,json")]
        public Report Data { get; set; } = default!;

        [SpeakeasyMetadata("multipartForm:file")]
        public File File { get; set; } = default!;
    }
}