using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace MirthConnectClient
{
    internal class MirthDateTimeTypeConverter : JsonConverter
    {
        public MirthDateTimeTypeConverter(JsonSerializerSettings serializerSettings)
        {
            SerializerSettings = serializerSettings;
        }

        public JsonSerializerSettings SerializerSettings { get; }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(DateTime)) return true;
            if (!objectType.IsGenericType) return false;
            if (objectType.GetGenericTypeDefinition() != typeof(Nullable<>)) return false;
            return objectType.GetGenericArguments()[0] == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var  jt = JToken.Load(reader);
            var jpValueObject = jt as JObject;
            var time = jpValueObject["time"];
            var timezone = jpValueObject["timezone"];
            if (time != null && timezone != null)
            {
                var nodaTimezone = NodaTime.DateTimeZoneProviders.Tzdb[(string)timezone];
                var unixEpoch = new NodaTime.LocalDateTime(1970, 1, 1, 0, 0);
                var zonedTime = unixEpoch.PlusMilliseconds((long)time).
                    InZoneStrictly(nodaTimezone)
                    .ToDateTimeUtc();
                return zonedTime;
            }
            return (DateTime)jt;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}