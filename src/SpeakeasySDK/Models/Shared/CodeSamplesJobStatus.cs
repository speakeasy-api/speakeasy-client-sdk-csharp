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
    
    /// <summary>
    /// The current status of the job. Possible values are `pending` or `running`.
    /// </summary>
    public enum CodeSamplesJobStatus
    {
        [JsonProperty("pending")]
        Pending,
        [JsonProperty("running")]
        Running,
    }

    public static class CodeSamplesJobStatusExtension
    {
        public static string Value(this CodeSamplesJobStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CodeSamplesJobStatus ToEnum(this string value)
        {
            foreach(var field in typeof(CodeSamplesJobStatus).GetFields())
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

                    if (enumVal is CodeSamplesJobStatus)
                    {
                        return (CodeSamplesJobStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CodeSamplesJobStatus");
        }
    }

}