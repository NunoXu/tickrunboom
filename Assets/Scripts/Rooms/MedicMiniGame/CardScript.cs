using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
using Assets.Scripts;

namespace Assets.Scripts.Rooms.MedicMiniGame
{
    public class CardScript : MonoBehaviour
    {
        public int flag = 0;
        public int id;

        public Sprite[] cardSprites;
        public Button myBtn;
        public CardScript[] adjacentCards;
        public MedicMiniGameManager mgm;
        public MedicCardPlay play = new MedicCardPlay();



        public void CallCmdFlip()
        {
            PlayContainer pc = new PlayContainer();
            
            pc.pieceId = this.id;
            pc.playId = 0;
            
            mgm.SendPlay(pc);
        }


        public void FlipAdjacent()
        {
            foreach (CardScript card in adjacentCards)
            {
                card.Flip();
            }
        }


        public void Flip()
        {
            if (flag == 1)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
            }

        }

        void OnGUI()
        {
            myBtn.image.sprite = cardSprites[flag];
        }
    }
}
