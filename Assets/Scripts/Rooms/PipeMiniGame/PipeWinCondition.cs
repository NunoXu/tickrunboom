using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Rooms.PipeMiniGame
{
    public abstract class PipeWinCondition : MonoBehaviour
    {
        public abstract bool IsWon();
    }
}
