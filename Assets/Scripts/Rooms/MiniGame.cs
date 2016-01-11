using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Rooms
{
    public abstract class MiniGame : MonoBehaviour
    {
        
        public GameManager gameManager;

        protected Play[] plays;

        public abstract bool IsWon();
        public virtual void PerformPlay(PlayContainer play)
        {
            plays[play.playId].PerformPlay(this, play);
        }
         

        public virtual void SendPlay(PlayContainer play)
        {
            if (!gameManager)
            {
                plays[play.playId].PerformPlay(this, play);
                return;
            }

           
            gameManager.SendPlay(play);
        }
        

        void Start ()
        {
            Initialize();
        }

        protected virtual void Initialize()
        {
            GameObject gmObj = GameObject.FindGameObjectWithTag("GameManager");
            if (gmObj)
            {
                gameManager = gmObj.GetComponent<GameManager>();
                gameManager.RegisterMiniGame(this);
            }

            GameObject serverGmObj = GameObject.FindGameObjectWithTag("ServerGameManager");
            if (serverGmObj)
            {
                serverGmObj.GetComponent<ServerGameManager>().RegisterMiniGame(this);
                gameManager.RegisterMiniGame(this);
            }
        }


    }
}
