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
    
    public class SuggestRequest
    {

        /// <summary>
        /// The OAS summary and diagnostics to use for the suggestion.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public SuggestRequestBody SuggestRequestBody { get; set; } = default!;

        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-session-id")]
        public string XSessionId { get; set; } = default!;
    }
}