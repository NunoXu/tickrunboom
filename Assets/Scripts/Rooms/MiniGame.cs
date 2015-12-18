using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Rooms
{
    public abstract class MiniGame : NetworkBehaviour
    {
        [SyncVar]
        public int activePlayerId;

        public abstract bool IsWon();

        [ClientRpc]
        public abstract void RpcActivate();

        [ClientRpc]
        public abstract void RpcDeactivate();


    }
}
