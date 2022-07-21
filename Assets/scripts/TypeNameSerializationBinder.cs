using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Serialization;

namespace UnityTechProject.Assets.scripts
{

    public class TypeNameSerializationBinder : ISerializationBinder
    {
        public void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            assemblyName = null;
            typeName = serializedType.AssemblyQualifiedName;
        }

        public Type BindToType(string assemblyName, string typeName)
        {
            var resolvedTypeName = $"{typeName}, {assemblyName}";
            return Type.GetType(resolvedTypeName, true);
        }
    }


}