using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class SoundElement : NodeElementBase
    {
        public string? Id { get; set; }
        public string ElementType { get; set; }
        public Sound Sound { get; set; }

        public SoundElement()
        {
            ElementType = nameof(SoundElement);
        }

    }


}