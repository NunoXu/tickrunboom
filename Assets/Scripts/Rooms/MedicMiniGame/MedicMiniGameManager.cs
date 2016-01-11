using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;

namespace Assets.Scripts.Rooms.MedicMiniGame
{
    public class MedicMiniGameManager : MiniGame
    {
        public CardScript[] GameCards;
        public Image Background;
        


        protected override void Initialize()
        {
            base.Initialize();
            plays = new Play[] { new MedicCardPlay() };
            int i = 0;
            foreach (CardScript card in GameCards)
            {
                card.id = i++;
            }
        }

        
        public override bool IsWon()
        {
            foreach(CardScript card in GameCards)
            {
                if (card.flag == 1)
                    return false;
            }
            return true;
        }
        
    }
}
