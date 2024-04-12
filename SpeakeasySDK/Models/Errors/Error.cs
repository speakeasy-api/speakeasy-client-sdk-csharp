
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Errors
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Utils;
    using System;
    
    /// <summary>
    /// The `Status` type defines a logical error model
    /// </summary>
    public class Error : Exception
    {

        /// <summary>
        /// A developer-facing error message.
        /// </summary>
        [JsonProperty("message")]
        private string? _message { get; set; }
        public override string Message { get {return _message ?? "";} }

        /// <summary>
        /// The HTTP status code
        /// </summary>
        [JsonProperty("status_code")]
        public int StatusCode { get; set; } = default!;
    }
}