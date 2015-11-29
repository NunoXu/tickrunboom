using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class UIComponent
    {
        private GameObject component { get; set; }

        public UIComponent (GameObject component)
        {
            this.component = component;
        }

        public abstract void Update();
    }
}
