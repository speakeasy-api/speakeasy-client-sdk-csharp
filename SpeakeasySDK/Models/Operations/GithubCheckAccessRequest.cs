
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
    
    public class GithubCheckAccessRequest
    {

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=org")]
        public string Org { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=repo")]
        public string Repo { get; set; } = default!;
    }
}