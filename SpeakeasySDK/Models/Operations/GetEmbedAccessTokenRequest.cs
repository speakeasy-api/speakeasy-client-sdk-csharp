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
    
    public class GetEmbedAccessTokenRequest
    {

        /// <summary>
        /// The description of the embed access token.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=description")]
        public string? Description { get; set; }

        /// <summary>
        /// The duration (in minutes) of the embed access token.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=duration")]
        public long? Duration { get; set; }

        /// <summary>
        /// The filter to apply to the query.
        /// </summary>
        [SpeakeasyMetadata("queryParam:serialization=json,name=filters")]
        public Filters? Filters { get; set; }
    }
}