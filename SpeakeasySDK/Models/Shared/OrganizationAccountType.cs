
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
    using Newtonsoft.Json;
    using SpeakeasySDK.Utils;
    using System;
    
    public enum OrganizationAccountType
    {
        [JsonProperty("free")]
        Free,
        [JsonProperty("scale-up")]
        ScaleUp,
        [JsonProperty("enterprise")]
        Enterprise,
    }

    public static class OrganizationAccountTypeExtension
    {
        public static string Value(this OrganizationAccountType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static OrganizationAccountType ToEnum(this string value)
        {
            foreach(var field in typeof(OrganizationAccountType).GetFields())
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

                    if (enumVal is OrganizationAccountType)
                    {
                        return (OrganizationAccountType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum OrganizationAccountType");
        }
    }

}