﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sihirdar.WebService.Provider.RiotApi.Model.Misc.Converters
{
    class TimeSpanConverterFromS : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(int);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            if (token.Value<int?>() != null)
            {
                return TimeSpan.FromSeconds(token.Value<int>());
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, (long)(((TimeSpan)value).TotalSeconds));
        }
    }
}
