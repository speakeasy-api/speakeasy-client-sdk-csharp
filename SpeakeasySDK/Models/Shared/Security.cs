//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Shared
{
    using SpeakeasySDK.Utils;
    
    public class Security
    {

        [SpeakeasyMetadata("security:scheme=true,type=apiKey,subType=header,name=x-api-key")]
        public string? APIKey { get; set; }

        [SpeakeasyMetadata("security:scheme=true,type=http,subType=bearer,name=Authorization")]
        public string? Bearer { get; set; }
    }
}