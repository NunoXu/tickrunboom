using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Chat
{
    public class ChatMessage : MonoBehaviour
    {
        public Text Text;

        public void ShowMessage(string text)
        {
            Text.horizontalOverflow = HorizontalWrapMode.Wrap;
            Text.text = text;
        }

        public void ShowMessage(Player player, string text)
        {
            Text.horizontalOverflow = HorizontalWrapMode.Wrap;
            Text.text = player.NickName + ": " + text;
        }

    }
}
