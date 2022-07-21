using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class LNode : NodeBase
    {
        
        public int NodeId { get; set; }
        public string Name { get; set; }
        public string NodeType { get; set; }
        public List<ConditionBase> Conditions { get; set; }
        public LNode()
        {
            NodeType = nameof(LNode);
        }

    }


}