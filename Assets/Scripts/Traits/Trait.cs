using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Traits
{
    public abstract class Trait : MonoBehaviour
    {
        public string Name { get; set; }
        public Sprite TraitIcon;

        public abstract bool Solve();
    }
}
