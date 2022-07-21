using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class Sound
    {
        public string ObjectName { get; set; }
        public string ObjectId { get; set; }
        public string AudioType { get; set; }
        public string AudioUrl { get; set; }
        public bool Loop { get; set; }
        public float Volume { get; set; }
        public float Pitch { get; set; }
        public string SpatialMode { get; set; }
        public float MinDistance { get; set; }
        public float MaxDistance { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

    }


}