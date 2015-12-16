using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Traits
{
    public class ComputerGuy : Trait
    {
        public ComputerGuy(Sprite traitIcon) : base(traitIcon) { }

        public override bool Solve()
        {
            throw new NotImplementedException();
        }
    }
}
