using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Traits
{
    public abstract class Trait
    {
        protected string Name;
        public Sprite TraitIcon { get; protected set; }

        public Trait (Sprite traitIcon)
        {
            this.TraitIcon = traitIcon;
        }

        public abstract bool Solve();
    }
}
