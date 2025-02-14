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
    using System;
    
    public enum RevisionContentsMetadataType
    {
        [JsonProperty("OPENAPI_BUNDLE")]
        OpenapiBundle,
        [JsonProperty("OPENAPI_OVERLAY")]
        OpenapiOverlay,
    }

    public static class RevisionContentsMetadataTypeExtension
    {
        public static string Value(this RevisionContentsMetadataType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static RevisionContentsMetadataType ToEnum(this string value)
        {
            foreach(var field in typeof(RevisionContentsMetadataType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is RevisionContentsMetadataType)
                    {
                        return (RevisionContentsMetadataType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum RevisionContentsMetadataType");
        }
    }

}