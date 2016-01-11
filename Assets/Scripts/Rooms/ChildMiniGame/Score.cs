using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Rooms.ChildMiniGame
{
    public class Score:MonoBehaviour
    {

        public Text myScore;
        public ChildMiniGameManager gm;

        void OnGUI()
        {
            if (myScore != null)
            {
                if (gm.IsWon())
                    myScore.text = ("Task Complete!").ToString();
                else
                    myScore.text = ("Differences Found: " + gm.found).ToString();

            }
        }

    }
}
