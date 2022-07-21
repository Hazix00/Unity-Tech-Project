using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityTechProject.Assets.scripts.models
{

    public class CharacterElement : NodeElementBase
    {
        public string? Id { get; set; }
        public string ElementType { get; set; }
        public Character Character { get; set; }

        public CharacterElement()
        {
            ElementType = nameof(CharacterElement);
        }

    }


}