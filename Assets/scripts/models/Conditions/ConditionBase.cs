using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityTechProject.Assets.scripts.converters;

namespace UnityTechProject.Assets.scripts.models
{
    [JsonConverter(typeof(ConditionBaseConverter))]
    public interface ConditionBase
    {
        public string ConditionType { get; set; }
    }


}