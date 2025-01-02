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
    using SpeakeasySDK.Utils;
    using System.Collections.Generic;
    
    public class OrganizationUsage
    {

        /// <summary>
        /// Indicates if the features are accessible
        /// </summary>
        [JsonProperty("accessible")]
        public bool Accessible { get; set; } = default!;

        /// <summary>
        /// Features that are accessible
        /// </summary>
        [JsonProperty("accessible_features")]
        public List<string> AccessibleFeatures { get; set; } = default!;

        /// <summary>
        /// List of generation lock IDs
        /// </summary>
        [JsonProperty("gen_lock_ids")]
        public List<string> GenLockIds { get; set; } = default!;

        /// <summary>
        /// The programming language used
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Maximum Number of operations per SDK specific in contract
        /// </summary>
        [JsonProperty("max_operations")]
        public long MaxOperations { get; set; } = default!;

        /// <summary>
        /// Number of operations performed
        /// </summary>
        [JsonProperty("number_of_operations")]
        public long NumberOfOperations { get; set; } = default!;

        /// <summary>
        /// Features that have been used
        /// </summary>
        [JsonProperty("used_features")]
        public List<string> UsedFeatures { get; set; } = default!;

        /// <summary>
        /// List of workspace IDs
        /// </summary>
        [JsonProperty("workspaces")]
        public List<string> Workspaces { get; set; } = default!;
    }
}