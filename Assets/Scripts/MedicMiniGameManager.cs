using UnityEngine;
using System.Collections;
using Assets.Scripts.Rooms;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;

namespace Assets.Scripts
{
    public class MedicMiniGameManager : MiniGame
    {

        public cardScript[] GameCards;
        public Image Background;
        
        public override bool IsWon()
        {
            foreach(cardScript card in GameCards)
            {
                if (card.flag == 1)
                    return false;
            }
            return true;
        }

        [ClientRpc]
        public override void RpcActivate()
        {
            Background.GetComponent<Image>().enabled = true;
            foreach (cardScript card in GameCards)
            {
                card.GetComponent<Image>().enabled = true;
                card.GetComponent<Button>().enabled = true;
            }
        }

        public override void RpcDeactivate()
        {
            Background.GetComponent<Image>().enabled = false;
            foreach (cardScript card in GameCards)
            {
                card.GetComponent<Image>().enabled = false;
                card.GetComponent<Button>().enabled = false;
            }
        }
    }
}
