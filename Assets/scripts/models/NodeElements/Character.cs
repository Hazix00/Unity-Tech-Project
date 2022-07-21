using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class Character
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        
        public string Model { get; set; }
        
        public List<NodeElementBase> Elements { get; set; }

    }


}