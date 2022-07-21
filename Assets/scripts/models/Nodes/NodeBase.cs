using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityTechProject.Assets.scripts.converters;

namespace UnityTechProject.Assets.scripts.models
{
    [JsonConverter(typeof(NodeBaseConverter))]
    public interface NodeBase
    {
        public int NodeId { get; set; }
        public string Name { get; set; }
        public string NodeType { get; set; }
    }


}