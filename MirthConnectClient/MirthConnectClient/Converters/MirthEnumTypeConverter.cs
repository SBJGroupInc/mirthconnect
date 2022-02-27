using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;

namespace MirthConnectClient
{
    internal class MirthEnumTypeConverter : JsonConverter
    {
        public MirthEnumTypeConverter(JsonSerializerSettings serializerSettings)
        {
            SerializerSettings = serializerSettings;
        }

        public JsonSerializerSettings SerializerSettings { get; }

        public override bool CanConvert(Type objectType)
        {
            if (objectType.IsEnum) return true;
            if (objectType.IsGenericType)
            {
                if (objectType.GetGenericTypeDefinition() == typeof(Nullable))
                {
                    if (objectType.GetGenericArguments()[0].IsEnum)
                        return true;
                }
                
            }
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jt = JToken.Load(reader);
            TypeConverter conv = TypeDescriptor.GetConverter(objectType);
            var jtString = jt.ToString();
            if (string.IsNullOrWhiteSpace(jtString)) return null;
            var instance = conv.ConvertFrom(jtString);
            return instance;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}