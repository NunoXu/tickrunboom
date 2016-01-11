using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Preferences : MonoBehaviour
    {

        public static string Nick = "Anon";
        public static int PlayerNumber = 3;

        public Text PlayerNumberText;
        public InputField NickText;

        void Start()
        {
            var playerNumber = int.Parse(PlayerNumberText.text);
            ServerGameManager.playerNumber = playerNumber;

            NickText.text = Nick;

        }

        public void SetPlayerNick(string value)
        {
            Nick = value;
        }


        public void SetPlayerNumber(string value)
        {
            var playerNumber = int.Parse(value);
            PlayerNumber = playerNumber;
            ServerGameManager.playerNumber = playerNumber;
        }
    }
}
