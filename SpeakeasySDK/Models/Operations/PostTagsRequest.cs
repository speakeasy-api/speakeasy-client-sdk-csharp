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
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    
    public class PostTagsRequest
    {

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=namespace_name")]
        public string NamespaceName { get; set; } = default!;

        /// <summary>
        /// A JSON representation of the tags to add
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public AddTags? AddTags { get; set; }
    }
}