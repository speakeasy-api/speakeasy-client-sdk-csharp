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
    
    public class GetRequestFromEventLogRequest
    {

        /// <summary>
        /// The ID of the request to retrieve.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=requestID")]
        public string RequestID { get; set; } = default!;
    }
}