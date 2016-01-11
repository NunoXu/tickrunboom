using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;
using System;
using UnityEngine.Networking;

namespace Assets.Scripts.Rooms.PipeMiniGame
{
    public class PipeScript : MonoBehaviour
    {
        public int id;
        public GameManager gm;
        public PipeMiniGameManager pgm;


        public void CallCmdRotate()
        {

            PlayContainer pc = new PlayContainer();

            pc.pieceId = this.id;
            pc.playId = 0;

            pgm.SendPlay(pc);
        }

        public void Rotate()
        {
            transform.Rotate(0, 0, 90);
        }
    }
}
