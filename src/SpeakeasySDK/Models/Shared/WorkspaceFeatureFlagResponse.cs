//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Shared
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    using System.Collections.Generic;
    
    /// <summary>
    /// Workspace feature flag response
    /// </summary>
    public class WorkspaceFeatureFlagResponse
    {

        [JsonProperty("feature_flags")]
        public List<FeatureFlag>? FeatureFlags { get; set; }
    }
}