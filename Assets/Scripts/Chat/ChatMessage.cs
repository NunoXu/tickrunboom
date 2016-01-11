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

        public void ShowEndMessage(string text, Color c)
        {
            Text.horizontalOverflow = HorizontalWrapMode.Wrap;
            Text.color = c;
            Text.lineSpacing = 1.5f;
            Text.text = text;
        }

        public void ShowMessage(string playerNickname, string text)
        {
            Text.horizontalOverflow = HorizontalWrapMode.Wrap;
            Text.text = playerNickname + ": " + text;
        }

    }
}
