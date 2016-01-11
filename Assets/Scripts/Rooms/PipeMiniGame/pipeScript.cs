using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;
using System;
using UnityEngine.Networking;

namespace Assets.Scripts.Rooms.PipeMiniGame
{
    public class pipeScript : NetworkBehaviour
    {
        public GameManager gm;
        public PipeMiniGameManager pgm;

        public void CallCmdRotate()
        {

            gm.LocalPlayer.RotatePipe(this.gameObject);
        }



        [ClientRpc]
        public void RpcRotate()
        {
            transform.Rotate(0, 0, 90);
        }
    }
}
