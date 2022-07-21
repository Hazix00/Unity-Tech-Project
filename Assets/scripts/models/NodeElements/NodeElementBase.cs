using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityTechProject.Assets.scripts.converters;

namespace UnityTechProject.Assets.scripts.models
{
    [JsonConverter(typeof(NodeElementBaseConverter))]
    public interface NodeElementBase
    {
        public string? Id { get; set; }
        public string ElementType { get; set; }
    }


}