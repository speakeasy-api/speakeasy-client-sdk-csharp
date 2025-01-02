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
    
    public class CompositeSpecMetadata
    {

        /// <summary>
        /// The subscription ID for the remote source subscription, if applicable. This indicates that the namespace is created by a remote source and thus is composite.
        /// </summary>
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; } = default!;

        [JsonProperty("subscription_settings")]
        public RemoteSourceSubscriptionSettings SubscriptionSettings { get; set; } = default!;
    }
}