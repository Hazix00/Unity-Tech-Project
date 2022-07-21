using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class EventCondition : ConditionBase
    {
        public string ConditionType { get; set; }
        public Event Event { get; set; }
        public EventCondition()
        {
            ConditionType = nameof(EventCondition);
        }

    }


}