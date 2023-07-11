
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace SDK.Utils
{
    using System;
    using System.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class HeaderParamSerializer
    {
        public static string Serialize(bool explode, object? value)
        {
            if(value == null || Utilities.IsPrimitive(value) || Utilities.IsEnum(value) || Utilities.IsString(value))
            {
                return Utilities.ToString(value);
            }

            if(Utilities.IsDictionary(value))
            {
                var json = JsonConvert.SerializeObject(value);
                var map = JsonConvert.DeserializeObject<Dictionary<object, object>>(json);
                var separator = explode ? "=" : ",";
                return String.Join(",", from k in map.Keys select $"{Utilities.ToString(k)}{separator}{Utilities.ToString(map[k])}");
            }

            if(Utilities.IsList(value))
            {
                var json = JsonConvert.SerializeObject(value);
                var list = JsonConvert.DeserializeObject<List<object>>(json);
                return String.Join(",", from i in list select Utilities.ToString(i));
            }

            var props = value.GetType().GetProperties();
            var parsedProps = new List<string>();
            foreach(var prop in props)
            {
                var attr = (from c in prop.CustomAttributes
                    where c.ConstructorArguments.Count() > 0
                    select c).Last();

                var key = attr.ConstructorArguments.First().Value;
                var val = prop.GetValue(value);
                if(val == null)
                {
                    continue;
                }
                var strVal = Utilities.ToString(val);

                var kvSeparator = explode ? "=" : ",";
                parsedProps.Add($"{key}{kvSeparator}{strVal}");
            }

            return String.Join(",", parsedProps);
        }
    }
}