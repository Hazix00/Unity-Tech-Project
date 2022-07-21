using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class SNode : NodeBase
    {
        
        public int NodeId { get; set; }
        public string Name { get; set; }
        public string NodeType { get; set; }
        public int NextNodeId { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public SpaceParams Origin { get; set; }
        public List<NodeElementBase> NodeElements { get; set; }
        
        public SNode()
        {
            NodeType = nameof(SNode);
        }

    }


}