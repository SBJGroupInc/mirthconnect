

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using TypeSupport;

namespace MirthConnectClient
{
    internal class MirthConnectTypeConverter : JsonConverter
    {
        public JsonSerializerSettings SerializerSettings { get; private set; }
        public Dictionary<string, Type> TypeMappings { get; private set; } = new();
        public MirthConnectTypeConverter(JsonSerializerSettings serializerSettings)
        {
            this.SerializerSettings = serializerSettings;
            //TypeMappings.Add("ReceiverProperties", typeof(OpenapiGenerator.MirthConnect311.Model.ConnectorProperties));
            //TypeMappings.Add("DispatcherProperties", typeof(OpenapiGenerator.MirthConnect311.Model.ConnectorProperties));


        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType.Namespace != null && objectType.Namespace.StartsWith("OpenapiGenerator.MirthConnect311"))
            {
                return true;
            }
         
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {            
            object instance;
            ObjectFactory objectFactory = new ObjectFactory();
            instance = objectFactory.CreateEmptyObject(objectType);
            var props = objectType.GetTypeInfo().DeclaredProperties.ToList();

            JToken jo = JToken.Load(reader);
            Debug.WriteLine(string.Format("reading {0} as {1}", jo.ToString(), objectType));
            if (objectType.Name.Contains("ConnectorProperties"))
            {
                Debug.Assert(false);
            }
            var properties = jo.Children<JProperty>().ToList();
            if (properties.Count > 0)
            {
                var firstProperty = properties[0];
                if (firstProperty.Name.EndsWith(objectType.Name))
                {
                    ReadObjectAsType(serializer, instance, props, firstProperty.Value as JObject);
                    return instance;
                }
                var url = jo["url"];
                var message = jo["message"];
                var status = jo["status"];
                if (url != null && message != null && status != null)
                {
                    throw new OpenapiGenerator.MirthConnect311.Client.ApiException((int)status, (string)message);
                }
            }
            ReadObjectAsType(serializer, instance, props, jo as JObject);

            return instance;
        }


        public static void ReadObjectAsType(JsonSerializer serializer, object instance, List<PropertyInfo> props, JObject jo)
        {
            foreach (JProperty jp in jo.Properties())
            {

                PropertyInfo prop = props.FirstOrDefault(pi =>
                    pi.CanWrite && string.Compare(pi.Name,jp.Name,StringComparison.CurrentCultureIgnoreCase)==0);
                if (prop == null) continue;
                prop?.SetValue(instance, jp.Value.ToObject(prop.PropertyType, serializer));
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {            
            throw new NotImplementedException();
        }
    }
}