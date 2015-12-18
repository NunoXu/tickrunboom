using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Traits
{
    class Mechanic : Trait
    {
        public Mechanic() : base() {

            Name = "Mechanic";
        }

        public override bool Solve()
        {
            throw new NotImplementedException();
        }
    }
}
