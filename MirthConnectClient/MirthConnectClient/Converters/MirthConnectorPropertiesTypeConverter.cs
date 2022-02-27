using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenapiGenerator.MirthConnect311.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using TypeSupport;

namespace MirthConnectClient
{
    internal class MirthConnectorPropertiesTypeConverter : JsonConverter
    {
        private JsonSerializerSettings serializerSettings;
        public MirthConnectorPropertiesTypeConverter(JsonSerializerSettings serializerSettings)
        {
            this.serializerSettings = serializerSettings;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsSubclassOf(typeof(ConnectorProperties));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken jo = JToken.Load(reader);
            Debug.WriteLine(string.Format("reading {0} as {1}", jo.ToString(), objectType));
            return new JsonConnectorProperties
            {
                Json = jo.ToString()
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}