using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using TypeSupport;

namespace MirthConnectClient
{
    internal class MirthListTypeConverter : JsonConverter
    {
        public MirthListTypeConverter(JsonSerializerSettings serializerSettings)
        {
            this.SerializerSettings = serializerSettings;
        }

        public JsonSerializerSettings SerializerSettings { get;  set; }

        public override bool CanConvert(Type objectType)
        {
            if (!objectType.IsGenericType) return false;
            return typeof(System.Collections.IList).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Type valueType = objectType.GenericTypeArguments[0];
            var result = Activator.CreateInstance(objectType) as System.Collections.IList;
            if (reader.TokenType == JsonToken.Null) return result;
            JObject jo = JObject.Load(reader);
            Debug.WriteLine(string.Format("reading {0} as {1}", jo.ToString(), objectType));
            var url = jo["url"];
            var message = jo["message"];
            var status = jo["status"];
            if (url != null && message != null && status != null)
            {
                throw new OpenapiGenerator.MirthConnect311.Client.ApiException((int)status, (string)message);
            }
            var firstProperty = jo.Children<JProperty>().ToList().First();
            var firstPropertyValueArray = firstProperty.Value as JArray;
            if (firstPropertyValueArray == null)
            {
                if (firstProperty.Name=="list" && firstProperty.Value.Type == JTokenType.Null)
                    return null;
                var firstPropertyValue = firstProperty.Value as JObject;
                firstProperty = firstPropertyValue.Children<JProperty>().ToList().First();
                firstPropertyValueArray = firstProperty.Value as JArray;
            }

            if (firstPropertyValueArray != null)
            {
                foreach (var arrayItem in firstPropertyValueArray)
                {
                    var arrayItemObject = arrayItem as JObject;
                    var value = JsonConvert.DeserializeObject(arrayItemObject.ToString(), valueType, SerializerSettings);
                    result.Add(value);
                }
            }
            else
            {
                //mirth sent json array without square brackets 
                var listEntry = jo["list"];
                if (listEntry != null)
                {
                    firstProperty = listEntry.Children<JProperty>().ToList().FirstOrDefault();
                }
                else
                {
                    firstProperty = jo.Children<JProperty>().ToList().FirstOrDefault();
                }
                if (firstProperty != null)
                {
                    var props = valueType.GetTypeInfo().DeclaredProperties.ToList();
                    ObjectFactory objectFactory = new ObjectFactory();
                    var instance = objectFactory.CreateEmptyObject(valueType);
                    MirthConnectTypeConverter.ReadObjectAsType(serializer, instance,
                        props, firstProperty.Value as JObject);
                    result.Add(instance);
                }
            }
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}