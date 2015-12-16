using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Traits
{
    class Strong : Trait
    {
        public Strong(Sprite traitIcon) : base(traitIcon) { }

        public override bool Solve()
        {
            throw new NotImplementedException();
        }
    }
}
