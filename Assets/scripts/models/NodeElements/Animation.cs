using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class Animation
    {
        public string AnimationId { get; set; }
        public string Name { get; set; }
        public SpaceParams destination { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int LoopCount { get; set; }
    }
}