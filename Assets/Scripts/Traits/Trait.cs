using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Traits
{
    public abstract class Trait
    {
        public String traitName;

        public abstract bool Solve();
    }
}
