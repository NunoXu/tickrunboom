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

        public Text PlayerNumberText;
        public Text NickText;

        void Start()
        {
            var playerNumber = int.Parse(PlayerNumberText.text);
            ServerGameManager.playerNumber = playerNumber;

            NickText.text = PlayerPrefs.GetString("Nickname", "Anon");

        }

        public void SetPlayerNick(string value)
        {
            PlayerPrefs.SetString("Nickname", value);
        }


        public void SetPlayerNumber(string value)
        {
            var playerNumber = int.Parse(value);
            ServerGameManager.playerNumber = playerNumber;
        }
    }
}
