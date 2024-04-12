
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
    
    public class GetRevisionsRequest
    {

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=namespace_id")]
        public string NamespaceId { get; set; } = default!;

        /// <summary>
        /// Token to retrieve the next page of results
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=next_page_token")]
        public string? NextPageToken { get; set; }
    }
}