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
    
    public class RegisterSchemaFile
    {

        [SpeakeasyMetadata("multipartForm:content")]
        public byte[] Content { get; set; } = default!;

        [SpeakeasyMetadata("multipartForm:name=file")]
        public string FileName { get; set; } = default!;
    }
}