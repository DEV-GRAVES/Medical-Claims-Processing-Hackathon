﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace CoreClaims.Infrastructure.Helpers
{
    public static class JsonSerializationHelper
    {
        private static readonly JsonSerializerSettings Settings = new()
        {
            ContractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            },
            Converters =
            {
                new StringEnumConverter()
            }
        };

        public static string SerializeItem<T>(T item)
        {
            return JsonConvert.SerializeObject(item, Settings);
        }

        public static T DeserializeItem<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data, Settings);
        }
    }
}
