using UnityEngine;
using System.Collections;
using System;

namespace Assets.Scripts.Rooms.ChildMiniGame
{
    public class ChildMiniGameManager : MiniGame
    {
        public int toWin;
        public int found;
        bool isWon;
        int score;

        public ButtonVisibility[] Buttons;
        public GameObject ButtonObjs;

        public override bool IsWon()
        {
            return toWin - found <= 0;
        }

        protected override void Initialize()
        {
            base.Initialize();
            found = 0;
            isWon = false;
            score = 0;

            Buttons = ButtonObjs.GetComponentsInChildren<ButtonVisibility>();

            plays = new Play[] { new ChildPressButtonPlay() };
            int i = 0;
            foreach (ButtonVisibility button in Buttons)
            {
                button.id = i++;
            }
        }
    }
}
