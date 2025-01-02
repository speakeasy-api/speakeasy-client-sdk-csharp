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
    
    public class SuggestItemsRequestBody
    {

        /// <summary>
        /// The list of &quot;things&quot; to get suggestions for. One suggestion will be returned for each item in the list.
        /// </summary>
        [JsonProperty("items")]
        public List<string> Items { get; set; } = default!;

        /// <summary>
        /// The prompt to use for the suggestion. Think of this as the &quot;preamble&quot;.
        /// </summary>
        [JsonProperty("prompt")]
        public string Prompt { get; set; } = default!;
    }
}