
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
    
    public class GetWorkspaceAccessRequest
    {

        /// <summary>
        /// Unique identifier of the generation target.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=genLockId")]
        public string? GenLockId { get; set; }
    }
}