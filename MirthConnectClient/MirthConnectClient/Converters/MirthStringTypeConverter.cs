using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace MirthConnectClient
{
    internal class MirthStringTypeConverter : JsonConverter
    {
        private JsonSerializerSettings serializerSettings;

        public MirthStringTypeConverter(JsonSerializerSettings serializerSettings)
        {
            this.serializerSettings = serializerSettings;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                case JsonToken.String:
                case JsonToken.Boolean:
                default:
                    return reader.Value.ToString();
                case JsonToken.Null:
                    return null;
                case JsonToken.StartObject:
                    var jo = JObject.Load(reader);
                    var encoding = jo["@encoding"];
                    var encodedValue = jo["$"];
                    if (encoding != null && encodedValue != null)
                    {
                        if ((string)encoding == "base64")
                        {
                            var bytes = Convert.FromBase64String((string)encodedValue);
                            return System.Text.Encoding.UTF8.GetString(bytes);
                        }
                    }
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}