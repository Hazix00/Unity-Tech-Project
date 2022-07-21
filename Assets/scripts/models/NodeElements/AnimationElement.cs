using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class AnimationElement : NodeElementBase
    {
        public string? Id { get; set; }
        public string ElementType { get; set; }
        public Animation Animation { get; set; }
        public AnimationElement()
        {
            ElementType = nameof(AnimationElement);
        }
    }

}