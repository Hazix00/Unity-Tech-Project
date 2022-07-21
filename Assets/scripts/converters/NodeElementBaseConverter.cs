using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityTechProject.Assets.scripts.models;

namespace UnityTechProject.Assets.scripts.converters
{

    public class NodeElementBaseConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(NodeElementBase);
        }
        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader,
            Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var node = default(NodeElementBase);
            var nodeType = jsonObject["elementType"].Value<string>() + "Element";
            var nodeConcretType = Type.GetType(typeof(NodeElementBase).AssemblyQualifiedName.Replace(nameof(NodeElementBase), nodeType));
            node = (NodeElementBase)Activator.CreateInstance(nodeConcretType);
            serializer.Populate(jsonObject.CreateReader(), node);
            return node;
        }
    }


}