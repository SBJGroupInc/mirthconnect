using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace MirthConnectClient
{
    internal class CustomContractResolver : DefaultContractResolver
    {
        public CustomContractResolver(JsonSerializerSettings serializerSettings)
        {
            mirthConnectTypeConverter = new MirthConnectTypeConverter(serializerSettings);
            dictionaryTypeconverter = new MirthDictionaryTypeConverter(serializerSettings);
            listTypeconverter = new MirthListTypeConverter(serializerSettings);
            dateTimeTypeconverter = new MirthDateTimeTypeConverter(serializerSettings);
            enumTypeConverter = new MirthEnumTypeConverter(serializerSettings);
            stringTypeConverter = new MirthStringTypeConverter(serializerSettings);
            mirthConnectorPropertiesTypeConverter = new MirthConnectorPropertiesTypeConverter(serializerSettings);
        }
        public  JsonSerializerSettings SerializerSettings { get; set; }
        private JsonConverter mirthConnectTypeConverter ;
        private JsonConverter dictionaryTypeconverter ;
        private JsonConverter listTypeconverter  ;
        private JsonConverter dateTimeTypeconverter ;
        private JsonConverter enumTypeConverter ;
        private JsonConverter stringTypeConverter;
        private JsonConverter mirthConnectorPropertiesTypeConverter;
        protected override JsonConverter ResolveContractConverter(Type objectType)
        {
            if (objectType == null) return base.ResolveContractConverter(objectType);
            Debug.WriteLine(string.Format("Resolving converter for type {0}", objectType.FullName));
            if (objectType == typeof(string)) return stringTypeConverter;
            if (objectType.IsEnum) return enumTypeConverter;
            if (objectType.Namespace != null && objectType.Namespace.StartsWith("OpenapiGenerator.MirthConnect311"))
            {
                if (objectType.Name.EndsWith("ConnectorProperties"))
                    return mirthConnectorPropertiesTypeConverter;
                return mirthConnectTypeConverter;
            }

            if (objectType.IsGenericType)
            {
                var genericTypeDefinition = objectType.GetGenericTypeDefinition();
                if (genericTypeDefinition == typeof(List<>))
                    return listTypeconverter;
                if (genericTypeDefinition == typeof(System.Collections.Generic.Dictionary<,>))
                    return dictionaryTypeconverter;
                if (genericTypeDefinition == typeof(Nullable<>))
                {
                    Type itemType = objectType.GetGenericArguments()[0];
                    if (itemType.IsEnum)
                    {
                        return enumTypeConverter;
                    }
                    if (itemType == typeof(DateTime))
                    {
                        return dateTimeTypeconverter;
                    }
                }
            }

            if (objectType == typeof(DateTime))
            {
                return dateTimeTypeconverter;
            }
            return base.ResolveContractConverter(objectType);
        }
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            property.ShouldSerialize = instance =>
            {
                try
                {
                    PropertyInfo prop = (PropertyInfo)member;
                    if (prop.CanRead)
                    {
                        prop.GetValue(instance, null);
                        return true;
                    }
                }
                catch
                {
                }
                return false;
            };

            return property;
        }
    }
}