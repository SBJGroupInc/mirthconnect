using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using TypeSupport;

namespace MirthConnectClient
{
    internal class MirthDictionaryTypeConverter : JsonConverter
    {
        public MirthDictionaryTypeConverter(JsonSerializerSettings serializerSettings)
        {
            SerializerSettings = serializerSettings;
        }

        public JsonSerializerSettings SerializerSettings { get; }

        public override bool CanConvert(Type objectType)
        {
            if (!objectType.IsGenericType) return false;
            return typeof(System.Collections.IDictionary).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Type keyType = objectType.GenericTypeArguments[0];
            Type valueType = objectType.GenericTypeArguments[1];
            var result = Activator.CreateInstance(objectType) as System.Collections.IDictionary;
            if (reader.TokenType == JsonToken.Null) return result;
            JObject jo = JObject.Load(reader);
            Debug.WriteLine(string.Format("reading {0} as {1}", jo.ToString(), objectType));
            var dictionaryType = jo.Children<JProperty>().ToList().First();
            var props = valueType.GetTypeInfo().DeclaredProperties.ToList();
            var entries= jo["entry"];
            if (entries == null)
            {
                var dictionaryTypeValue = dictionaryType.Value as JObject;
                entries = dictionaryTypeValue["entry"];
            }
            Debug.Assert(entries!=null); 

            foreach (var arrayItem in entries)
            {
                var arrayItemObject = arrayItem as JObject;
                JArray entryArray;
                JToken arrayToken ;
                if (arrayItemObject == null)
                {
                    var arrayItemProperty = arrayItem as JProperty;
                    entryArray = arrayItemProperty.Value as JArray;
                }
                else
                {
                    var firstProperty = arrayItemObject.Children<JProperty>().ToList().First();
                    entryArray = firstProperty.Value as JArray;
                }
                object key = null, value = null;
                if (entryArray == null)
                {
                    arrayToken = arrayItemObject;
                }
                else
                    arrayToken = entryArray;
                    switch (arrayToken.First.Type)
                    {
                        case JTokenType.String:
                            key = (string)arrayToken.First; break;
                    case JTokenType.Property:
                        var arrayTokenFirstProperty = arrayToken.First as JProperty;
                        key = (string)arrayTokenFirstProperty.Value; break;
                    default: Debug.Assert(false); break;
                    }
                switch (arrayToken.Last.Type)
                {
                    case JTokenType.Null:
                        value = null; break;
                    case JTokenType.Integer:
                        value = (int)arrayToken.Last; break;
                    case JTokenType.String:
                        value = (string)arrayToken.Last; break;
                    case JTokenType.Object:
                        value = JsonConvert.DeserializeObject((string)arrayToken.Last, valueType);
                        break;
                    case JTokenType.Property:
                        var arrayTokenLastProperty = arrayToken.Last as JProperty;
                        switch (arrayTokenLastProperty.Value.Type)
                        {
                            case JTokenType.Object:

                                ObjectFactory objectFactory = new ObjectFactory();
                                var instance = objectFactory.CreateEmptyObject(valueType);
                                MirthConnectTypeConverter.ReadObjectAsType(serializer, instance,
                                    props, arrayTokenLastProperty.Value as JObject);
                                value = instance;
                                break;
                            default:
                                value = Convert.ChangeType(arrayTokenLastProperty.Value, valueType);
                                break;
                        }                        
                        break;
                    default: Debug.Assert(false); break;
                }
                if (key != null)
                    result.Add(key, value);

            }
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}